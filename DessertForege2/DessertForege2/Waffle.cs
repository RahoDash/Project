using DessertForege2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge1
{
    class Waffle : Dessert
    {
        const string DEFAULT_NAME = "Gaufre";
        const decimal DEFAULT_PRICE = 1.80M;

        public Waffle() : this(DEFAULT_NAME, DEFAULT_PRICE) { }
        public ChocolatWaffle ChWaffle { get; set; }

        public Waffle(string paramName, decimal paramPrice) : base(DEFAULT_NAME, DEFAULT_PRICE)
        {
            this.Name = paramName;
            this.Price = paramPrice;
        }
    }
}
