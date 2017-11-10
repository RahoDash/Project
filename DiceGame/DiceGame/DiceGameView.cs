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
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DiceGameView : Form {
        private DiceGameController _controller;
        public DiceGameController Controller { get => _controller; set => _controller = value; }

        public DiceGameView() {
            InitializeComponent();
            Controller = new DiceGameController(this);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Controller.DeleteLabels();
            Controller.Init(nudDice, nudFaces);
            Controller.CreateLabels(nudDice);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Controller.RollDice();
            Controller.ShowResult();
        }
    }
}
