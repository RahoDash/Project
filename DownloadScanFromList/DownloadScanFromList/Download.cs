using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Download_scan
{
    class Download
    {
        public bool VerifieThePath(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            bool result = false;

            // Check that the remote file was found. The ContentType
            // check is performed since a request for a non-existent
            // image file might be redirected to a 404-page, which would
            // yield the StatusCode "OK", even though the image was not
            // found.
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {
                result = true;
            }
            response.Dispose();
            return result;
        }

        public void DownloadTheImage(string uri, string fileName)
        {
            Uri url = new Uri(uri);
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFileAsync(url, fileName);
                    client.Dispose();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
