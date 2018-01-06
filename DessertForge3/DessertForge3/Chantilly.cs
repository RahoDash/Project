using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge3
{
    class Chantilly : IngredientDecorator
    {
        const string DEFAULT_NAME_INGREDIENT = "Chantilly";
        const decimal DEFAULT_PRICE_INGREDIENT = 0.50M;


        public Chantilly(Dessert d) : base(d)
        {
            this.IngredientName = DEFAULT_NAME_INGREDIENT;
            this.IngredientPrice = DEFAULT_PRICE_INGREDIENT;
            Console.WriteLine(this.AdMessage());
        }

        public string AdMessage()
        {
            return "\nC'est mieux avec des fraises !";
        }

    }
}
