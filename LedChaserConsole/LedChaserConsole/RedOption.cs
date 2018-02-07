/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class RedOption : OptionDecorator
    {
        private const string DEFAULT_OPTION_NAME = "red";
        private readonly byte DEFAULT_VALUE_COLOR = 0xff;

        public RedOption(Led al) : base(al)
        {
            this.Component = al;
            this.OptionName = DEFAULT_OPTION_NAME;
            this.OptionColor.Red = DEFAULT_VALUE_COLOR;
        }
    }
}
