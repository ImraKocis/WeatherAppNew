using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cites
{
    public class WeatherRepository
    {
        readonly String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        private CityRepository cityRepository = new CityRepository();
        public List<WeatherMin> PrognozeZaDane(string IdGrada)
        {
            var DobiveniGrad = CallRestMethod("https://api.openweathermap.org/data/2.5/weather?id=" + IdGrada + "&appid=ba2f8e3b8882d09a711631637eda47e5");
            JObject jsonObj = JObject.Parse(DobiveniGrad);
            JObject koordinate = JObject.Parse(jsonObj["coord"].ToString());

            string sLon = (string)koordinate["lon"];
            string sLat = (string)koordinate["lat"];

            List<string> DatumiNazivi = new List<string>();
            List<int> DatumDani = new List<int>();
            string Naziv0 = DateTime.Now.ToString("ddd");
            DatumiNazivi.Add(Naziv0);
            int Datum0 = (int)DateTime.Now.Day;
            DatumDani.Add(Datum0);
            var Datum1 = Convert.ToInt32(DateTime.Today.AddDays(1).Day);
            DatumDani.Add(Datum1);
            var Naziv1 = DateTime.Today.AddDays(1).ToString("ddd");
            DatumiNazivi.Add(Naziv1);
            int Datum2 = Convert.ToInt32(DateTime.Today.AddDays(2).Day);
            DatumDani.Add(Datum2);
            var Naziv2 = DateTime.Today.AddDays(2).ToString("ddd");
            DatumiNazivi.Add(Naziv2);
            int Datum3 = Convert.ToInt32(DateTime.Today.AddDays(3).Day);
            DatumDani.Add(Datum3);
            var Naziv3 = DateTime.Today.AddDays(3).ToString("ddd");
            DatumiNazivi.Add(Naziv3);
            int Datum4 = Convert.ToInt32(DateTime.Today.AddDays(4).Day);
            DatumDani.Add(Datum4);
            var Naziv4 = DateTime.Today.AddDays(4).ToString("ddd");
            DatumiNazivi.Add(Naziv4);
            int Datum5 = Convert.ToInt32(DateTime.Today.AddDays(5).Day);
            DatumDani.Add(Datum5);
            var Naziv5 = DateTime.Today.AddDays(5).ToString("ddd");
            DatumiNazivi.Add(Naziv5);
            int Datum6 = Convert.ToInt32(DateTime.Today.AddDays(6).Day);
            DatumDani.Add(Datum6);
            var Naziv6 = DateTime.Today.AddDays(6).ToString("ddd");
            DatumiNazivi.Add(Naziv6);
            int Datum7 = Convert.ToInt32(DateTime.Today.AddDays(7).Day);
            DatumDani.Add(Datum7);
            var Naziv7 = DateTime.Today.AddDays(7).ToString("ddd");
            DatumiNazivi.Add(Naziv7);

            var DobiveniGradSPrognozama = CallRestMethod("https://api.openweathermap.org/data/2.5/onecall?lat=" + sLat + "&lon=" + sLon + "&units=metric&exclude=current,minutely,hourly,alerts&appid=ba2f8e3b8882d09a711631637eda47e5&lang=hr");

            JObject jsonObj2 = JObject.Parse(DobiveniGradSPrognozama);
            var Prognoze = jsonObj2["daily"].ToList();
            List<WeatherMin> PrognozeMin = new List<WeatherMin>();
            for (int i = 0; i < Prognoze.Count; i++)
            {
                JObject temperatura = JObject.Parse(Prognoze[i]["temp"].ToString());
                double dMinTemp;
                double dMaxTemp;
                string sOpisVremena = "";
                string sNazivDana;
                string sDan;
                dMinTemp = (double)temperatura["min"];
                dMaxTemp = (double)temperatura["max"];

                var Vrijeme = Prognoze[i]["weather"].ToList();
                for (int x = 0; x < Vrijeme.Count; x++)
                {
                    sOpisVremena = (string)Vrijeme[x]["description"];
                }

                sNazivDana = DatumiNazivi[i];
                sDan = DatumDani[i].ToString();

                PrognozeMin.Add(new WeatherMin
                {
                    minTemp = dMinTemp,
                    maxTemp = dMaxTemp,
                    opisVremena = sOpisVremena,
                    samoNazivDana = sNazivDana.ToUpper(),
                    samoDanDatum = sDan
                });
            }
            return PrognozeMin;

        }

        public List<float> TemperatureOdabranogGrada(int IdGrada, int BrojDana, string Odabir)
        {
            var DobiveniGrad = CallRestMethod("https://api.openweathermap.org/data/2.5/weather?id=" + IdGrada + "&appid=ba2f8e3b8882d09a711631637eda47e5");
            JObject jsonObj = JObject.Parse(DobiveniGrad);
            JObject koordinate = JObject.Parse(jsonObj["coord"].ToString());

            string sLon = (string)koordinate["lon"];
            string sLat = (string)koordinate["lat"];

            var DobiveniGradSPrognozama = CallRestMethod("https://api.openweathermap.org/data/2.5/onecall?lat=" + sLat + "&lon=" + sLon + "&units=metric&exclude=current,minutely,hourly,alerts&appid=ba2f8e3b8882d09a711631637eda47e5&lang=hr");
            List<float> lTemp = new List<float>();
            List<float> lMintemp = new List<float>();
            List<float> lMaxTemp = new List<float>();
            List<float> lFeelsLike = new List<float>();
            List<float> lPressure = new List<float>();
            List<float> lHumidity = new List<float>();
            List<float> lClouds = new List<float>();
            List<float> lWindSpead = new List<float>();
            JObject jsonObj2 = JObject.Parse(DobiveniGradSPrognozama);
            var Prognoze = jsonObj2["daily"].ToList();
            for (int i = 0; i < BrojDana + 1; i++)
            {
                JObject temperatura = JObject.Parse(Prognoze[i]["temp"].ToString());
                JObject cinisekao = JObject.Parse(Prognoze[i]["feels_like"].ToString());
                float sTemp = (float)temperatura["day"];
                float sMinTemp = (float)temperatura["min"];
                float sMaxTemp = (float)temperatura["max"];
                float sFeelsLike = (float)cinisekao["day"];
                float sPressure = (float)Prognoze[i]["pressure"];
                float sHumidity = (float)Prognoze[i]["humidity"];
                float sClouds = (float)Prognoze[i]["clouds"];
                float sWindSpeed = (float)Prognoze[i]["wind_speed"];
                lTemp.Add(sTemp);
                lMintemp.Add(sMinTemp);
                lMaxTemp.Add(sMaxTemp);
                lFeelsLike.Add(sFeelsLike);
                lPressure.Add(sPressure);
                lHumidity.Add(sHumidity);
                lClouds.Add(sClouds);
                lWindSpead.Add(sWindSpeed);
            }
            if (Odabir == "Dnevna temperatura")
            {
                return lTemp;
            }
            else if (Odabir == "Maksimalna temperatura")
            {
                return lMaxTemp;
            }
            else if (Odabir == "Minimalna temperatura")
            {
                return lMintemp;
            }
            else if (Odabir == "Temperatura subjektivnog dojma")
            {
                return lFeelsLike;
            }
            else if (Odabir == "Tlak zraka")
            {
                return lPressure;
            }
            else if (Odabir == "Vlaga zraka")
            {
                return lHumidity;
            }
            else if (Odabir == "Postotak oblačnosti")
            {
                return lClouds;
            }
            else if (Odabir == "Brzina vjetra")
            {
                return lWindSpead;
            }
            else return lTemp;
        }

        public List<Weather> DajPrognozuZaDanas(string IdGrada)
        {
            var DobiveniGrad = CallRestMethod("https://api.openweathermap.org/data/2.5/weather?id=" + IdGrada + "&units=metric&appid=ba2f8e3b8882d09a711631637eda47e5&lang=hr");
            JObject jsonObj = JObject.Parse(DobiveniGrad);
            string sVisibility = jsonObj["visibility"].ToString();
            var Prognoza = jsonObj["weather"].ToList();
            JObject Temperature = JObject.Parse(jsonObj["main"].ToString());
            JObject Vjetar = JObject.Parse(jsonObj["wind"].ToString());
            JObject Oblaci = JObject.Parse(jsonObj["clouds"].ToString());
            double dTemp = double.Parse((string)Temperature["temp"], CultureInfo.InvariantCulture);
            double dFeels = double.Parse((string)Temperature["feels_like"], CultureInfo.InvariantCulture);
            double dTempMin = double.Parse((string)Temperature["temp_min"], CultureInfo.InvariantCulture);
            double dTempMax = double.Parse((string)Temperature["temp_max"], CultureInfo.InvariantCulture);
            double dPressure = double.Parse((string)Temperature["pressure"], CultureInfo.InvariantCulture);
            string sHumadity = (string)Temperature["humidity"];
            string sWind = (string)Vjetar["speed"];
            string sOblaci = (string)Oblaci["all"];
            string sAzurirano = DateTime.Today.ToString("dddd, MMM, yyyy");
            string sMain = "";
            string sDescriptiopn = "";
            string sIconId = "";
            for (int i = 0; i < Prognoza.Count; i++)
            {
                sMain = (string)Prognoza[i]["main"];
                sDescriptiopn = (string)Prognoza[i]["description"];
                sIconId = (string)Prognoza[i]["icon"];
            }

            List<Weather> weathers = new List<Weather>();
            weathers.Add(new Weather
            {
                tempertura = dTemp,
                ciniSeKao = dFeels,
                minTemp = dTempMin,
                maxTemp = dTempMax,
                tlak = dPressure,
                vlaga = sHumadity,
                vremenskiParametar = sMain,
                opisVremena = sDescriptiopn,
                pstotakOblacosti = sOblaci,
                brzinaVjetra = sWind,
                vidljiviost = sVisibility,
                datumPovlacenja = sAzurirano,
                iconId = sIconId
            });
            return weathers;
        }

        public List<CityAndWeather> DohvatiPrognozeOdabranihGradova()
        {
            DateTime dataTime = DateTime.Now;
            var lOdabranigradovi = cityRepository.DohvatiOdabraneGradoveDb();
            List<CityAndWeather> lPrognozaSvihGradova = new List<CityAndWeather>();
            foreach (var odabraniGrad in lOdabranigradovi)
            {
                var lPrognozaJednogGrada = DajPrognozuZaDanas(odabraniGrad.nCityID.ToString());
                lPrognozaSvihGradova.Add(new CityAndWeather
                {
                    nCityId = odabraniGrad.nCityID,
                    sCityName = odabraniGrad.sCityName,
                    sCityTag = odabraniGrad.sCountryTag,
                    sTemp = lPrognozaJednogGrada[0].tempertura,
                    sFeelsLike = lPrognozaJednogGrada[0].ciniSeKao,
                    sMinTemp = lPrognozaJednogGrada[0].minTemp,
                    sMaxTemp = lPrognozaJednogGrada[0].maxTemp,
                    sPressure = lPrognozaJednogGrada[0].tlak,
                    sHumidity = lPrognozaJednogGrada[0].vlaga,
                    sWeatherDisc = lPrognozaJednogGrada[0].opisVremena,
                    sClouds = lPrognozaJednogGrada[0].pstotakOblacosti,
                    sWind = lPrognozaJednogGrada[0].brzinaVjetra,
                    sViewDistance = lPrognozaJednogGrada[0].vidljiviost,
                    sDatum = dataTime.ToString("dd.MMM.yyyy.")
                });
            }
            return lPrognozaSvihGradova;
        }
        public List<PovijestMjerenja> DohvatiPovijetsMjerenja()
        {
            List<PovijestMjerenja> lSvaMjerenja = new List<PovijestMjerenja>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM kocis_PovijestMjerenja";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        lSvaMjerenja.Add(new PovijestMjerenja()
                        {
                            nIdMjerenja = (int)reader["IdMjerenja"],
                            nCityId = (int)reader["CityId"],
                            sCityName = (string)reader["CityName"],
                            sCityTag = (string)reader["Tag"],
                            sTemp = double.Parse((string)reader["Temp"]/*, CultureInfo.InvariantCulture*/),
                            sFeelsLike = double.Parse((string)reader["FeelsLike"]/*, CultureInfo.InvariantCulture*/),
                            sMinTemp = double.Parse((string)reader["MinTemp"]/*, CultureInfo.InvariantCulture*/),
                            sMaxTemp = double.Parse((string)reader["MaxTemp"]/*, CultureInfo.InvariantCulture*/),
                            sPressure = double.Parse((string)reader["Tlak"]/*, CultureInfo.InvariantCulture*/),
                            sHumidity = (string)reader["Vlaga"],
                            sWeatherDisc = (string)reader["OpisVremena"],
                            sClouds = (string)reader["Oblacnost"],
                            sWind = (string)reader["Vjetar"],
                            sViewDistance = (string)reader["Vidljivost"],
                            sDatum = (string)reader["Datum"]
                        });
                    }
                }
            }
            return lSvaMjerenja;
        }
        
        public void DodajOdabranePrognoze()
        {
            var lPrognoza = DohvatiPrognozeOdabranihGradova();
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            {
                dbConnection.Open();
                foreach (var oCityAndWeather in lPrognoza)
                {
                    using (DbCommand dbCommand = dbConnection.CreateCommand())
                    {
                        dbCommand.CommandText = $"INSERT INTO[kocis_PrognozaGradova] (CityId, CityName, Tag, Temp, FealsLike, MinTemp, MaxTemp, Tlak, Vlaga, OpisVremena, Oblacnost, Vjetar, Vidljivost, Datum) VALUES ('{oCityAndWeather.nCityId}','{oCityAndWeather.sCityName}','{oCityAndWeather.sCityTag}','{oCityAndWeather.sTemp}','{oCityAndWeather.sFeelsLike}','{oCityAndWeather.sMinTemp}','{oCityAndWeather.sMaxTemp}','{oCityAndWeather.sPressure}','{oCityAndWeather.sHumidity}','{oCityAndWeather.sWeatherDisc}','{oCityAndWeather.sClouds}','{oCityAndWeather.sWind}','{oCityAndWeather.sViewDistance}','{oCityAndWeather.sDatum}')";

                        using (DbDataReader oReader = dbCommand.ExecuteReader())
                        {

                        }
                    }
                }
            }
        }

        public void DodajPrognozePovijest()
        {
            var lPrognoza = DohvatiPrognozeOdabranihGradova();
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            {
                dbConnection.Open();
                foreach (var oCityAndWeather in lPrognoza)
                {
                    using (DbCommand dbCommand = dbConnection.CreateCommand())
                    {
                        dbCommand.CommandText = $"INSERT INTO[kocis_PovijestMjerenja] (CityId, CityName, Tag, Temp, FeelsLike, MinTemp, MaxTemp, Tlak, Vlaga, OpisVremena, Oblacnost, Vjetar, Vidljivost, Datum) VALUES ('{oCityAndWeather.nCityId}','{oCityAndWeather.sCityName}','{oCityAndWeather.sCityTag}','{oCityAndWeather.sTemp}','{oCityAndWeather.sFeelsLike}','{oCityAndWeather.sMinTemp}','{oCityAndWeather.sMaxTemp}','{oCityAndWeather.sPressure}','{oCityAndWeather.sHumidity}','{oCityAndWeather.sWeatherDisc}','{oCityAndWeather.sClouds}','{oCityAndWeather.sWind}','{oCityAndWeather.sViewDistance}','{oCityAndWeather.sDatum}')";

                        using (DbDataReader oReader = dbCommand.ExecuteReader())
                        {

                        }
                    }
                }
            }
        }

        public void ObrisiPrognozeIzDb()
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand dbCommand = dbConnection.CreateCommand())
            {
                dbCommand.CommandText = "DELETE FROM [kocis_PrognozaGradova]";
                dbConnection.Open();
                using (DbDataReader oReader = dbCommand.ExecuteReader())
                {

                }
            }
        }

        public void ObrisiPovijestDb(int IdMjerenja)
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand dbCommand = dbConnection.CreateCommand())
            {
                dbCommand.CommandText = "DELETE FROM [kocis_PovijestMjerenja] WHERE IdMjerenja = " + IdMjerenja;
                dbConnection.Open();
                using (DbDataReader oReader = dbCommand.ExecuteReader())
                {

                }
            }
        }
        public List<string> DohvatiGradovePovijest()
        {
            List<string> SviGradoviPovijest = new List<string>();
            var lSvePorognozePovijest = DohvatiPovijetsMjerenja();
            foreach (var mjerenje in lSvePorognozePovijest)
            {
                SviGradoviPovijest.Add(mjerenje.sCityName);
            }
            SviGradoviPovijest = SviGradoviPovijest.Select(naziv => naziv).Distinct().ToList();
            SviGradoviPovijest = SviGradoviPovijest.OrderBy(naziv => naziv).ToList();
            return SviGradoviPovijest;
        }
        private string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
    }
}
