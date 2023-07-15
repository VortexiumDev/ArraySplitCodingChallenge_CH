using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySplitCodingChallenge_CH
{
    public class ArrayController
    {
        public int DivisibleSize { get; set; }
        public int[] Array { get; set; }

        /// <summary>
        /// Instantiates the ArrayController object class with a pre-populated array and length to divide by.
        /// </summary>
        /// <param name="arraySize">Integer value for size of array</param>
        /// <param name="divisibleSize">Value to split array by</param>
        /// <exception cref="ArgumentOutOfRangeException">Array size cannot be less than 0 and Divisible size cannot be less than 1</exception>
        public ArrayController(int arraySize, int divisibleSize)
        {
            if (arraySize < 0 || divisibleSize < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.DivisibleSize = divisibleSize;
            InstantiateArray(arraySize);
        }

        /// <summary>
        /// Instantiates the ArrayController object class with a given array and length to divide by.
        /// </summary>
        /// <param name="array">Given array</param>
        /// <param name="divisibleSize">Value to split array by</param>
        /// <exception cref="ArgumentOutOfRangeException">Divisible size cannot be less than 1</exception>
        public ArrayController(int[] array, int divisibleSize)
        {
            if (divisibleSize < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.Array = array;
            this.DivisibleSize = divisibleSize;
        }

        public string GroupArrayElementsAndPrint()
        {
            int[][] dividedArray = DivideArray();
            string dividedArrayAsString = DivideArrayAsStringList(dividedArray);
            Console.WriteLine(dividedArrayAsString);

            return dividedArrayAsString;
        }

        private string DivideArrayAsStringList(int[][] array)
        {         
            List<string> elements = new List<string>();
            StringBuilder sb = new StringBuilder();

            foreach (var item in array)
            {            
                sb.Append("[");
                sb.Append(string.Join(", ", item.Select(x => x.ToString()).ToArray()));
                sb.Append("]");
                elements.Add(sb.ToString());
                sb.Clear();
            }

            sb.Clear();

            sb.Append("[ ");
            sb.Append(string.Join(", ", elements));
            sb.Append(" ]");
            
            return sb.ToString();
        }

        private void InstantiateArray(int arraySize)
        {
            Array = new int[arraySize];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i + 1;
            }
        }

        private int[][] DivideArray()
        {
            int subarraySize = Array.Length / DivisibleSize;
            int remainder = Array.Length % DivisibleSize;
            int[][] dividedArray = new int[DivisibleSize][];
            int currentIndex = 0;

            // Create DivisibleSize (N) of subarrays
            for (int i = 0; i < DivisibleSize; i++)
            {
                int currentSubarraySize = 0;

                // Increase subarray size by 1 if there is a remainder
                if (i < remainder)
                {
                    currentSubarraySize = subarraySize + 1;
                }
                else
                {
                    currentSubarraySize = subarraySize;
                }

                // Create subarray with size calculated above
                int[] subArray = new int[currentSubarraySize];

                // Populate subarray with current index of original array
                for (int j = 0; j < currentSubarraySize; j++)
                {
                    subArray[j] = Array[currentIndex];
                    currentIndex++;
                }

                // Add new subarray to 2D array
                dividedArray[i] = subArray;
            }

            return dividedArray;
        }

    }
}
