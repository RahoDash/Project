/* CFPT-EI
 * Project : ExBigONotation
 * Author : B.SILKA
 * Version: 1.0
 * Date : 30.01.18
 * File description : Export values of time executing methodes into csv file.
*/

using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ExBigONotation
{
    class Program
    {

        const int VALUE_TO_FIND = 9999;
        static readonly string[] NAMES_METHODS = new string[] { "RandomArray_AddItemToArray",
            "RandomArray_LinearSearchForValue", "RandomArray_BubbleSort", "RandomArray_BinarySearchForValue",
            "SortedArray_AddItemToArray", "SortedArray_LinearSearchForValue", "SortedArray_BubbleSort",
            "SortedArray_BinarySearchForValue" };

        StringBuilder ResultArray = new StringBuilder();


        static void Main(string[] args)
        {
            int[] valuesBig = new int[] { 100000, 100000, 150000, 200000, 250000, 300000, 350000, 400000, 450000,
                500000, 550000, 600000, 650000, 700000, 750000, 800000, 850000, 900000, 950000, 1000000};

            var ResultArray = new StringBuilder();
            var header = ";" + string.Join(";", valuesBig);
            ResultArray.AppendLine(header);
            for (int i = 0; i < NAMES_METHODS.Length; i++)
            {

                var inLoop = NAMES_METHODS[i] + ";";
                var time = string.Empty;
                var newLine = string.Empty;

                foreach (int val in valuesBig)
                {
                    Stopwatch TimeElapse = new Stopwatch();
                    BigONotation bigOn = new BigONotation(val);

                    //Only for bubble sort methode
                    if (i == 2 || i == 6)
                    {
                        bigOn = new BigONotation(val / 1000);
                    }

                    //Switch on unsorted and sorted array
                    if (i < 4)
                        bigOn.generateRandomArray();
                    else
                        bigOn.generateSortedArray();

                    //For all except the AddItemToArray method
                    if (i != 0 && i != 4)
                        bigOn.addItemToArray(VALUE_TO_FIND);

                    TimeElapse.Start();
                    switch (i)
                    {
                        case 0:
                            bigOn.addItemToArray(VALUE_TO_FIND);
                            break;
                        case 1:
                            bigOn.linearSearchForValue(VALUE_TO_FIND);
                            break;
                        case 2:
                            bigOn.bubbleSort();
                            break;
                        case 3:
                            bigOn.binarySearchForValue(VALUE_TO_FIND);
                            break;
                    }
                    TimeElapse.Stop();
                    double nanoSecond = TimeElapse.Elapsed.TotalMilliseconds;
                    time += nanoSecond.ToString() + ";";

                    Console.WriteLine("Data = {0} --> {1}", val, TimeElapse.Elapsed.TotalMilliseconds);
                }
                newLine = string.Format("{0}{1}", inLoop, time);
                ResultArray.AppendLine(newLine);

                Console.WriteLine("----------------------------");
                Console.WriteLine(Environment.NewLine);
            }
            File.AppendAllText(@"test.csv", ResultArray.ToString());
        }

    }
}