using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNRParser.Service
{
    public class SQLServerDB
    {
        public static string ConvertCityCode(string input)
        {
            using(var db = new PNRParserEntities())
            {
                var city = db.Airport.FirstOrDefault(r => r.CityCode == input);

                if (city != null)
                {
                    return city.CityDescription;
                }
                else
                    return "";
            }
        }

        public static string ConvertAirlineCode(string input)
        {
            using (var db = new TravComEntities())
            {
                var airline = db.Airlines.FirstOrDefault(r => r.AirlineCode == input);

                if (airline != null)
                {
                    return airline.AirlineName;
                }
                else
                    return "";
            }
        }
    }
}
