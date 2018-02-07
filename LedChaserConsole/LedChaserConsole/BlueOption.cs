/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class BlueOption : OptionDecorator
    {
        private const string DEFAULT_OPTION_NAME = "blue";
        private readonly byte DEFAULT_VALUE_COLOR = 255;

        public BlueOption(Led al) : base(al)
        {
            this.Component = al;
            this.OptionName = DEFAULT_OPTION_NAME;
            this.OptionColor.Blue = DEFAULT_VALUE_COLOR;
        }
    }
}
