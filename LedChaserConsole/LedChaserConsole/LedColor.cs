/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class LedColor : Led
    {
        private static byte DEFAULT_COLOR = 0;

        private byte _red;
        private byte _green;
        private byte _blue;

        public byte Red { get => _red; set => _red = value; }
        public byte Green { get => _green; set => _green = value; }
        public byte Blue { get => _blue; set => _blue = value; }

        public LedColor() : this(DEFAULT_COLOR, DEFAULT_COLOR, DEFAULT_COLOR)
        {

        }


        public LedColor(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
    }
}
