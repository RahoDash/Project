<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPuzzle222_6
{
    class Program
    {
        static readonly char[] OPERATORS = { '+', '-', '*', '/' };
        static readonly int[] OPERATORS_PRIORITY = { 12, 13 };
        static readonly Operator[] OPERATORS_RESULT = { new Operator(OPERATORS[0], OPERATORS_PRIORITY[0], (a, b) => a + b),
                                                        new Operator(OPERATORS[1], OPERATORS_PRIORITY[0], (a, b) => a - b),
                                                        new Operator(OPERATORS[2], OPERATORS_PRIORITY[1], (a, b) => a * b),
                                                        new Operator(OPERATORS[3], OPERATORS_PRIORITY[1], (a, b) => a / b)};
        static readonly int NUMB_OPERATOR = OPERATORS.Length;
        const int MIN_NUMBER = 2;
        const int MAX_NUMBER = 6;
        const int TARGET = 6;

        static void Main(string[] args)
        {
            int numberFound;
            for (int i = MIN_NUMBER; i <= MAX_NUMBER; i++)
            {
                for (int j = 0; j < NUMB_OPERATOR; j++)
                {
                    for (int k = 0; k < NUMB_OPERATOR; k++)
                    {
                        if (OPERATORS_RESULT[j].Priority < OPERATORS_RESULT[k].Priority)
                        {
                            numberFound = OPERATORS_RESULT[j].Op(i, OPERATORS_RESULT[k].Op(i, i));
                        }
                        else
                        {
                            numberFound = OPERATORS_RESULT[k].Op(OPERATORS_RESULT[j].Op(i, i), i);
                        }
                        if (numberFound == TARGET)
                        {
                            Console.WriteLine($"{i} {OPERATORS_RESULT[j].NameOp} {i} {OPERATORS_RESULT[k].NameOp} {i} = {numberFound} ");
                        }
                    }
                }
            }
        }
    }
}
=======
﻿/***
* Name     :   Operator Puzzle 2 () 2 () 2 = 6
* Author   :   Besmir Silka
* Desc.    :   Program Operator, The result of the same number through different operator must be result to the target,
*                                with the priority of the operator to take in consideration.    
* Version  :   1.0, 26.09.2017, B.SILKA  
***/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPuzzle222_6
{
    class Program
    {
        /// <summary>
        /// Constant
        /// </summary>
        static readonly char[] OPERATORS = { '+', '-', '*', '/' }; //The array of operators
        static readonly int[] OPERATORS_PRIORITY = { 12, 13 }; // The array priority of the operator, the lesser the higher the priority is
        static readonly Operator[] OPERATORS_RESULT = { new Operator(OPERATORS[0], OPERATORS_PRIORITY[0], (a, b) => a + b),
                                                        new Operator(OPERATORS[1], OPERATORS_PRIORITY[0], (a, b) => a - b),
                                                        new Operator(OPERATORS[2], OPERATORS_PRIORITY[1], (a, b) => a * b),
                                                        new Operator(OPERATORS[3], OPERATORS_PRIORITY[1], (a, b) => a / b)}; // An array of methodes, with a delgated method
        static readonly int NUMB_OPERATOR = OPERATORS.Length; // Numbers of record on the "OPERATORS_RESULT"
        //The operation will go to MIN_NUMBER to MAX_NUMBER
        const int MIN_NUMBER = 2; 
        const int MAX_NUMBER = 6;

        //This will be the target of the operation
        const int TARGET = 6;

        static void Main(string[] args)
        {
            //this will be compared to the target to accept the result
            int numberFound;
            for (int i = MIN_NUMBER; i <= MAX_NUMBER; i++)
            {
                for (int j = 0; j < NUMB_OPERATOR; j++)
                {
                    for (int k = 0; k < NUMB_OPERATOR; k++)
                    {
                        if (OPERATORS_RESULT[j].Priority < OPERATORS_RESULT[k].Priority)
                        {
                            numberFound = OPERATORS_RESULT[j].Op(i, OPERATORS_RESULT[k].Op(i, i));
                        }
                        else
                        {
                            numberFound = OPERATORS_RESULT[k].Op(OPERATORS_RESULT[j].Op(i, i), i);
                        }
                        if (numberFound == TARGET)
                        {
                            Console.WriteLine($"{i} {OPERATORS_RESULT[j].NameOp} {i} {OPERATORS_RESULT[k].NameOp} {i} = {numberFound} ");
                        }
                    }
                }
            }
        }
    }
}
>>>>>>> master
