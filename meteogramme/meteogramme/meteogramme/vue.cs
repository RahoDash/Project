using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meteogramme
{
    public partial class Vue : Form
    {
        //Meteo meteo = new Meteo();
        DownloadDATA DL; //= new DownloadDATA(txtLat.Text, txtLon.Text);

        public Vue()
        {
            InitializeComponent();
            //label1.Text = meteo.showMeteo();
        }

        private void Vue_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DL = new DownloadDATA(txtLat.Text, txtLon.Text);
        }
    }
}
