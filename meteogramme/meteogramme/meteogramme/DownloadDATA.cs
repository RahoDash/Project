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
        private string _url;
        /// <summary>
        /// This will be the url to access the data we need.
        /// </summary>
        private const string DEFAULT_URL = "http://api.met.no/weatherapi/locationforecast/1.9/?";

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
            //throw new System.NotImplementedException();

            if (CanRequest(Url))
            {
                Downlaod();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public XmlReader Downlaod()
        {
            try
            {
                //string attribute = "";
                using (XmlReader reader = XmlReader.Create(Url))
                {
                    while (reader.Read())
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine("Name = {0}; Value = {1} ", reader.Name, reader.Value);
                        }
                    }
                    return reader;
                }
            }
            catch (Exception)
            {
                throw;
            }
            throw new System.NotImplementedException();
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
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect))
            {
                result = true;
            }
            response.Dispose();
            return result;
        }
    }
}