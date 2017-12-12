/** 
* version 1.0
* CHAUCHE Benoit
* MENDEZ Gregory
* ROSSET Alexandre
* Date : 02.11.2017 16:06:35
* 
* Updated by SILKA Besmir
* version 3.0
* 12.12.2017
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DiceGameView : Form
    {
        //const
        const string DEFAULT_NAME = "Die ";

        //fields
        int counter = 1;

        private DiceGameModel _model;
        private List<DieView> _dieV;


        /// <summary>
        /// Properties
        /// </summary>
        public DiceGameModel Model { get => _model; set => _model = value; }
        public List<DieView> DieV { get => _dieV; set => _dieV = value; }


        /// <summary>
        /// Constructor
        /// </summary>
        public DiceGameView() {
            InitializeComponent();
            this.Model = new DiceGameModel(Convert.ToInt32(this.nudFaces.Value));
            this.DieV = new List<DieView>();
        }


        /// <summary>
        /// Generate the dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInit_Click(object sender, EventArgs e)
        {

            //kill at the begin the dice before adding
            this.KillDice();

            //call a new model
            this.Model = new DiceGameModel(Convert.ToInt32(this.nudFaces.Value));
            
            //We add on the list the View first
            for (int i = 0; i < this.nudDice.Value; i++)
            {
                this.DieV.Add(new DieView(DEFAULT_NAME + counter.ToString(), 0, 200 * i, this.Model));
                counter++;
            }

            //Then we show them
            foreach (DieView d in this.DieV)
            {
                d.Show();
            }
        }


        /// <summary>
        /// Action to roll dice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRoll_Click(object sender, EventArgs e)
        {
            foreach (DiceGameController item in this.Model.Observer)
            {
                item.RollDice();
            }
        }


        /// <summary>
        /// Will close the Form in the list of forms
        /// </summary>
        public void KillDice()
        {
            if (this.DieV.Count > 0)
            {
                foreach (DieView d in this.DieV)
                {
                    d.Close();
                }
            }

            //empty the list
            this.DieV.Clear();
        }
    }
}
