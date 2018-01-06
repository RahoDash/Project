using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge3
{
    class IngredientDecorator : Dessert
    {
        private Dessert _component;
        private string _ingredientName;
        private decimal _ingredientPrice;

        public string IngredientName { get => _ingredientName; set => _ingredientName = value; }
        public decimal IngredientPrice { get => _ingredientPrice; set => _ingredientPrice = value; }
        internal Dessert Component { get => _component; set => _component = value; }

        public override string Name
        {
            get
            {
                return this.Component.Name + " au " + this.IngredientName;
            }
        }

        public override decimal Price
        {
            get
            {
                return this.Component.Price + this.IngredientPrice;
            }
        }

        public IngredientDecorator(Dessert d)
        {
            this.Component = d;
        }


    }
}
