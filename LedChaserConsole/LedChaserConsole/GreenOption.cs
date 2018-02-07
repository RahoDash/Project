/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class GreenOption : OptionDecorator
    {
        private const string DEFAULT_OPTION_NAME = "green";
        private readonly byte DEFAULT_VALUE_COLOR = 0xff;

        public GreenOption(Led al) : base(al)
        {
            this.Component = al;
            this.OptionName = DEFAULT_OPTION_NAME;
            this.OptionColor.Green = DEFAULT_VALUE_COLOR;
        }
    }
}
