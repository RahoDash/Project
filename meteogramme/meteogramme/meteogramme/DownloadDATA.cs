using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace meteogramme
{
    internal class DownloadDATA
    {
        /// <summary>
        /// Declaration of fields
        /// </summary>
        private string _latitude;
        private string _longitude;
        /// <summary>
        /// This will be the url to access the data we need.
        /// </summary>
        private const string DEFAULT_URL = "http://api.met.no/weatherapi/locationforecast/1.9/?";

        Temperature temperature;
        Precipitation precipitation;

        /// <summary>
        /// Encapsulation of fields
        /// </summary>
        public string Latitude { get => _latitude; set => _latitude = value; }
        public string Longitude { get => _longitude; set => _longitude = value; }
        public string Url { get => DEFAULT_URL + "lat=" + Latitude + ";lon=" + Longitude; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="lat">This will be the latitude of the location in string</param>
        /// <param name="lon">This will be the longitude of the location in string</param>
        public DownloadDATA(string lat, string lon)
        {
            Latitude = lat;
            Longitude = lon;
            temperature = new Temperature();
            precipitation = new Precipitation();
            //throw new System.NotImplementedException();
            Downlaod();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Downlaod()
        {
            if (CanRequest(Url))
            {
                try
                {
                    //string attribute = "";           
                    using (XmlReader reader = XmlReader.Create(Url))
                    {
                        while (reader.Read())
                        {
                            switch (reader.Name)
                            {
                                case "temperature":
                                    reader.MoveToAttribute("value");
                                    temperature.Temp.Add(reader.Value);
                                    break;
                                case "minTemperature":
                                    reader.MoveToAttribute("value");
                                    temperature.TempMin.Add(reader.Value);
                                    break;
                                case "maxTemperature":
                                    reader.MoveToAttribute("value");
                                    temperature.TempMax.Add(reader.Value);
                                    break;
                                case "precipitation":
                                    //reader.MoveToAttribute("value");
                                    
                                    //reader.
                                    //reader.MoveToAttribute("minvalue");
                                    //precipitation.ValueMin.Add(reader.Value);
                                    //reader.MoveToAttribute("maxvalue");
                                    //precipitation.ValueMax.Add(reader.Value);

                                    while (reader.MoveToNextAttribute())
                                    {
                                        switch (reader.Name)
                                        {
                                            case "value":
                                                precipitation.Value.Add(reader.Value);
                                                break;
                                            case "minvalue":
                                                precipitation.ValueMin.Add(reader.Value);
                                                break;
                                            case "maxvalue":
                                                precipitation.ValueMax.Add(reader.Value);
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                case "symbol":
                                    reader.MoveToAttribute("number");
                                    precipitation.Id.Add(reader.Value);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private bool CanRequest(string url)
        {
            bool result = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                result = false;
                return result;
            }

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK))
            {
                result = true;
            }
            response.Dispose();
            return result;
        }
    }
}