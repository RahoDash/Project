using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge3
{
    public class Chocolat : IngredientDecorator
    {
        const int DEFAULT_COCOA_PERCENT = 70;
        const string DEFAULT_INGREDIENT_NAME = "Chocolat";
        const decimal DEFAULT_INGREDIENT_PRICE = 0.20M;

        public int PercentCocoa { get; set; }

        public Chocolat(Dessert d) : base(d)
        {
            this.IngredientName = DEFAULT_INGREDIENT_NAME;
            this.IngredientPrice = DEFAULT_INGREDIENT_PRICE;
            this.PercentCocoa = DEFAULT_COCOA_PERCENT;
        }
    }
}
