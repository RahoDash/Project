/** 
 * version 1.0
 * CHAUCHE Benoit
 * MENDEZ Gregory
 * ROSSET Alexandre
 * Date : 02.11.2017 16:06:35
 * 
 * Updated by SILKA Besmir
 * version 2.0
 * 07.11.2017
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DiceGameView : Form
    {
        const string DEFAULT_NAME = "Die ";

        int counter = 1;

        private DiceGameModel _model;
        private List<DieView> _dieV;

        public DiceGameModel Model { get => _model; set => _model = value; }
        public List<DieView> DieV { get => _dieV; set => _dieV = value; }

        public DiceGameView() {
            InitializeComponent();
            this.Model = new DiceGameModel(Convert.ToInt32(this.nudFaces.Value));
            this.DieV = new List<DieView>();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            if (this.DieV.Count > 0)
            {
                foreach (DieView d in this.DieV)
                {
                    d.Close();
                }
            }

            this.Model = new DiceGameModel(Convert.ToInt32(this.nudFaces.Value));

            this.DieV.Clear();

            for (int i = 0; i < this.nudDice.Value; i++)
            {
                this.DieV.Add(new DieView(DEFAULT_NAME + counter.ToString(), 0, 0, this.Model));
                counter++;
            }
            foreach (DieView d in this.DieV)
            {
                d.Show();
            }
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            foreach (DiceGameController item in this.Model.Observer)
            {
                item.RollDice();
            }
        }
    }
}
