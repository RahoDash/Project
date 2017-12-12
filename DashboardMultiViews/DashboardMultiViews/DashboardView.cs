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
    public partial class DashboardView : Form
    {
        private DashboardController _controller;

        internal DashboardController Controller { get => _controller; set => _controller = value; }

        internal DashboardView(string paramName, int paramLeft, int paramTop, DashboardModel paramModel)
        {
            
            InitializeComponent();
            this.Controller = new DashboardController(this, paramModel);

            chbNotif.Checked = true;
            this.Text = paramName;
        }

        public void UpdateView()
        {
            lblLevel.Text = this.Controller.GetLevel().ToString();
            trbLevel.Value = this.Controller.GetLevel();
            lblStatu.Text = this.Controller.GetStatus();
        }

        private void TrbLevel_Scroll(object sender, EventArgs e)
        {
            if (chbNotif.Checked)
            {
                this.Controller.SetLevel(trbLevel.Value);
                this.lblLevel.Text = trbLevel.Value.ToString();
            }
        }

        private void ChbNotif_Click(object sender, EventArgs e)
        {
            if (chbNotif.Checked)
                this.Controller.Model.RegisterObserver(this.Controller);
            else
                this.Controller.Model.UnregisterObserver(this.Controller);
        }
    }
}
