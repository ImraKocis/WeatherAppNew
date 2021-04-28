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
    public partial class FormHistory : Form
    {
        private CityRepository cityRepository = new CityRepository();
        private WeatherRepository weatherRepository = new WeatherRepository();
        private BindingSource BindingSource = new BindingSource();
        public FormHistory()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            GMapHistory.Hide();
            BindingSource.DataSource = weatherRepository.DohvatiPovijetsMjerenja();
            dataGridViewPovijestMjerenja.DataSource = BindingSource;
            
            DataGridViewImageColumn btnMap = new DataGridViewImageColumn();
            btnMap.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/World_map.png");
            btnMap.Width = 20;
            btnMap.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewPovijestMjerenja.Columns.Add(btnMap);
            dataGridViewPovijestMjerenja.Columns[15].HeaderText = "Otvori u karti";
            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/delete_ico.png");
            btnDelete.Width = 20;
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewPovijestMjerenja.Columns.Add(btnDelete);
            dataGridViewPovijestMjerenja.Columns[16].HeaderText = "Ukloni";
            dataGridViewPovijestMjerenja.AutoGenerateColumns = false;

            
        }

        private void dataGridViewPovijestMjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridViewPovijestMjerenja.Rows[e.RowIndex].Selected = true;

            if (dataGridViewPovijestMjerenja.CurrentCell.ColumnIndex.Equals(15) && e.RowIndex != -1)
            {
                double lat = 0, lon = 0;
                int IdGrada = Convert.ToInt32(dataGridViewPovijestMjerenja.Rows[e.RowIndex].Cells[1].Value.ToString());
                var lLonAndLat = cityRepository.DajLonLat(IdGrada);
                GMapHistory.MapProvider = GMapProviders.GoogleMap;

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
                GMapHistory.Position = new PointLatLng(lat, lon);
                GMapHistory.MinZoom = 0;
                GMapHistory.MaxZoom = 18;
                GMapHistory.Zoom = 5;

                PointLatLng pointLatLng = new PointLatLng(lat, lon);
                GMapMarker gMapMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.red_small);

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(gMapMarker);
                GMapHistory.Overlays.Add(markers);

                GMapHistory.Show();
            }

            if (dataGridViewPovijestMjerenja.CurrentCell.ColumnIndex.Equals(16) && e.RowIndex != -1)
            {
                int IdMjerenja = Convert.ToInt32(dataGridViewPovijestMjerenja.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormObrisiPovijest brisanjeForm = new FormObrisiPovijest(IdMjerenja, this);
                brisanjeForm.labelBrisanjePovijest.Text = "Želite li obrisati " + dataGridViewPovijestMjerenja.Rows[e.RowIndex].Cells[2].Value.ToString() + " iz povjesti mjerenja?";
                brisanjeForm.lblIdMjerenja.Text = "Id mjerenja:" + dataGridViewPovijestMjerenja.Rows[e.RowIndex].Cells[0].Value.ToString();
                brisanjeForm.ShowDialog();
            }
        }

        private void textBoxCitySearch_TextChanged(object sender, EventArgs e)
        {
            string enteredText = textBoxCitySearch.Text;
            var Grad = weatherRepository.DohvatiPovijetsMjerenja();
            List<PovijestMjerenja> filteredCountriesByName = new List<PovijestMjerenja>();
            filteredCountriesByName = Grad.Where(grad => grad.sCityName.ToLower().Contains(enteredText.ToLower())).ToList();
            BindingSource.DataSource = filteredCountriesByName;
            dataGridViewPovijestMjerenja.DataSource = BindingSource;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"E:/.NET/VremenskaPrognoza/VremenskaPrognoza/Print/PovijestMjerenja.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter file = new StreamWriter(fs))
            {
                int location = 1;
                file.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (DataGridViewColumn column in dataGridViewPovijestMjerenja.Columns)
                {
                    switch (location)
                    {
                        case 1:
                            break;
                        case 2:
                            file.Write("| {0, -25} |", column.HeaderText);
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
                foreach (DataGridViewRow row in dataGridViewPovijestMjerenja.Rows)
                {
                    location = 1;
                    foreach (DataGridViewColumn column in dataGridViewPovijestMjerenja.Columns)
                    {
                        switch (location)
                        {
                            case 1:
                                break;
                            case 2:
                                file.Write("| {0, -25} |", row.Cells[column.Index].Value.ToString());
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
                    if (row.Index == dataGridViewPovijestMjerenja.Rows.Count - 1)
                        file.WriteLine("\n---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    else
                        file.WriteLine("\n|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|");
                }
                const string message = "Prognoza/e su spremne za ispis.";
                const string caption = "Uspješno dodano";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
