﻿using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DownloadScanFromList
{
    class Folder
    {
        public void CreateNewFile(List<string> list, string path)
        {
            File.WriteAllLines(path +".txt", list);
        }

        public bool existFolder(string path)
        {
            return System.IO.Directory.Exists(path);
        }

        public void createFolder(string path)
        {
            System.IO.Directory.CreateDirectory(path);
        }

        public void RefreshFolder(ListBox lstbox, string path)
        {
            lstbox.Items.Clear();
            string[] files = Directory.GetFiles(path);
            foreach (var f in files)
            {
                lstbox.Items.Add(f);
            }
        }
    }
}
