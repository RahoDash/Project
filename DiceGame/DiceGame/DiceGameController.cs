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
    public class DiceGameController : IDisposable {

        //fields
        private DiceGameModel _model;
        private DieView _view;

        //properties
        public DiceGameModel Model { get => _model; set => _model = value; }
        public DieView View { get => _view; set => _view = value; }

        //constructor
        internal DiceGameController(DieView paramView, DiceGameModel paramModel) {
            this.Model = paramModel;
            this.View = paramView;

            this.Model.RegisterObserver(this);
        }

        /// <summary>
        /// Take the numeric from the view the instancy the model
        /// </summary>
        /// <param name="dice">Number of dice</param>
        /// <param name="faces">Number of faces</param>
        public void Init(NumericUpDown dice, NumericUpDown faces)
        {
            this.Model = new DiceGameModel(Convert.ToInt32(faces.Value));
        }

        /// <summary>
        /// Roll all the dice
        /// </summary>
        public void RollDice()
        {
            foreach (DiceGameController o in this.Model.Observer)
            {
                o.Model.Die.TopFace = this.Model.Die.Roll();
                this.View.UpdateView();
            }
        }

        public void Dispose()
        {

        }
    }
}
