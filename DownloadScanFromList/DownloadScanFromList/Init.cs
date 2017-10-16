using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DownloadScanFromList
{
    class Init
    {
        private const string DEFAULT_URL_LIST = "http://readcomics.website/comic-list";
        private const string DEFAULT_URL = "http://readcomics.website/comic";

        //private List<string> URLs;


        public void init()
        {
            Folder fol = new Folder();

            fol.CreateNewFile(xmlExtractor(), "..\\..\\Comics\\list-comics.txt");
            
            string[] titles = File.ReadAllLines("..\\..\\Comics" + "\\list-comics.txt");

            foreach (var title in titles)
            {
                fol.CreateNewFile(trie(getChapterByComic(DEFAULT_URL +"/"+ title), title), "..\\..\\Comics\\" + title);
            }

            //fol.CreateNewFile(trie(HtmlExtractor(DEFAULT_URL_LIST), "tag"), path + "\\list-comics");



            //foreach (var t in title)
            //{
            //    if (VerifieThePath(DEFAULT_URL + "/" + t))
            //    {
            //        fol.CreateNewFile(trie(HtmlExtractor(DEFAULT_URL + "/" + t), t), path + "\\" + t);
            //    }
            //}

        }

        private List<string> xmlExtractor()
        {
            string link;
            string[] links;
            List<string> names = new List<string>();
            //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            //myRequest.Method = "GET";
            //WebResponse myResponse;
            try
            {
                //myResponse = myRequest.GetResponse();
                using (XmlReader reader = XmlReader.Create(File.Open("..\\..\\XMLFile1.xml", FileMode.Open)))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (reader.Name == "a")
                                {
                                    if (reader.HasAttributes)
                                    {
                                        reader.MoveToAttribute("href");
                                        link = reader.GetAttribute("href");
                                        //link = reader.Value;
                                        links = link.Split('/');
                                        names.Add(links[4]);
                                    }
                                }
                                break;
                            //case XmlNodeType.Attribute:

                            //    break;
                            default:
                                break;
                        }
                    }
                }
                return names;
            }
            catch (Exception)
            {

                return names;
            }
        }

        private string getChapterByComic(string url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            WebResponse myResponse;
            try
            {
                myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();
                myRequest.Abort();
                Console.WriteLine(result);
                return result;
            }

            catch (Exception)
            {
                return "";
            }
        }

        private List<string> trie(string data, string compare)
        {
            string[] brute = data.Split('/');
            string[] selected;
            List<string> name = new List<string>();
            for (int i = 0; i < brute.Length; i++)
            {
                if (brute[i] == compare)
                {
                    selected = brute[i + 1].Split('"');
                    if (selected[0].Length >= 2)
                    {
                        selected[0].Remove(selected[0].Length - 2);
                    }
                    if (selected[0] != "cover")
                    {
                        name.Add(selected[0]);
                    }
                }
            }
            return name;
        }

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
                response.StatusCode == HttpStatusCode.Redirect))
            {
                result = true;
            }
            response.Dispose();
            request.Abort();
            return result;
        }
    }


}

