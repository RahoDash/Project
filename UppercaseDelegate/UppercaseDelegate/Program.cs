/***
 * Name     :   UppercaseDelegate
 * Author   :   B.Silka
 * Desc.    :   Delegate methode of uppercase for strings
 * Version  :   5.0, 3.10.2017, B.SILKA  
 ***/

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

        unsafe static void Main()
        {
            // Wrap the methods inside delegate instances and pass to the method.
            UppercaseDelegate uppercaseFirst = new UppercaseDelegate(uppercaseFirst = a => a.Replace(a[0], (char)(a[0] - 0x20)));
            Console.WriteLine(" With delegate \" UppercaseFirst \"");
            WriteOutput("perls", uppercaseFirst);

            //UppercaseDelegate uppercaseLast = new UppercaseDelegate(uppercaseLast = a => a.Replace(a[a.Length - 1], (char)(a[a.Length - 1] & 0xDF)));
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/how-to-modify-string-contents
            UppercaseDelegate uppercaseLast = new UppercaseDelegate(uppercaseLast = a => { fixed (char* p = a) { p[a.Length - 1] &= (char)0xDF; } return a; });

            Console.WriteLine(" nWith delegate \" UppercaseLast \"");
            WriteOutput("perls", uppercaseLast);

            UppercaseDelegate uppercase = new UppercaseDelegate(uppercase = a => a.ToUpper());
            Console.WriteLine(" nWith an anonymous method which put all characters uppercase ");
            WriteOutput("perls", new UppercaseDelegate(uppercase));

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
