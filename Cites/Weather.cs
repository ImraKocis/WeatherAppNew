using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cites
{
    public class Weather
    {
        public double tempertura { get; set; }//trenutna temp u kelvinima
        public double ciniSeKao { get; set; }
        public double minTemp { get; set; }
        public double maxTemp { get; set; }
        public double tlak { get; set; }//izrazno u milibarima
        public string vlaga { get; set; }//vlaga u %
        public string vremenskiParametar { get; set; }//tipa kisa snijeg sunce...
        public string opisVremena { get; set; }//puni opis vremena tipa lagana kisa
        public string pstotakOblacosti { get; set; }//broj koji ce bit u %
        public string brzinaVjetra { get; set; }//u m/s
        public string vidljiviost { get; set; }//vidlivost u metrima     
        public string datumPovlacenja { get; set; }
        public string iconId { get; set; }
    }
}
