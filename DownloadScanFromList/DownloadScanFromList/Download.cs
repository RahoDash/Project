using System;
<<<<<<< HEAD
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
=======
using System.Net;
>>>>>>> master
=======
using System.Net;
>>>>>>> master
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

<<<<<<< HEAD
<<<<<<< HEAD
        public void DownloadTheImage(string uri, string fileName)
=======
        public async Task DownloadTheImage(string uri, string fileName)
>>>>>>> master
=======
        public async Task DownloadTheImage(string uri, string fileName)
>>>>>>> master
        {
            Uri url = new Uri(uri);
            try
            {
                using (WebClient client = new WebClient())
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    client.DownloadFileAsync(url, fileName);
=======
                    await client.DownloadFileTaskAsync(url, fileName);
>>>>>>> master
=======
                    await client.DownloadFileTaskAsync(url, fileName);
>>>>>>> master
                    client.Dispose();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> master
=======
>>>>>>> master
        }

    }
}
