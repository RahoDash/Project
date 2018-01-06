using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge1
{
    class Dessert
    {
        const string DEFAULT_NAME = "No-Name";
        const decimal DEFAULT_PRICE = 0.0M;

        private string _name;
        private decimal _price;

        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }


        public Dessert() : this(DEFAULT_NAME, DEFAULT_PRICE)
        {

        }
        public Dessert(string paramName, decimal paramPrice)
        {
            this.Name = paramName;
            this.Price = paramPrice;
        }

    }
}
