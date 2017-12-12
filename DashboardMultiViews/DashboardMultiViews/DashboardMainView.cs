using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardMultiViews
{
    public partial class DashboardMainView : Form
    {
        const int DEFAULT_VALUE = 0;
        const string DEFAULT_NAME = "DashboardView";

        int counter = 1;

        private DashboardModel _model;

        internal DashboardModel Model { get => _model; set => _model = value; }

        public DashboardMainView()
        {
            InitializeComponent();
            this.Model = new DashboardModel(DEFAULT_VALUE);
        }

        private void BtnNewDashboardView_Click(object sender, EventArgs e)
        {
            new DashboardView(DEFAULT_NAME + counter.ToString(), 0, 0, this.Model).Show();
            counter++;
        }
    }
}
