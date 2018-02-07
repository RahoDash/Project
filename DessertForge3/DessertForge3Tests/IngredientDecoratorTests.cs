using Microsoft.VisualStudio.TestTools.UnitTesting;
using DessertForge3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge3.Tests
{
    [TestClass()]
    public class IngredientDecoratorTests
    {
        [TestMethod()]
        public void IngredientDecoratorTest1()
        {
            Dessert aDessert = new Waffle();

            Dessert copyOfADessert = aDessert;

            aDessert = new Chocolat(aDessert);

            Dessert bDessert = (aDessert as IngredientDecorator).RemoveIngredient(typeof(Chocolat));

            Assert.AreEqual(copyOfADessert, bDessert);
        }


        [TestMethod()]
        public void IngredientDecoratorTest2()
        {
            Dessert aDessert = new Waffle();

            Dessert bDessert = new Chocolat(aDessert);

            Dessert cDessert = new Chantilly(bDessert);
            
            Dessert dessertWithoutChocolatIngredient = (cDessert as IngredientDecorator).RemoveIngredient(typeof(Chocolat));

            //Assert.AreEqual(dessertWithoutChocolatIngredient, copyADessert);
            Assert.AreEqual((cDessert as IngredientDecorator).Component, aDessert);
        }

        [TestMethod()]
        public void IngredientDecoratorTest3()
        {
            Dessert aDessert = new Waffle();

            aDessert = new Chocolat(aDessert);

            Dessert cDessert = aDessert;

            aDessert = new Chantilly(aDessert);

            Dessert bDessert = (aDessert as IngredientDecorator).RemoveIngredient(typeof(Chantilly));

            Assert.AreEqual(bDessert, cDessert);
        }
    }
}