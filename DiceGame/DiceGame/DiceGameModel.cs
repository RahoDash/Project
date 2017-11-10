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
        private Player _aPlayer;
        private int _numberOfDice;
        private Die[] _dice;

        //Properties
        public Player APlayer { get => _aPlayer; set => _aPlayer = value; }
        public int NumberOfDice { get => _numberOfDice; set => _numberOfDice = value; }
        public Die[] Dice { get => _dice; set => _dice = value; }


        //default constructor 
        public DiceGameModel() : this(DEFAULT_NUMBER_OF_DICE, DEFAULT_NUMBER_OF_FACES) {}

        //designed constructor
        public DiceGameModel(int nbOfDice, int nbOfFaces)
        {
            this.NumberOfDice = nbOfDice;
            this.Dice = new Die[this.NumberOfDice];
            for (int i = 0; i < this.Dice.Length; i++)
            {
                this.Dice[i] = new Die(nbOfFaces);
            }
        }

        //this is not tested yet
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
