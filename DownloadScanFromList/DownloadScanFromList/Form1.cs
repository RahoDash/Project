﻿using Download_scan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadScanFromList
{
    public partial class Form1 : Form
    {
        Init I = new Init();
        FolderBrowserDialog folder;
        string path;
        List<string> list = new List<string>();
        Download dl = new Download();
        Chapter ch = new Chapter();
        Comic comic = new Comic();

        public Form1()
        {
            InitializeComponent();

        }

        private async void btnDlAll_Click(object sender, EventArgs e)
        {
            await comic.DownloadAll(lstbTitle.SelectedItem.ToString(), path +"\\"+lstbTitle.SelectedItem.ToString());
            //I.init();
            MessageBox.Show("Done !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folder = new FolderBrowserDialog();
            folder.ShowDialog();

            if (folder.SelectedPath.ToString() != "")
            {
                btnDlAll.Enabled = true;
                BtnDlCh.Enabled = true;
            }
            path = folder.SelectedPath.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lstbTitle.Items.Add(File.ReadAllLines(@"..\..\Comics\list-comics.txt"));
            if (File.Exists(@"..\..\Comics\list-comics.txt"))
            {
                //I.init();
            }

            using (StreamReader reader = File.OpenText(@"..\..\Comics\list-comics.txt"))
            {
                while (!reader.EndOfStream)
                {
                    lstbTitle.Items.Add(reader.ReadLine());
                    //list.Add(reader.ReadLine());
                }
                foreach (string s in lstbTitle.Items)
                {
                    list.Add(s);
                }
                if (lstbTitle.Items.Count > 0)
                {
                    lstbTitle.SelectedIndex = 0;
                }
                reader.Dispose();
            }
        }

        private void lstbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbChapter.Items.Clear();
            using (StreamReader reader = File.OpenText(@"..\..\Comics\" + lstbTitle.Text + ".txt"))
            {
                while (!reader.EndOfStream)
                {
                    cmbChapter.Items.Add(reader.ReadLine());
                }
                reader.Dispose();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            lstbTitle.Items.Clear();

            foreach (var l in list)
            {
                if (l.Contains(txtSearch.Text))
                {
                    result.Add(l);
                    lstbTitle.Items.Add(l);
                }
            }
        }

        private async void BtnDlCh_Click(object sender, EventArgs e)
        {
            string saveFile = path + "\\" + lstbTitle.SelectedItem.ToString();
            if (cmbChapter.SelectedIndex>-1)
            {
                await ch.DownloadChapter(lstbTitle.SelectedItem.ToString(), cmbChapter.SelectedItem.ToString(), saveFile + "\\" + cmbChapter.SelectedItem.ToString());
            }
        }
    }
}
