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

namespace VremenskaPrognozaMain
{
    public partial class FormPrognoza : Form
    {
        private WeatherRepository weatherRepository = new WeatherRepository();
        private int IdGrada;
        private string DohvaceniNazivGrada;
        private string DohvaceniTagDrzave;
        public FormPrognoza(int IdGradaZaPrognozu,string NazivGrada,string TagDrzave)
        {
            IdGrada = IdGradaZaPrognozu;
            DohvaceniNazivGrada = NazivGrada;
            DohvaceniTagDrzave = TagDrzave;
            InitializeComponent();
        }

        private void FormPrognoza_Load(object sender, EventArgs e)
        {
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnReload_Click(object sender, EventArgs e)
        {
            var lPrognozaZaDane = weatherRepository.PrognozeZaDane(IdGrada.ToString());
            var lPrognozaOdabranigGrada = weatherRepository.DajPrognozuZaDanas(IdGrada.ToString());
            DateTime danas = DateTime.Now;
            var Azurirano = danas.ToString("dd.MM.yyyy. HH:m:s");
            string imgUrl;
            foreach (var prognoza in lPrognozaOdabranigGrada)
            {
                nazivGradaLbl.Text = DohvaceniNazivGrada + ", " + DohvaceniTagDrzave;
                glavnaTempLbl.Text = GettingRidOfDecimal(prognoza.tempertura) + " °C";
                opisVremenaLbl.Text = UppercaseFirst(prognoza.opisVremena);
                fealsLikeLbl.Text = GettingRidOfDecimal(prognoza.ciniSeKao) + " °C";
                minTempLbl.Text = GettingRidOfDecimal(lPrognozaZaDane[0].minTemp) + " °C";
                maxTempLbl.Text = GettingRidOfDecimal(lPrognozaZaDane[0].maxTemp) + " °C";
                pressLbl.Text = prognoza.tlak + " mb";
                humadityLbl.Text = prognoza.vlaga + " %";
                var VidljivostUkm = Convert.ToInt32(prognoza.vidljiviost) / 1000;
                visibilityLbl.Text = VidljivostUkm.ToString() + " km";
                imgUrl = "http://openweathermap.org/img/wn/" + prognoza.iconId + "@2x.png";
                picBoxForWeatherPic.Load(imgUrl);
                picBoxForWeatherPic.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            lblForDate.Text = "Ažurirano: "+Azurirano;
            lblForDate.Visible = true;
            nazivDana1Lbl.Text = lPrognozaZaDane[0].samoNazivDana;
            getDay1Lbl.Text = lPrognozaZaDane[0].samoDanDatum + ".";
            maxTempTablLbl1.Text = GettingRidOfDecimal(lPrognozaZaDane[0].maxTemp) + " °C";
            minTempTablLbl1.Text = GettingRidOfDecimal(lPrognozaZaDane[0].minTemp) + " °C";
            opisTablLbl1.Text = UppercaseFirst(lPrognozaZaDane[0].opisVremena);
            //D-2
            nazivDana2Lbl.Text = lPrognozaZaDane[1].samoNazivDana;
            getDay2Lbl.Text = lPrognozaZaDane[1].samoDanDatum + ".";
            maxTempTablLbl2.Text = GettingRidOfDecimal(lPrognozaZaDane[1].maxTemp) + " °C";
            minTempTablLbl2.Text = GettingRidOfDecimal(lPrognozaZaDane[1].minTemp) + " °C";
            opisTablLbl2.Text = UppercaseFirst(lPrognozaZaDane[1].opisVremena);
            //D-3
            nazivDana3Lbl.Text = lPrognozaZaDane[2].samoNazivDana;
            getDay3Lbl.Text = lPrognozaZaDane[2].samoDanDatum + ".";
            maxTempTablLbl3.Text = GettingRidOfDecimal(lPrognozaZaDane[2].maxTemp) + " °C";
            minTempTablLbl3.Text = GettingRidOfDecimal(lPrognozaZaDane[2].minTemp) + " °C";
            opisTablLbl3.Text = UppercaseFirst(lPrognozaZaDane[2].opisVremena);
            //D-4
            nazivDana4Lbl.Text = lPrognozaZaDane[3].samoNazivDana;
            getDay4Lbl.Text = lPrognozaZaDane[3].samoDanDatum + ".";
            maxTempTablLbl4.Text = GettingRidOfDecimal(lPrognozaZaDane[3].maxTemp) + " °C";
            minTempTablLbl4.Text = GettingRidOfDecimal(lPrognozaZaDane[3].minTemp) + " °C";
            opisTablLbl4.Text = UppercaseFirst(lPrognozaZaDane[3].opisVremena);
            //D-5
            nazivDana5Lbl.Text = lPrognozaZaDane[4].samoNazivDana;
            getDay5Lbl.Text = lPrognozaZaDane[4].samoDanDatum + ".";
            maxTempTablLbl5.Text = GettingRidOfDecimal(lPrognozaZaDane[4].maxTemp) + " °C";
            minTempTablLbl5.Text = GettingRidOfDecimal(lPrognozaZaDane[4].minTemp) + " °C";
            opisTablLbl5.Text = UppercaseFirst(lPrognozaZaDane[4].opisVremena);
            //D-6
            nazivDana6Lbl.Text = lPrognozaZaDane[5].samoNazivDana;
            getDay6Lbl.Text = lPrognozaZaDane[5].samoDanDatum + ".";
            maxTempTablLbl6.Text = GettingRidOfDecimal(lPrognozaZaDane[5].maxTemp) + " °C";
            minTempTablLbl6.Text = GettingRidOfDecimal(lPrognozaZaDane[5].minTemp) + " °C";
            opisTablLbl6.Text = UppercaseFirst(lPrognozaZaDane[5].opisVremena);
            //D-7
            nazivDana7Lbl.Text = lPrognozaZaDane[6].samoNazivDana;
            getDay7Lbl.Text = lPrognozaZaDane[6].samoDanDatum + ".";
            maxTempTablLbl7.Text = GettingRidOfDecimal(lPrognozaZaDane[6].maxTemp) + " °C";
            minTempTablLbl7.Text = GettingRidOfDecimal(lPrognozaZaDane[6].minTemp) + " °C";
            opisTablLbl7.Text = UppercaseFirst(lPrognozaZaDane[7].opisVremena);

        }
    }
}
