using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame {
    public class Face {
        private string _symbol;

        public string Symbol { get => _symbol; set => _symbol = value; }

        public Face(string symbol) {
            this.Symbol = symbol;
        }
    }
}
