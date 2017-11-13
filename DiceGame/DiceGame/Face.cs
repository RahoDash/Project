/** 
 * version 1.0
 * CHAUCHE Benoit
 * MENDEZ Gregory
 * ROSSET Alexandre
 * Date : 02.11.2017 16:06:35
 * 
 * Updated by SILKA Besmir
 * version 2.0
 * 07.11.2017
 */

namespace DiceGame
{
    public class Face {
        private string _symbol;

        public string Symbol { get => _symbol; set => _symbol = value; }

        public Face(string symbol) {
            this.Symbol = symbol;
        }
    }
}
