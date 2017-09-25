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
    public partial class vue : Form
    {
        meteo meteo = new meteo();
        public vue()
        {
            InitializeComponent();
            label1.Text = meteo.showMeteo();
        }

        private void vue_Load(object sender, EventArgs e)
        {

        }
    }
}
