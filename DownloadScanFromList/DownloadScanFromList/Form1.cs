using Download_scan;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< HEAD
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
=======
using System.IO;
>>>>>>> master
=======
using System.IO;
>>>>>>> master
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

<<<<<<< HEAD
<<<<<<< HEAD
        private void btnDlAll_Click(object sender, EventArgs e)
        {
            comic.DownloadAll(lstbTitle.SelectedItem.ToString(), path +"\\"+lstbTitle.SelectedItem.ToString());
=======
        private async void btnDlAll_Click(object sender, EventArgs e)
        {
            await comic.DownloadAll(lstbTitle.SelectedItem.ToString(), path +"\\"+lstbTitle.SelectedItem.ToString());
>>>>>>> master
=======
        private async void btnDlAll_Click(object sender, EventArgs e)
        {
            await comic.DownloadAll(lstbTitle.SelectedItem.ToString(), path +"\\"+lstbTitle.SelectedItem.ToString());
>>>>>>> master
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> master
            if (File.Exists(@"..\..\Comics\list-comics.txt"))
            {
                //I.init();
            }
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> master

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

<<<<<<< HEAD
<<<<<<< HEAD
        private void BtnDlCh_Click(object sender, EventArgs e)
=======
        private async void BtnDlCh_Click(object sender, EventArgs e)
>>>>>>> master
=======
        private async void BtnDlCh_Click(object sender, EventArgs e)
>>>>>>> master
        {
            string saveFile = path + "\\" + lstbTitle.SelectedItem.ToString();
            if (cmbChapter.SelectedIndex>-1)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                ch.DownloadChapter(lstbTitle.SelectedItem.ToString(), cmbChapter.SelectedItem.ToString(), saveFile + "\\" + cmbChapter.SelectedItem.ToString());
=======
                await ch.DownloadChapter(lstbTitle.SelectedItem.ToString(), cmbChapter.SelectedItem.ToString(), saveFile + "\\" + cmbChapter.SelectedItem.ToString());
>>>>>>> master
=======
                await ch.DownloadChapter(lstbTitle.SelectedItem.ToString(), cmbChapter.SelectedItem.ToString(), saveFile + "\\" + cmbChapter.SelectedItem.ToString());
>>>>>>> master
            }
        }
    }
}
