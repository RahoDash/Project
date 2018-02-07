/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    class LCSModel
    {
        private int _numberOfLed;
        private Led[] _chaser;


        public LCSModel(int paramNbOfLed)
        {
            this.NumberOfLed = paramNbOfLed;
            this.Chaser = new Led[this.NumberOfLed];
        }

        public int NumberOfLed { get => _numberOfLed; set => _numberOfLed = value; }
        public Led[] Chaser { get => _chaser; set => _chaser = value; }
    }
}