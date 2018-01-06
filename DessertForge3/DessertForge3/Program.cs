using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dessert dessert = new Pancake();
            dessert = new Chocolat(dessert);
            dessert = new Chantilly(dessert);

            Console.WriteLine(dessert.Name + " " + dessert.Price);
        }
    }
}
