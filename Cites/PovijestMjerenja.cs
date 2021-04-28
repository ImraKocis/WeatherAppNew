using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cites
{
    public class PovijestMjerenja
    {
        public int nIdMjerenja { get; set; }
        public int nCityId { get; set; }
        public string sCityName { get; set; }
        public string sCityTag { get; set; }
        public double sTemp { get; set; }
        public double sFeelsLike { get; set; }
        public double sMinTemp { get; set; }
        public double sMaxTemp { get; set; }
        public double sPressure { get; set; }
        public string sHumidity { get; set; }
        public string sWeatherDisc { get; set; }
        public string sClouds { get; set; }
        public string sWind { get; set; }
        public string sViewDistance { get; set; }
        public string sDatum { get; set; }
    }
}
