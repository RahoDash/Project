using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace meteogramme
{
    class meteo
    {

        public string showMeteo()
        {
            string result = "";
            try
            {
                string attribute = "";
                using (XmlReader reader = XmlReader.Create("http://api.met.no/weatherapi/locationforecast/1.9/?lat=46.205;lon=6.109"))
                {
                    while (reader.Read())
                    {
                        switch (reader.Name)
                        {
                            case "temperature":
                                attribute = reader["value"];
                                if (attribute != null)
                                {
                                    result += "temperature: " + attribute;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
