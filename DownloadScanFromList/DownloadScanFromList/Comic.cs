using DownloadScanFromList;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Download_scan
{
    class Comic
    {
        Download dl;
        Chapter ch;
        Folder fl;

        public Comic()
        {
            dl = new Download();
            ch = new Chapter();
            fl = new Folder();
        }

        public async Task DownloadAll(string title, string fileName)
        {
            //string folder = fileName + @"\" + ch.GetTheChapterName(url);

            if (fl.existFolder(fileName))
            {
                fl.createFolder(fileName);
            }

            List<string> chapter = getChapterList(title);

            foreach (var chap in chapter)
            {
                await ch.DownloadChapter(title, chap, fileName +"\\"+ chap);
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
    }
}
