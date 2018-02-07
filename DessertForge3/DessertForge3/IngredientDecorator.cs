using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge3
{
    public class IngredientDecorator : Dessert
    {
        private Dessert _component;
        private string _ingredientName;
        private decimal _ingredientPrice;

        public string IngredientName { get => _ingredientName; set => _ingredientName = value; }
        public decimal IngredientPrice { get => _ingredientPrice; set => _ingredientPrice = value; }
        public Dessert Component { get => _component; set => _component = value; }

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


        public Dessert RemoveIngredient(Type t)
        {

            bool found = false;

            if (this.GetType() == t)
            {
                return this.Component;
            }
            else
            {
                Dessert currentObject = this.Component;
                Dessert previousObject = this;
                while (currentObject.GetType().BaseType == typeof(IngredientDecorator) && (found==false))
                {
                    if (currentObject.GetType() == t)
                    {
                        (previousObject as IngredientDecorator).Component = (currentObject as IngredientDecorator).Component;
                        found = true;
                    }
                    else
                    {
                        previousObject = (previousObject as IngredientDecorator).Component;
                        currentObject = (currentObject as IngredientDecorator).Component;
                    }
                }
                return this;
            }
        }
    }
}
