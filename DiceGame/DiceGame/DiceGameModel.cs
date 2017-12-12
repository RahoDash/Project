

using System;
using System.Collections.Generic;
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
namespace DiceGame
{
    public class DiceGameModel {
        
        //const
        const int DEFAULT_NUMBER_OF_DICE = 1;
        const int DEFAULT_NUMBER_OF_FACES = 6;

        //fields
        private int _numberOfDice;
        private Die _die;
        private List<Object> _observer;

        //Properties
        public int NumberOfDice { get => _numberOfDice; set => _numberOfDice = value; }
        public List<Object> Observer { get => _observer; set => _observer = value; }
        public Die Die { get => _die; set => _die = value; }


        //default constructor 
        public DiceGameModel() : this(DEFAULT_NUMBER_OF_FACES) {}

        //designed constructor
        public DiceGameModel(int nbOfFaces)
        {
            this.Observer = new List<Object>();
            this.Die = new Die(nbOfFaces);
        }

        public void RegisterObserver(Object paramObserver)
        {
            if (paramObserver != null)
            {
                this.Observer.Add(paramObserver);
            }
        }

        public void UnregisterController(Object paramObserver)
        {
            this.Observer.Remove(paramObserver);
        }



        //this is not tested yet
        //public DiceGameModel(int[] nbOfDice, int[] nbOfFaces)
        //{
        //    for (int i = 0; i < nbOfDice.Length; i++)
        //    {
        //        for (int j = 0; j < nbOfFaces.Length; j++)
        //        {
        //            this.NumberOfDice = nbOfDice[i];
        //            this.Dice = new Die[this.NumberOfDice];
        //            for (int k = 0; k < this.Dice.Length; k++)
        //            {
        //                this.Dice[k] = new Die(nbOfFaces[j]);
        //            }
        //        }
        //    }
        //}
    }
}
