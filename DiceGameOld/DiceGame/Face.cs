using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Face 
    {
        bool _onTop;
        Symbol Symbol;

        public bool OnTop { get => _onTop; set => _onTop = value; }

        public Face(Symbol symbol, bool onTop)
        {
            Symbol = symbol;
            OnTop = OnTop;
        }
    }
}