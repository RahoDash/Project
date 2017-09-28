/*$Id: Program.cs 5735 2014-10-03 08:24:58Z marechal $*/
/* CFPT-EI
Project : CfptColor
Author : C. Marechal
Description : Console exercice for training class construction (designated constructor, methods, DRY principle)
File : main program for final check

Edited : Besmir SILKA

*/

using System;

namespace ExCfptColor
{
    class Program
    {
        static void Main(string[] args)
        {

            CfptColor aCfptColor = new CfptColor();
            CfptColor bCfptColor = new CfptColor(10, 20, 30);
            CfptColor cCfptColor = new CfptColor(0.10, 0.25, 0.75);
            CfptColor dCfptColor = new CfptColor(0xCAFE80);
            Console.WriteLine("aColor = {0}", aCfptColor.ToString());
            Console.WriteLine("bColor = {0}", bCfptColor.ToString());
            Console.WriteLine("cColor = {0}", cCfptColor.ToString());
            Console.WriteLine("dColor = {0}", dCfptColor.ToString());
            Console.WriteLine();

            Console.WriteLine("cColor contient plus de rouge que dColor : {0}", cCfptColor.ContainsMoreRedThan(dCfptColor));
            Console.WriteLine("cColor contient plus de vert que dColor : {0}", cCfptColor.ContainsMoreGreenThan(dCfptColor));
            Console.WriteLine("cColor contient plus de bleu que dColor : {0}", cCfptColor.ContainsMoreBlueThan(dCfptColor));
            Console.WriteLine();

            Console.WriteLine("cColor est égale à cColor : {0}", cCfptColor.IsEqual(cCfptColor));
            Console.WriteLine("cColor est égale à dColor : {0}", cCfptColor.IsEqual(dCfptColor));
            Console.WriteLine();

            Console.WriteLine("Distance euclidienne entre cColor et dColor = {0}", cCfptColor.EuclideanDistance(dCfptColor));
        }
    }
}
