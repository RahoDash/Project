/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class RoundLed : Led
    {
        private const string DEFAULT_NAME = "Rounded Led";
        private static readonly LedColor DEFAULT_LED_COLOR = new LedColor(0, 0, 0);
        private const bool DEFAULT_ON = false;

        public RoundLed() : this(DEFAULT_NAME, DEFAULT_LED_COLOR, DEFAULT_ON)
        {

        }

        public RoundLed(string paramName, LedColor paramLigth, bool paramOn): base(DEFAULT_NAME, DEFAULT_LED_COLOR, DEFAULT_ON)
        {
            this.Name = paramName;
            this.LightColor = paramLigth;
            this.On = paramOn;
        }
    }
}
