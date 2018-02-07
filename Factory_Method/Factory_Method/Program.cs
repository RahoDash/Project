/**
 * Author : B.SILKA
 * Date : 01.02.18
 * Description : Design pattern FabricMethod
 * Inpired of : http://www.dofactory.com/net/factory-method-design-pattern
 **/
using System;

namespace Factory_Method
{
    //{ BeginList }
    /// <summary>
    /// Program startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");

                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
    //{ EndList }
}