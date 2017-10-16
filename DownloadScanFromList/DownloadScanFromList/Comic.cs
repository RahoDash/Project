using DownloadScanFromList;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
=======
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
>>>>>>> master

namespace Download_scan
{
    class Comic
    {
        Download dl;
        Chapter ch;
        Folder fl;

<<<<<<< HEAD

=======
>>>>>>> master
        public Comic()
        {
            dl = new Download();
            ch = new Chapter();
            fl = new Folder();
        }

<<<<<<< HEAD
        public void DownloadAll(string title, string fileName)
=======
        public async Task DownloadAll(string title, string fileName)
>>>>>>> master
        {
            //string folder = fileName + @"\" + ch.GetTheChapterName(url);

            if (fl.existFolder(fileName))
            {
                fl.createFolder(fileName);
            }

            List<string> chapter = getChapterList(title);

            foreach (var chap in chapter)
            {
<<<<<<< HEAD
                ch.DownloadChapter(title, chap, fileName +"\\"+ chap);
=======
                await ch.DownloadChapter(title, chap, fileName +"\\"+ chap);
>>>>>>> master
            }
            //do
            //{
            //    ch.DownloadChapter(title, chapter:;
            //    url = setNextChapter(url);

            //} while (dl.VerifieThePath(url));
        }

        private List<string> getChapterList(string title)
        {
            List<string> chapterList = new List<string>();
            using (StreamReader reader = File.OpenText(@"..\..\Comics\" + title + ".txt"))
            {
                while (!reader.EndOfStream)
                {
                    chapterList.Add(reader.ReadLine());
                }
                reader.Dispose();
            }
            return chapterList;
        }
<<<<<<< HEAD


        //public string setNextChapter(string url)
        //{
        //    string[] splitedEntry = url.Split('/');
        //    int j, i = 0;

        //    while (splitedEntry[i] != "chapters")
        //    {
        //        i++;
        //    }

        //    j = Convert.ToInt16(ch.GetTheChapterNum(url));
        //    j++;
        //    splitedEntry[i + 1] = j.ToString();

        //    url = "";
        //    for (int k = 0; k < splitedEntry.Length; k++)
        //    {
        //        url += splitedEntry[k]; 
        //        if (k < splitedEntry.Length-1)
        //        {
        //            url += '/';
        //        }

        //    }

        //    return url;
        //}
=======
>>>>>>> master
    }
}
