using DownloadScanFromList;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
=======
using System.Threading.Tasks;
>>>>>>> master

namespace Download_scan
{
    class Chapter
    {

        private string[] DEFAULT_URL = { "http:", "", "readcomics.website", "uploads", "manga", "", "", "", "" };
        /// <summary>
        /// variable
        /// </summary>
        Download dl;
        Folder fl;


        /// <summary>
        /// constructor
        /// </summary>
        public Chapter()
        {
            dl = new Download();
            fl = new Folder();
        }

        /// <summary>
        /// methode
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileName"></param>
<<<<<<< HEAD
        public void DownloadChapter(string title, string chapter, string fileName)
=======
        public async Task DownloadChapter(string title, string chapter, string fileName)
>>>>>>> master
        {
            int page = 00;
            string path = "", completeURL, extetion = ".jpg", spage = Convert.ToString(page); spage.PadLeft(2, '0');
            string[] url = DEFAULT_URL; url[5] = title; url[6] = "chapters"; url[7] = chapter;

            if (!fl.existFolder(fileName))
            {
                fl.createFolder(fileName);
            }

            do
            {
                if (page < 10)
                {
                    page++; spage = Convert.ToString(page); spage = spage.PadLeft(2, '0');
                }
                else
                {
                    page++; spage = Convert.ToString(page);
                }
                url[8] = spage + extetion;
                completeURL = "";

                for (int i = 0; i < url.Length; i++)
                {
                    completeURL += url[i];
                    if (i < 8)
                    {
                        completeURL += "/";
                    }
                }
                path = fileName + "\\" + spage + extetion;
<<<<<<< HEAD
                dl.DownloadTheImage(completeURL, path);

            } while (dl.VerifieThePath(completeURL));



=======
                if (dl.VerifieThePath(completeURL))
                    await dl.DownloadTheImage(completeURL, path);

            } while (dl.VerifieThePath(completeURL));
>>>>>>> master
        }
    }
}