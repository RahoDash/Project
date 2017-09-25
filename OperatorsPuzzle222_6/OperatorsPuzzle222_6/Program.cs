using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPuzzle222_6
{
    class Program
    {
        const int MIN_NUMBER = 2;
        const int MAX_NUMBER = 6;
        const int NUMB_OPERATOR = 4;
        const int TARGET = 6;
        static readonly char[] OPERATORS = { '+', '-', '*', '/' };
        static readonly int[] OPERATORS_PRIORITY = { 12, 12, 13, 13 };
        static readonly Operator[] OPERATORS_RESULT = { new Operator(OPERATORS[0], 12, (a, b) => a + b),
                                                        new Operator(OPERATORS[1], 12, (a, b) => a - b),
                                                        new Operator(OPERATORS[2], 12, (a, b) => a * b),
                                                        new Operator(OPERATORS[3], 12, (a, b) => a / b)};

        static void Main(string[] args)
        {
            int numberFound;

            //Operator add = new Operator(OPERATORS[0], 12, (a, b) => a + b);
            //Operator sub = new Operator(OPERATORS[1], 12, (a, b) => a - b);
            //Operator mul = new Operator(OPERATORS[2], 13, (a, b) => a * b);
            //Operator div = new Operator(OPERATORS[3], 13, (a, b) => a / b);


            for (int i = MIN_NUMBER; i <= MAX_NUMBER; i++)
            {
                for (int j = 0; j < NUMB_OPERATOR; j++)
                {
                    for (int k = 0; k < NUMB_OPERATOR; k++)
                    {
                        if (OPERATORS_PRIORITY[j] < OPERATORS_PRIORITY[k])
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
