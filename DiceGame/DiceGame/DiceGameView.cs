using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame {
    public partial class DiceGameView : Form {
        private DiceGameController _controller;
        public DiceGameController Controller { get => _controller; set => _controller = value; }

        public DiceGameView() {
            InitializeComponent();
            Controller = new DiceGameController(this);
            Controller.InitLabel();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Controller.DeleteLabels();
            Controller.Init(nudDice, nudFaces);
            Controller.CreateLabels(nudDice);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Controller.RollDices();
            Controller.ShowResult();
        }
    }
}
