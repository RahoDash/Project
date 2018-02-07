/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class OptionDecorator : Led
    {
        private Led _component;
        private string _optionName;
        private LedColor _optionColor;

        public string OptionName { get => _optionName; set => _optionName = value; }
        internal Led Component { get => _component; set => _component = value; }
        internal LedColor OptionColor { get => _optionColor; set => _optionColor = value; }

        public OptionDecorator(Led al)
        {
            this.Component = al;
        }

        public override string Name
        {
            get
            {
                return this.Component.Name + ", " + this.OptionName;
            }
        }
    }
}
