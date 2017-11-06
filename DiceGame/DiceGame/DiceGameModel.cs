using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame {
    public class DiceGameModel {

        const int DEFAULT_NUMBER_OF_DICE = 1;
        const int DEFAULT_NUMBER_OF_FACES = 6;

        private Player _aPlayer;
        private int _numberOfDice;
        private Die[] _dice;

        public Player APlayer { get => _aPlayer; set => _aPlayer = value; }
        public int NumberOfDice { get => _numberOfDice; set => _numberOfDice = value; }
        public Die[] Dice { get => _dice; set => _dice = value; }

        public DiceGameModel() : this(DEFAULT_NUMBER_OF_DICE, DEFAULT_NUMBER_OF_FACES) {}

        public DiceGameModel(int nbOfDice, int nbOfFaces)
        {
            this.NumberOfDice = nbOfDice;
            this.Dice = new Die[this.NumberOfDice];
            for (int i = 0; i < this.Dice.Length; i++)
            {
                this.Dice[i] = new Die(nbOfFaces);
            }
        }

        public DiceGameModel(int[] nbOfDice, int[] nbOfFaces)
        {
            for (int i = 0; i < nbOfDice.Length; i++)
            {
                for (int j = 0; j < nbOfFaces.Length; j++)
                {
                    this.NumberOfDice = nbOfDice[i];
                    this.Dice = new Die[this.NumberOfDice];
                    for (int k = 0; k < this.Dice.Length; k++)
                    {
                        this.Dice[k] = new Die(nbOfFaces[j]);
                    }
                }
            }
        }
    }
}
