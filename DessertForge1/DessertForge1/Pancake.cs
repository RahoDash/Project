using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge1
{
    class Pancake : Dessert
    {
        const string DEFAULT_NAME = "Crêpe";
        const decimal DEFAULT_PRICE = 1.50M;

        public Pancake() : this(DEFAULT_NAME, DEFAULT_PRICE) { }

        public Pancake(string paramName, decimal paramPrice) : base(DEFAULT_NAME, DEFAULT_PRICE)
        {
            this.Name = paramName;
            this.Price = paramPrice;
        }
    }
}
