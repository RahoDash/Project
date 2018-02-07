/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class RectangularLed : Led
    {
        private const string DEFAULT_NAME = "Rectangular Led";
        private static readonly LedColor DEFAULT_LED_COLOR = new LedColor(0, 0, 0);
        private const bool DEFAULT_ON = false;

        public RectangularLed() : this(DEFAULT_NAME, DEFAULT_LED_COLOR, DEFAULT_ON) { }

        public RectangularLed(string paramName, LedColor paramLigth, bool paramOn) : base(DEFAULT_NAME, DEFAULT_LED_COLOR, DEFAULT_ON)
        {
            this.Name = paramName;
            this.LightColor = paramLigth;
            this.On = paramOn;
        }
    }
}
