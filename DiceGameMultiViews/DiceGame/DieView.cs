/** 
* Created by SILKA Besmir
* version 1.0
* 12.12.2017
*/
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DieView : Form
    {
        //fields
        private DiceGameController _controller;

        //properties
        public DiceGameController Controller { get => _controller; set => _controller = value; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paramName">Name of the form</param>
        /// <param name="paramTop">Value top position</param>
        /// <param name="paramLeft">Value left position</param>
        /// <param name="paramModel">Model to use</param>
        public DieView(string paramName, int paramTop, int paramLeft, DiceGameModel paramModel)
        {
            InitializeComponent();
            this.Controller = new DiceGameController(this, paramModel);
            this.Top = paramTop;
            this.Left = paramLeft;
            this.Text = paramName;
        }

        /// <summary>
        /// Update the top face symbole
        /// </summary>
        public void UpdateView()
        {
            this.LblDieView.Text = this.Controller.Model.Die.GetTopFace().Symbol;
        }

        /// <summary>
        /// We remove from the observer when closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DieView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controller.Dispose();
        }
    }
}
