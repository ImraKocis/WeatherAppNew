using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cites
{
    public class CityRepository
    {
        readonly String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public List<double> DajLonLat(int IdGrada)
        {
            var DobiveniGrad = CallRestMethod("https://api.openweathermap.org/data/2.5/weather?id=" + IdGrada + "&appid=ba2f8e3b8882d09a711631637eda47e5");
            JObject jsonObj = JObject.Parse(DobiveniGrad);
            JObject koordinate = JObject.Parse(jsonObj["coord"].ToString());

            double sLon = (double)koordinate["lon"];
            double sLat = (double)koordinate["lat"];
            List<double> lLanLot = new List<double>();
            lLanLot.Add(sLat);
            lLanLot.Add(sLon);
            
            return lLanLot;
        }
        
        public List<City> DohvatiGradoveDb() 
        {
            var lGradovi = new List<City>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM kocis_City";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lGradovi.Add(new City()
                        {
                            nCityID = (int)reader["CITY_ID"],
                            sCityName = (string)reader["CITY_NAME"],
                            sCountryTag = (string)reader["COUNTRY_TAG"]  
                        });
                    }
                }
            }
            return lGradovi;
        }
        public List<City> DohvatiOdabraneGradoveDb()
        {
            var lOdabraniGradovi = new List<City>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM kocis_OdabraniGradovi";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lOdabraniGradovi.Add(new City()
                        {
                            nCityID = (int)reader["IdGrada"],
                            sCityName = (string)reader["NazivGrada"],
                            sCountryTag = (string)reader["KraticaDrzave"]
                        });
                    }
                }
            }
            return lOdabraniGradovi;
        }

        public List<string> DohvatiTag() 
        {
            List<string> SviTagovi = new List<string>();
            var lSviGradovi = DohvatiGradoveDb();
            foreach (var cTag in lSviGradovi) 
            {
                SviTagovi.Add(cTag.sCountryTag);
            }
            SviTagovi = SviTagovi.Select(tag => tag).Distinct().ToList();
            SviTagovi = SviTagovi.OrderBy(tag => tag).ToList();
            return SviTagovi;
        }
        
        public void BrisanjeGradaDb(int IdGrada) 
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM [kocis_City] WHERE CITY_ID = " + IdGrada;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void BrisanjeOdabranogGrada(int IdGrada)
        {
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM [kocis_OdabraniGradovi] WHERE IdGrada = " + IdGrada;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        

        public void DodajOdabraneGradove(City oCity)
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand dbCommand = dbConnection.CreateCommand())
            {
                dbCommand.CommandText = $"INSERT INTO[kocis_OdabraniGradovi] (IdGrada, NazivGrada, KraticaDrzave) VALUES ('{oCity.nCityID}','{oCity.sCityName}','{oCity.sCountryTag}')";
                dbConnection.Open();
                using (DbDataReader oReader = dbCommand.ExecuteReader())
                { 
                    
                }
            }

        }

        public void ObrisiOdabraneGradoveDb()
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand dbCommand = dbConnection.CreateCommand())
            {
                dbCommand.CommandText = "DELETE FROM [kocis_OdabraniGradovi]";
                dbConnection.Open();
                using (DbDataReader oReader = dbCommand.ExecuteReader())
                {

                }
            }
        }
        public void UpdateCityDb(string IdGrada, string sNoviNazivGrada)
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection dbConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand dbCommand = dbConnection.CreateCommand())
            {
                dbCommand.CommandText = "UPDATE [kocis_City] SET CITY_NAME = '" + sNoviNazivGrada + "' WHERE CITY_ID = " + IdGrada;
                dbConnection.Open();
                using (DbDataReader oReader = dbCommand.ExecuteReader())
                {

                }
            }
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

