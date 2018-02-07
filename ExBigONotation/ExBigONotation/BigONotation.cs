/* $Id: BigONotation.cs 4975 2013-10-30 06:15:07Z marechal $ */
/* CFPT-EI
Project : ExBigONotation
Author : C. Marechal
Description : Console exercice for measuring algorithm complexity
For each algorithm (algo1..algo4), determine time complexity with Landau notation O()
*/
using System;

namespace ExBigONotation
{
    /// <summary>
    /// Class for measuring different algorithm complexity
    /// </summary>
    class BigONotation
    {
        private Random rnd;
        private int[] theArray;
        private int arraySize;
        private int itemsInArray = 0;

        /// <summary>
        /// Designated constructor for creating an (uninitialized) integer array
        /// </summary>
        /// <param name="size"></param>
        public BigONotation(int size)
        {
            rnd = new Random();
            arraySize = size;
            theArray = new int[size];
        }

        /// <summary>
        /// Initializing method for random content
        /// </summary>
        public void generateRandomArray()
        {
            for (int i = 0; i < arraySize; i++)
            {
                theArray[i] = rnd.Next(10, 1000);
            }
            itemsInArray = arraySize - 1;
        }

        /// <summary>
        /// Initializing method for sorted content
        /// </summary>
        public void generateSortedArray()
        {
            for (int i = 0; i < arraySize; i++)
            {
                theArray[i] = i;
            }
            itemsInArray = arraySize - 1;
        }

        // O(1) An algorithm that executes in the same
        // time regardless of the amount of data
        // This code executes in the same amount of
        // time no matter how big the array is
        public void addItemToArray(int newItem)
        {
            theArray[itemsInArray++] = newItem;
        }


        // 0(N) An algorithm thats time to complete will
        // grow in direct proportion to the amount of data
        // The linear search is an example of this

        // To find all values that match what we
        // are searching for we will have to look in
        // exactly each item in the array

        // If we just wanted to find one match the Big O
        // is the same because it describes the worst
        // case scenario in which the whole array must
        // be searched

        public string linearSearchForValue(int value)
        {
            string indexesWithValue = "";

            for (int i = 0; i < arraySize; i++)
            {
                if (theArray[i] == value)
                {
                    indexesWithValue += i.ToString() + " ";
                }
            }
            return indexesWithValue;
        }


        // O(N^2) Time to complete will be proportional to
        // the square of the amount of data (Bubble Sort)
        // Algorithms with more nested iterations will result
        // in O(N^3), O(N^4), etc. performance

        // Each pass through the outer loop (0)N requires us
        // to go through the entire list again so N multiplies
        // against itself or it is squared
        private void swapValues(int indexOne, int indexTwo)
        {
            int temp = theArray[indexOne];
            theArray[indexOne] = theArray[indexTwo];
            theArray[indexTwo] = temp;
        }

        public void bubbleSort()
        {
            for (int i = arraySize - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (theArray[j] > theArray[j + 1])
                    {
                        swapValues(j, j + 1);
                    }
                }
            }
        }

        // O (log N) Occurs when the data being used is decreased
        // by roughly 50% each time through the algorithm. The
        // Binary search is a perfect example of this.

        // Pretty fast because the log N increases at a dramatically
        // slower rate as N increases

        // O (log N) algorithms are very efficient because increasing
        // the amount of data has little effect at some point early
        // on because the amount of data is halved on each run through

        public int binarySearchForValue(int value)
        {
            int matchIndex = -1;
            int lowIndex = 0;
            int highIndex = arraySize - 1;

            while (lowIndex <= highIndex)
            {
                int middleIndex = (highIndex + lowIndex) / 2;

                if (theArray[middleIndex] < value)
                    lowIndex = middleIndex + 1;

                else if (theArray[middleIndex] > value)
                    highIndex = middleIndex - 1;
                else
                {
                    matchIndex = middleIndex;
                    lowIndex = highIndex + 1; // in order to exit the loop
                }
            }
            return matchIndex;
        }
    }
}
