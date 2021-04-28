using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cites;
using GMap.NET.MapProviders;

namespace VremenskaPrognozaMain
{

    public partial class MainForm : Form
    {
        private CityRepository _CityRepository = new CityRepository();
        private WeatherRepository _WeatherRepository = new WeatherRepository();
        private BindingSource _BindingSource = new BindingSource();
        
        public MainForm()
        {
            InitializeComponent();
            _BindingSource.DataSource = _CityRepository.DohvatiGradoveDb();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAqvKvAYfwV_krDEcNZmWBKAiKCnhFciGo";
            _WeatherRepository.ObrisiPrognozeIzDb();
            DataGridViewImageColumn buttonObrisi = new DataGridViewImageColumn();
            DataGridViewImageColumn btnOtvoriPrognozu = new DataGridViewImageColumn();
            DataGridViewImageColumn btnUpdate = new DataGridViewImageColumn();
            DataGridViewImageColumn btnDodajZaPrognozu = new DataGridViewImageColumn();
            buttonObrisi.Image = Image.FromFile ("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/delete_ico.png");
            buttonObrisi.Width = 20;
            buttonObrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnOtvoriPrognozu.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/Ico_for_table_16px.png");
            btnOtvoriPrognozu.Width = 20;
            btnOtvoriPrognozu.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnUpdate.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/icons8-update-file-16.png");
            btnUpdate.Width = 20;
            btnUpdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnDodajZaPrognozu.Image = Image.FromFile("E:/.NET/VremenskaPrognoza/VremenskaPrognoza/img/add_ico.png");
            btnDodajZaPrognozu.Width = 20;
            btnDodajZaPrognozu.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewGradovi.Columns.Add(btnOtvoriPrognozu);
            dataGridViewGradovi.Columns.Add(btnDodajZaPrognozu);
            dataGridViewGradovi.Columns.Add(btnUpdate);
            dataGridViewGradovi.Columns.Add(buttonObrisi);
            dataGridViewGradovi.Columns[3].HeaderText = "Prikaži prognozu";
            dataGridViewGradovi.Columns[4].HeaderText = "Dodaj u odabrane gradove";
            dataGridViewGradovi.Columns[5].HeaderText = "Ažuriraj";
            dataGridViewGradovi.Columns[6].HeaderText = "Obriši";
            dataGridViewGradovi.AutoGenerateColumns = false;
            dataGridViewGradovi.DataSource = _BindingSource;
            var FiltriraniTagovi = _CityRepository.DohvatiTag();
            comboBoxCountryTags.Items.Add("ALL");
            foreach (var cTag in FiltriraniTagovi)
            {              
                comboBoxCountryTags.Items.Add(cTag);
            }
            comboBoxCountryTags.DropDownHeight = comboBoxCountryTags.Font.Height * 8;
        }
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        static double GettingRidOfDecimal(double Broj)
        {
            return Math.Round(Broj);
        }
        private void dataGridViewGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridViewGradovi.Rows[e.RowIndex].Selected = true;
            
            if (dataGridViewGradovi.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                int IdGrada = Convert.ToInt32(dataGridViewGradovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormUpdate formUpdate = new FormUpdate(IdGrada, this);
                formUpdate.lblTrenutniNazivGrada.Text = dataGridViewGradovi.Rows[e.RowIndex].Cells[1].Value.ToString() + ", " + dataGridViewGradovi.Rows[e.RowIndex].Cells[2].Value.ToString();
                formUpdate.ShowDialog();
            }
            if (dataGridViewGradovi.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                
                int nIdGrada = Convert.ToInt32(dataGridViewGradovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                string sImeGrada = dataGridViewGradovi.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sDrzava = dataGridViewGradovi.Rows[e.RowIndex].Cells[2].Value.ToString();
                City oOdabraniGrad = new City {nCityID = nIdGrada, sCityName = sImeGrada, sCountryTag = sDrzava };
                var lVecOdabranihGradova = _CityRepository.DohvatiOdabraneGradoveDb();
                bool bVecPostoji = true;
                bool bNemaNista = true;
                foreach (var grad in lVecOdabranihGradova)
                {
                    bNemaNista = false;
                    if (grad.nCityID == nIdGrada)
                    {
                        const string warningMessage = "Grad koji ste odabrali već se nalazi u odabranim gradovima!";
                        const string warningCaption = "Upozorenje";
                        MessageBox.Show(warningMessage, warningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bVecPostoji = true;
                        break;
                    }
                    else
                    {
                        bVecPostoji = false;
                        bNemaNista = false;
                    }                     
                }
                if (bNemaNista)
                {
                    const string message = "Potvrda dodavanja grada za usporedbu\nZa nastavak odaberite Da, za izlazak Ne";
                    const string caption = "Dodavanje grada u odabrane gradove";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _CityRepository.DodajOdabraneGradove(oOdabraniGrad);
                    }
                }
                if (!bVecPostoji)
                {
                    const string message = "Potvrda dodavanja grada za usporedbu\nZa nastavak odaberite Da, za izlazak Ne";
                    const string caption = "Dodavanje grada u odabrane gradove";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _CityRepository.DodajOdabraneGradove(oOdabraniGrad);
                    }
                }
                
            }
            if(dataGridViewGradovi.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1) 
            {
                int IdGradaZaPorgnozu = Convert.ToInt32(dataGridViewGradovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                string sNazivGrada = dataGridViewGradovi.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sDrzava = dataGridViewGradovi.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormPrognoza formPrognoza = new FormPrognoza(IdGradaZaPorgnozu,sNazivGrada,sDrzava);
                var lPrognozaZaDane =  _WeatherRepository.PrognozeZaDane(IdGradaZaPorgnozu.ToString());
                var lPrognozaOdabranigGrada = _WeatherRepository.DajPrognozuZaDanas(IdGradaZaPorgnozu.ToString());
                string imgUrl;
                formPrognoza.lblForDate.Visible = false;
                foreach (var prognoza in lPrognozaOdabranigGrada)
                {
                    formPrognoza.nazivGradaLbl.Text = dataGridViewGradovi.Rows[e.RowIndex].Cells[1].Value.ToString() + ", " + dataGridViewGradovi.Rows[e.RowIndex].Cells[2].Value.ToString();
                    formPrognoza.glavnaTempLbl.Text = GettingRidOfDecimal(prognoza.tempertura) + " °C";
                    formPrognoza.opisVremenaLbl.Text = UppercaseFirst(prognoza.opisVremena);
                    formPrognoza.fealsLikeLbl.Text = GettingRidOfDecimal(prognoza.ciniSeKao) + " °C";
                    formPrognoza.minTempLbl.Text = GettingRidOfDecimal(lPrognozaZaDane[0].minTemp) + " °C";
                    formPrognoza.maxTempLbl.Text = GettingRidOfDecimal(lPrognozaZaDane[0].maxTemp) + " °C";
                    formPrognoza.pressLbl.Text = prognoza.tlak + " mb";
                    formPrognoza.humadityLbl.Text = prognoza.vlaga + " %";
                    var VidljivostUkm = Convert.ToInt32(prognoza.vidljiviost) / 1000;
                    formPrognoza.visibilityLbl.Text = VidljivostUkm.ToString() + " km";
                    imgUrl = "http://openweathermap.org/img/wn/" + prognoza.iconId + "@2x.png";
                    formPrognoza.picBoxForWeatherPic.Load(imgUrl);
                    formPrognoza.picBoxForWeatherPic.SizeMode = PictureBoxSizeMode.CenterImage;
                    Console.WriteLine(prognoza.vremenskiParametar);
                }
                //D-1
                formPrognoza.nazivDana1Lbl.Text = lPrognozaZaDane[0].samoNazivDana;
                formPrognoza.getDay1Lbl.Text = lPrognozaZaDane[0].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl1.Text = GettingRidOfDecimal(lPrognozaZaDane[0].maxTemp) + " °C";
                formPrognoza.minTempTablLbl1.Text = GettingRidOfDecimal(lPrognozaZaDane[0].minTemp) + " °C";
                formPrognoza.opisTablLbl1.Text = UppercaseFirst(lPrognozaZaDane[0].opisVremena);
                //D-2
                formPrognoza.nazivDana2Lbl.Text = lPrognozaZaDane[1].samoNazivDana;
                formPrognoza.getDay2Lbl.Text = lPrognozaZaDane[1].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl2.Text = GettingRidOfDecimal(lPrognozaZaDane[1].maxTemp) + " °C";
                formPrognoza.minTempTablLbl2.Text = GettingRidOfDecimal(lPrognozaZaDane[1].minTemp) + " °C";
                formPrognoza.opisTablLbl2.Text = UppercaseFirst(lPrognozaZaDane[1].opisVremena);
                //D-3
                formPrognoza.nazivDana3Lbl.Text = lPrognozaZaDane[2].samoNazivDana;
                formPrognoza.getDay3Lbl.Text = lPrognozaZaDane[2].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl3.Text = GettingRidOfDecimal(lPrognozaZaDane[2].maxTemp) + " °C";
                formPrognoza.minTempTablLbl3.Text = GettingRidOfDecimal(lPrognozaZaDane[2].minTemp) + " °C";
                formPrognoza.opisTablLbl3.Text = UppercaseFirst(lPrognozaZaDane[2].opisVremena);
                //D-4
                formPrognoza.nazivDana4Lbl.Text = lPrognozaZaDane[3].samoNazivDana;
                formPrognoza.getDay4Lbl.Text = lPrognozaZaDane[3].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl4.Text = GettingRidOfDecimal(lPrognozaZaDane[3].maxTemp) + " °C";
                formPrognoza.minTempTablLbl4.Text = GettingRidOfDecimal(lPrognozaZaDane[3].minTemp) + " °C";
                formPrognoza.opisTablLbl4.Text = UppercaseFirst(lPrognozaZaDane[3].opisVremena);
                //D-5
                formPrognoza.nazivDana5Lbl.Text = lPrognozaZaDane[4].samoNazivDana;
                formPrognoza.getDay5Lbl.Text = lPrognozaZaDane[4].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl5.Text = GettingRidOfDecimal(lPrognozaZaDane[4].maxTemp) + " °C";
                formPrognoza.minTempTablLbl5.Text = GettingRidOfDecimal(lPrognozaZaDane[4].minTemp) + " °C";
                formPrognoza.opisTablLbl5.Text = UppercaseFirst(lPrognozaZaDane[4].opisVremena);
                //D-6
                formPrognoza.nazivDana6Lbl.Text = lPrognozaZaDane[5].samoNazivDana;
                formPrognoza.getDay6Lbl.Text = lPrognozaZaDane[5].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl6.Text = GettingRidOfDecimal(lPrognozaZaDane[5].maxTemp) + " °C";
                formPrognoza.minTempTablLbl6.Text = GettingRidOfDecimal(lPrognozaZaDane[5].minTemp) + " °C";
                formPrognoza.opisTablLbl6.Text = UppercaseFirst(lPrognozaZaDane[5].opisVremena);
                //D-7
                formPrognoza.nazivDana7Lbl.Text = lPrognozaZaDane[6].samoNazivDana;
                formPrognoza.getDay7Lbl.Text = lPrognozaZaDane[6].samoDanDatum + ".";
                formPrognoza.maxTempTablLbl7.Text = GettingRidOfDecimal(lPrognozaZaDane[6].maxTemp) + " °C";
                formPrognoza.minTempTablLbl7.Text = GettingRidOfDecimal(lPrognozaZaDane[6].minTemp) + " °C";
                formPrognoza.opisTablLbl7.Text = UppercaseFirst(lPrognozaZaDane[7].opisVremena);
                formPrognoza.ShowDialog();

            }
            if (dataGridViewGradovi.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                int IdGrada = Convert.ToInt32(dataGridViewGradovi.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormDelete brisanjeForm = new FormDelete(IdGrada, this);
                brisanjeForm.lblBrisanjeGrada.Text = "Želite li obrisati " + dataGridViewGradovi.Rows[e.RowIndex].Cells[1].Value.ToString();
                brisanjeForm.ShowDialog();
            }
        }

        private void sortNameUpBtn_Click(object sender, EventArgs e)
        {
            List<City> SortedCities = new List<City>();
            SortedCities = _CityRepository.DohvatiGradoveDb();
            SortedCities = SortedCities.OrderBy(x => x.sCityName).ToList();
            if (!string.IsNullOrWhiteSpace(comboBoxCountryTags.Text) && comboBoxCountryTags.Text != "ALL")
            {
                SortedCities = SortedCities.Where(x => x.sCountryTag == comboBoxCountryTags.Text).ToList();
            }
            _BindingSource.DataSource = SortedCities;
            dataGridViewGradovi.DataSource = _BindingSource;
        }

        private void textBoxGradovi_TextChanged(object sender, EventArgs e)
        {
            string enteredText = textBoxGradovi.Text;
            var gradovi = _CityRepository.DohvatiGradoveDb();
            List<City> filteredCountries = new List<City>();
            filteredCountries = gradovi.Where(grad => grad.sCityName.ToLower().Contains(enteredText.ToLower())).ToList();
            if (!string.IsNullOrWhiteSpace(comboBoxCountryTags.Text) && comboBoxCountryTags.Text != "ALL")
            {
                filteredCountries = gradovi.Where(grad => grad.sCityName.ToLower().Contains(enteredText.ToLower()) && grad.sCountryTag == comboBoxCountryTags.Text).ToList();
            }
            _BindingSource.DataSource = filteredCountries;
            dataGridViewGradovi.DataSource = _BindingSource;
        }

        private void sortNameDownBtn_Click(object sender, EventArgs e)
        {
            List<City> SortedCities = new List<City>();
            SortedCities = _CityRepository.DohvatiGradoveDb();
            SortedCities = SortedCities.OrderByDescending(x => x.sCityName).ToList();
            if (!string.IsNullOrWhiteSpace(comboBoxCountryTags.Text) && comboBoxCountryTags.Text != "ALL")
            {
                SortedCities = SortedCities.Where(x => x.sCountryTag == comboBoxCountryTags.Text).ToList();
            }
            _BindingSource.DataSource = SortedCities;
            dataGridViewGradovi.DataSource = _BindingSource;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string CountryTags = comboBoxCountryTags.Text;
            SortiranjePoDrzavama(CountryTags);
        }

        public void SortiranjePoDrzavama(string cTag) 
        {
            var lSviGradovi = _CityRepository.DohvatiGradoveDb();
            List<City> PronadeniGradovi = new List<City>();
            if (cTag != "" && cTag != "ALL")
            {
                foreach (var grad in lSviGradovi)
                {
                    if (grad.sCountryTag == cTag)
                    {
                        PronadeniGradovi.Add(grad);
                    }
                }
                _BindingSource.DataSource = PronadeniGradovi;
                dataGridViewGradovi.DataSource = _BindingSource;
            }
            else 
            {
                _BindingSource.DataSource = lSviGradovi;
                dataGridViewGradovi.DataSource = _BindingSource;
            }
        }

        private void OdabraniGradoviBtn_Click(object sender, EventArgs e)
        {
            FormPrognozeOdabraniGradovi formPrognozeOdabraniGradovi = new FormPrognozeOdabraniGradovi();
            formPrognozeOdabraniGradovi.ShowDialog();
        }

        private void btnOpenFormHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            formHistory.ShowDialog();
        }
    }
}
