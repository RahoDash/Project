using DessertForge1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessertForege2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dessert dessert;
            dessert = new ChocolatWaffle();

            Console.WriteLine(dessert.Name, dessert.Price);
        }
    }
}
