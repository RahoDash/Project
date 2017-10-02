using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseDelegate
{
    class Program
    {
        delegate string UppercaseDelegate(string a);

        static void WriteOutput(string input, UppercaseDelegate upper)
        {
            Console.WriteLine(" Your string before : {0}", input);
            Console.WriteLine(" Your string after : {0}", upper.Invoke(input));
        }

        static void Main()
        {

            //UppercaseDelegate UppercaseFirst = upper => upper.First().ToString().ToUpper() + String.Join("",upper.Skip(1));
            // Wrap the methods inside delegate instances and pass to the method.
            UppercaseDelegate UppercaseFirst = a => a.Replace(a[0], (char)(a[0] - 0x20));
            UppercaseDelegate uppercaseFirst = new UppercaseDelegate(UppercaseFirst);
            Console.WriteLine(" With delegate \" UppercaseFirst \"");
            WriteOutput("perls", UppercaseFirst);

            //UppercaseDelegate UppercaseLast = upper => String.Join("", upper.Skip(upper.Length - 1)) + upper.Last().ToString().ToUpper();
            UppercaseDelegate UppercaseLast = a => a.Replace(a[a.Length - 1], (char)(a[a.Length - 1] - 0x20));
            UppercaseDelegate uppercaseLast = new UppercaseDelegate(UppercaseLast);
            Console.WriteLine(" nWith delegate \" UppercaseLast \"");
            WriteOutput("perls", UppercaseLast);


            //UppercaseDelegate Uppercase = upper => upper.ToUpper();
            UppercaseDelegate Uppercase = a => a.ToUpper();
            UppercaseDelegate uppercase = new UppercaseDelegate(Uppercase);
            Console.WriteLine(" nWith an anonymous method which put all characters uppercase ");
            WriteOutput("perls", new UppercaseDelegate(Uppercase));


            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            for (int i = 0; i < 1000000; i++)
            {
                uppercaseLast.Invoke("perls");
            }
            stopWatch1.Stop();
            Console.WriteLine(" UppercaseLast {0} [ms]", stopWatch1.ElapsedMilliseconds);
        }
    }
}
