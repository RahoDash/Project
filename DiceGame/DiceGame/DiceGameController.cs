using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame {
    public class DiceGameController {
        private DiceGameModel _model;
        private DiceGameView _view;

        public DiceGameModel Model { get => _model; set => _model = value; }
        public DiceGameView View { get => _view; set => _view = value; }

        public DiceGameController(DiceGameView view) {
            this.Model = new DiceGameModel();
            this.View = view;
        }

        public void Init(NumericUpDown dice, NumericUpDown faces )
        {
            this.Model = new DiceGameModel(Convert.ToInt32(dice.Value), Convert.ToInt32(faces.Value));
        }

        public void InitLabel()
        {
            foreach (Label lbl in this.View.groupBox1.Controls.OfType<Label>())
            {
                lbl.Text = "1";
            }
        }

        public void ShowDiceOnLabel(Label[] lbl)
        {
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].Text = this.Model.Dice[i].TopFace.ToString();
            }
        }

        public void CreateLabels(NumericUpDown nbOfDice)
        {
            ArrayList label = new ArrayList(Convert.ToInt16(nbOfDice.Value));
            for (int i = 0; i < nbOfDice.Value; i++)
            {
                var temp = new Label();
                temp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                temp.Location = new System.Drawing.Point(6+(60*i), 26);
                temp.Name = "lblDice" + i.ToString();
                temp.Size = new System.Drawing.Size(50, 50);
                temp.TabIndex = 0;
                temp.Text = this.Model.Dice[i].TopFace.ToString();
                temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.View.groupBox1.Controls.Add(temp);
                temp.Show();
                label.Add(temp);
            }
            
        }

        public void RollDices()
        {
            for (int i = 0; i < this.Model.Dice.Length; i++)
            {
                this.Model.Dice[i].Roll();
            }
        }

        public void ShowResult()
        {
            int j = 0;
            foreach (Label lbl in this.View.groupBox1.Controls.OfType<Label>())
            {
                lbl.Text = this.Model.Dice[j].GetTopFace().Symbol;
                j++;
            }
        }

        public void DeleteLabels()
        {
            foreach (Label lbl in this.View.groupBox1.Controls.OfType<Label>())
            {
                lbl.Dispose();
                this.View.groupBox1.Controls.Clear();
            }
        }
    }
}
