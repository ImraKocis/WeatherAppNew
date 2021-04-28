using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cites;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace VremenskaPrognozaMain
{
    //AIzaSyAqvKvAYfwV_krDEcNZmWBKAiKCnhFciGo api key
    public partial class FormPrognozeOdabraniGradovi : Form
    {
        private CityRepository cityRepository = new CityRepository();
        private WeatherRepository weatherRepository = new WeatherRepository();
        private BindingSource BindingSource = new BindingSource();
        private List<string> DaniZaGraf = new List<string>();
        private List<City> checkedCity = new List<City>();
        public FormPrognozeOdabraniGradovi()
        {
            InitializeComponent();
        }

        private void FormPrognozeOdabraniGradovi_Load(object sender, EventArgs e)
        {
            weatherRepository.ObrisiPrognozeIzDb();
            ChartTemps.Hide();
            IdGradaLbl.Hide();
            gMapControl.Hide();
            weatherRepository.DodajOdabranePrognoze();
            weatherRepository.DodajPrognozePovijest();
            BindingSource.DataSource = weatherRepository.DohvatiPrognozeOdabranihGradova();
            dataGridViewOdabraniGradovi.DataSource = BindingSource;
            DataGridViewCheckBoxColumn chkBox = new DataGridViewCheckBoxColumn();
            chkBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            chkBox.FalseValue = "false";
            chkBox.TrueValue = "true";
            chkBox.IndeterminateValue = "false";
            dataGridViewOdabraniGradovi.Columns.Add(chkBox);
            dataGridViewOdabraniGradovi.Columns[14].HeaderText = "Odbir grada";
            DataGridViewImageColumn btnMap = new DataGridViewImageColumn();
            btnMap.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/World_map.png");
            btnMap.Width = 20;
            btnMap.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewOdabraniGradovi.Columns.Add(btnMap);
            dataGridViewOdabraniGradovi.Columns[15].HeaderText = "Otvori u karti";
            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/delete_ico.png");
            btnDelete.Width = 20;
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewOdabraniGradovi.Columns.Add(btnDelete);
            dataGridViewOdabraniGradovi.Columns[16].HeaderText = "Ukloni grad";
            dataGridViewOdabraniGradovi.AutoGenerateColumns = false;
            DaniZaGraf.Clear();
            DateTime danas = DateTime.Now;
            DaniZaGraf.Add(danas.ToString("dd.MM."));
            for (int x = 1; x < 8; x++)
            {
                DateTime temp = danas.AddDays(x);
                comboBoxUnapred.Items.Add(temp.ToString("dd.MM.yyyy."));
                DaniZaGraf.Add(temp.ToString("dd.MM."));
            }
            comboBoxTipGrafa.Items.Add("Dnevna temperatura");
            comboBoxTipGrafa.Items.Add("Minimalna temperatura");
            comboBoxTipGrafa.Items.Add("Maksimalna temperatura");
            comboBoxTipGrafa.Items.Add("Temperatura subjektivnog dojma");
            comboBoxTipGrafa.Items.Add("Tlak zraka");
            comboBoxTipGrafa.Items.Add("Vlaga zraka");
            comboBoxTipGrafa.Items.Add("Postotak oblačnosti");
            comboBoxTipGrafa.Items.Add("Brzina vjetra");
        }
        
        public static long ConvertDatetimeToUnixTimeStamp(DateTime date)
        {
            var dateTimeOffset = new DateTimeOffset(date);
            var unixDateTime = dateTimeOffset.ToUnixTimeSeconds();
            return unixDateTime;
        }
        private void dataGridViewOdabraniGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridViewOdabraniGradovi.Rows[e.RowIndex].Selected = true;

            double lat = 0, lon = 0;
            if (dataGridViewOdabraniGradovi.CurrentCell.ColumnIndex.Equals(15) && e.RowIndex != -1)
            {
                int IdGrada = Convert.ToInt32(dataGridViewOdabraniGradovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                var lLonAndLat = cityRepository.DajLonLat(IdGrada);
                gMapControl.MapProvider = GMapProviders.GoogleMap;

                for (int i = 0; i < lLonAndLat.Count; i++)
                {
                    if (i == 1)
                    {
                        lon = lLonAndLat[i];
                    }
                    else if (i == 0)
                    {
                        lat = lLonAndLat[i];
                    }

                }
                gMapControl.Position = new PointLatLng(lat, lon);
                gMapControl.MinZoom = 0;
                gMapControl.MaxZoom = 18;
                gMapControl.Zoom = 5;

                PointLatLng pointLatLng = new PointLatLng(lat, lon);
                GMapMarker gMapMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.red_small);

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(gMapMarker);
                gMapControl.Overlays.Add(markers);

                gMapControl.Show();
            }

            if (dataGridViewOdabraniGradovi.CurrentCell.ColumnIndex.Equals(16) && e.RowIndex != -1)
            {
                int IdGrada = Convert.ToInt32(dataGridViewOdabraniGradovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormOdabraniObrisi brisanjeForm = new FormOdabraniObrisi(IdGrada, this);
                brisanjeForm.lblBrisanjeGrada.Text = "Želite li ukloniti " + dataGridViewOdabraniGradovi.Rows[e.RowIndex].Cells[1].Value.ToString() + " iz tablice";
                DataGridViewRow row = dataGridViewOdabraniGradovi.Rows[e.RowIndex];
                var grad = new City
                {
                    nCityID = (int)row.Cells[0].Value,
                    sCityName = (string)row.Cells[1].Value,
                    sCountryTag = ""
                };
                checkedCity.RemoveAll(x => x.nCityID == grad.nCityID);
                brisanjeForm.ShowDialog();
            }         
        }

        private void btnPrikaziGraf_Click(object sender, EventArgs e)
        {
            gMapControl.Hide();
            ChartTemps.Series.Clear();
            bool Prazno = true;
            bool PraznoTip = true;
            bool PrazanOdabir = true;
            if (comboBoxUnapred.SelectedItem == null)
            {
                const string message = "Niste odabrali raspon dana za prikaz grafa!";
                const string content = "Upozorenje";
                MessageBox.Show(message, content, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Prazno = true;
            }
            else 
            {
                Prazno = false;
            }
            if (comboBoxTipGrafa.SelectedItem == null)
            {
                const string message = "Niste odabrali tip grafa!";
                const string content = "Upozorenje";
                MessageBox.Show(message, content, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PraznoTip = true;
            }
            else 
            {
                PraznoTip = false;
            }
            if (checkedCity.Count <= 0)
            {
                ChartTemps.Hide();
                const string message = "Niste odabrali niti jedan grad!";
                const string content = "Upozorenje";
                MessageBox.Show(message, content, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PrazanOdabir = true;
            }
            else
            {
                PrazanOdabir = false;
            }
            if (!Prazno && !PraznoTip && !PrazanOdabir)
            {
                int dan = comboBoxUnapred.SelectedIndex + 1;
                for (int i = 0; i < checkedCity.Count; i++)
                {
                    var lTemperatura = weatherRepository.TemperatureOdabranogGrada(checkedCity[i].nCityID, dan, comboBoxTipGrafa.Text);                   
                    ChartTemps.Visible = true;
                    ChartTemps.Titles[0].Text = comboBoxTipGrafa.Text;
                    ChartTemps.Series.Add(checkedCity[i].sCityName);
                    ChartTemps.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    ChartTemps.Series[i].IsXValueIndexed = true;
                    for (int x = 0; x < lTemperatura.Count; x++)
                    {
                        ChartTemps.Series[i].Points.AddXY(DaniZaGraf[x], lTemperatura[x]);
                    }
                    lTemperatura.Clear();
                }
            }  
        }

        private void btnCloseGraph_Click(object sender, EventArgs e)
        {
            weatherRepository.ObrisiPrognozeIzDb();
            this.Close();
        }

        private void btnPrintToFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"E:/.NET/VremenskaPrognoza/VremenskaPrognoza/Print/Prognoza.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter file = new StreamWriter(fs))
            {
                int location = 1;
                file.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (DataGridViewColumn column in dataGridViewOdabraniGradovi.Columns)
                {
                    switch (location)
                    {
                        case 1:
                            file.Write("| {0, -25} |", column.HeaderText);
                            break;
                        case 15:
                            break;
                        case 16:
                            break;
                        case 17:
                            break;
                        default:
                            file.Write(" {0, -25} |", column.HeaderText);
                            break;
                    }
                    location++;
                }
                file.WriteLine("\n|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|");
                foreach (DataGridViewRow row in dataGridViewOdabraniGradovi.Rows)
                {
                    location = 1;
                    foreach (DataGridViewColumn column in dataGridViewOdabraniGradovi.Columns)
                    {
                        switch (location)
                        {
                            case 1:
                                file.Write("| {0, -25} |", row.Cells[column.Index].Value.ToString());
                                break;
                            case 15:
                                break;
                            case 16:
                                break;
                            case 17:
                                break;
                            default:
                                file.Write(" {0, -25} |", row.Cells[column.Index].Value.ToString());
                                break;
                        }
                        location++;
                    }
                    if (row.Index == dataGridViewOdabraniGradovi.Rows.Count - 1)
                        file.WriteLine("\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    else
                        file.WriteLine("\n|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|");
                }
                const string message = "Prognoza/e su spremne za ispis.";
                const string caption = "Uspješno dodano";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonGrafStatistika_Click(object sender, EventArgs e)
        {
            gMapControl.Hide();
            ChartTemps.Series.Clear();
            bool Prazno = true;
            bool PraznoTip = true;
            bool PrazanOdabir = true;
            if (comboBoxUnapred.SelectedItem == null)
            {
                const string message = "Niste odabrali raspon dana za prikaz grafa!";
                const string content = "Upozorenje";
                MessageBox.Show(message, content, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Prazno = true;
            }
            else
            {
                Prazno = false;
            }
            if (comboBoxTipGrafa.SelectedItem == null)
            {
                const string message = "Niste odabrali tip grafa!";
                const string content = "Upozorenje";
                MessageBox.Show(message, content, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PraznoTip = true;
            }
            else
            {
                PraznoTip = false;
            }
            if (checkedCity.Count <= 0)
            {
                ChartTemps.Hide();
                const string message = "Niste odabrali niti jedan grad!";
                const string content = "Upozorenje";
                MessageBox.Show(message, content, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PrazanOdabir = true;
            }
            else
            {
                PrazanOdabir = false;
            }
            if (!Prazno && !PraznoTip && !PrazanOdabir)
            {
                int dan = comboBoxUnapred.SelectedIndex + 1;
                for (int i = 0; i < checkedCity.Count; i++)
                {
                    var lTemperatura = weatherRepository.TemperatureOdabranogGrada(checkedCity[i].nCityID, dan, comboBoxTipGrafa.Text);
                    var lValls = lTemperatura.ToList();
                    List<float> MinAvgMax = new List<float>();
                    List<string> sMinAvgMax = new List<string>();
                    Console.WriteLine();
                    sMinAvgMax.Add("Minimalna vrijednost");
                    sMinAvgMax.Add("Srednja vrijednost");
                    sMinAvgMax.Add("Maksimalna vrijednost");
                    var minVall = lValls.Min();
                    MinAvgMax.Add(minVall);
                    ChartTemps.Visible = true;
                    ChartTemps.Titles[0].Text = comboBoxTipGrafa.Text;
                    ChartTemps.Series.Add(checkedCity[i].sCityName);
                    ChartTemps.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    ChartTemps.Series[i].IsXValueIndexed = true;
                    float allValls = 0;
                    float avgVall = 0;
                    for (int z = 0; z < lTemperatura.Count; z++)
                    {
                        allValls = allValls + lValls[z];
                        if (lTemperatura.Count - 1 == z)
                        {
                            avgVall = allValls / z + 1;
                            MinAvgMax.Add(avgVall);
                        }
                    }
                    var maxVall = lValls.Max();
                    MinAvgMax.Add(maxVall); 
                    for (int x = 0; x < 3; x++)
                    {
                        ChartTemps.Series[i].Points.AddXY(sMinAvgMax[x], MinAvgMax[x]);                     
                    }
                    lTemperatura.Clear();
                }
            }
        }

        private void textBoxSearchForStats_TextChanged(object sender, EventArgs e)
        {
            string enteredText = textBoxSearchForStats.Text;
            var gradovi = weatherRepository.DohvatiPrognozeOdabranihGradova();
            List<CityAndWeather> filteredCountries = new List<CityAndWeather>();
            filteredCountries = gradovi.Where(grad => grad.sCityName.ToLower().Contains(enteredText.ToLower())).ToList();
            BindingSource.DataSource = filteredCountries;
            dataGridViewOdabraniGradovi.DataSource = BindingSource;
            for (int i = 0; i < checkedCity.Count(); i++)
            {
                foreach (DataGridViewRow row in dataGridViewOdabraniGradovi.Rows)
                {
                    if ((int)row.Cells[0].Value == checkedCity[i].nCityID)
                    {
                        DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells[14];
                        chkCell.Value = "true";
                    }
                }
            }
        }

        private void dataGridViewOdabraniGradovi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 14)
            {
                DataGridViewRow row = dataGridViewOdabraniGradovi.Rows[e.RowIndex];
                bool isCellChecked = false;
                bool contains = false;
                var grad = new City
                {
                    nCityID = (int)row.Cells[0].Value,
                    sCityName = (string)row.Cells[1].Value,
                    sCountryTag = ""
                };
                if ((string)row.Cells[14].Value == "true")
                    isCellChecked = true;
                else
                    isCellChecked = false;
                foreach (var city in checkedCity)
                {
                    if (city.nCityID == grad.nCityID)
                    {
                        contains = true;
                        break;
                    }
                    else
                    {
                        contains = false;
                    }
                }
                //ako je celija checkana, a lista checkedCity ne sadrzi taj grad dodat ce ga u listu
                if (isCellChecked)
                {
                    if (!contains)
                    {
                        checkedCity.Add(grad);
                    }
                }
                
                else
                {
                    if (contains)
                    {
                        checkedCity.RemoveAll(x => x.nCityID == grad.nCityID);
                    }
                }
            }

        }

        private void btnHideMap_Click(object sender, EventArgs e)
        {
            gMapControl.Hide();
        }

        private void btnZatvoriGraf_Click(object sender, EventArgs e)
        {
            ChartTemps.Hide();
        }
    }
}
