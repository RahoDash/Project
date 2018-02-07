/* CFPT-EI POO
Project : LedChaserConsole (LCC)
Author : B. SILKA
Description : project for illustrating Decorator Design Pattern
*/

namespace LedChaserConsole
{
    public class Led
    {
        private const string DEFAULT_NAME = "LED";
        private static readonly LedColor DEFAULT_LED_COLOR = new LedColor(0,0,0);
        private const bool DEFAULT_ON = false;

        private string _name;
        private LedColor _ligntColor;
        private bool _on;

        public virtual string Name { get => _name; set => _name = value; }
        public virtual bool On { get => _on; set => _on = value; }
        internal virtual LedColor LightColor { get => _ligntColor; set => _ligntColor = value; }

        public Led() : this (DEFAULT_NAME, DEFAULT_LED_COLOR, DEFAULT_ON) { }

        public Led(string paramName, LedColor paramLigth, bool paramOn)
        {
            this.Name = paramName;
            this.LightColor = paramLigth;
            this.On = paramOn;
        }
    }
}
