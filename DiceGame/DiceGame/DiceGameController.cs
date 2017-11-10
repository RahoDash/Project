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
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace DiceGame
{
    public class DiceGameController {

        //fields
        private DiceGameModel _model;
        private DiceGameView _view;

        //properties
        public DiceGameModel Model { get => _model; set => _model = value; }
        public DiceGameView View { get => _view; set => _view = value; }

        //constructor
        public DiceGameController(DiceGameView view) {
            this.Model = new DiceGameModel();
            this.View = view;
        }

        /// <summary>
        /// Take the numeric from the view the instancy the model
        /// </summary>
        /// <param name="dice">Number of dice</param>
        /// <param name="faces">Number of faces</param>
        public void Init(NumericUpDown dice, NumericUpDown faces )
        {
            this.Model = new DiceGameModel(Convert.ToInt32(dice.Value), Convert.ToInt32(faces.Value));
        }

        /// <summary>
        /// Create labels 
        /// </summary>
        /// <param name="nbOfDice">Number of label is the number of dice</param>
        public void CreateLabels(NumericUpDown nbOfDice)
        {
            //ArrayList label = new ArrayList(Convert.ToInt16(nbOfDice.Value));
            for (int i = 0; i < nbOfDice.Value; i++)
            {
                var temp = new Label();
                temp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                temp.Location = new System.Drawing.Point(20 + (60 * i), 25);
                temp.Name = "lblDice" + i.ToString();
                temp.Size = new System.Drawing.Size(50, 50);
                temp.TabIndex = 0;
                temp.Text = this.Model.Dice[i].GetTopFace().Symbol;
                temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.View.groupBox1.Controls.Add(temp);
            }
        }

        /// <summary>
        /// Roll all the dice
        /// </summary>
        public void RollDice()
        {
            for (int i = 0; i < this.Model.Dice.Length; i++)
            {
                this.Model.Dice[i].TopFace = this.Model.Dice[i].Roll();
            }
        }

        /// <summary>
        /// Show the reslut of all dice rolled foreach dice
        /// </summary>
        public void ShowResult()
        {
            int i = 0;
            foreach (Label lbl in this.View.groupBox1.Controls.OfType<Label>())
            {
                lbl.Text = this.Model.Dice[i].GetTopFace().Symbol;
                i++;
            }
        }

        /// <summary>
        /// Delete all the labels
        /// </summary>
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
