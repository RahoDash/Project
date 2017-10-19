using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{


    public class Symbol
    {
        const string DEFAULT_SYMBOL = "NONE";

        /// <summary>
        /// Private Fields
        /// </summary>
        private string _content;

        public string Content { get => _content; set => _content = value; }

        /// <summary>
        /// CTOR of Symbol
        /// </summary>
        /// <param name="index"></param>
        public Symbol() : this(DEFAULT_SYMBOL){}
        public Symbol(string symb)
        {
            Content= symb;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The value of the array</returns>
        public string Display()
        {
            return Content;
        }

    }
}
