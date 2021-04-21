using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        
//Problem Solving
//Let's suppossed than a dreamer person give you some numbers, and you always make manual decition of wich numbers play, but always you lose some combination and that is what always win 
//pd: obviously we are solving a situation for people than play lotteries if you dont believe on that, please shut up and just see a code for make all posible combinations of a serie in a chain of characters
//The original code is from m_kit and adapt it to the described situation.


    static void Main(string[] args)
        { 
            var numbersFromPredictionDream = "12-15-16-58-65";
      
            //we convert it to an array of numbers
            int[] numbers = numbersPrediction
             .Split('-', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
      
            int n = numbers.Length;
            printCombination(numbers, n, 1);
            printCombination(numbers, n, 2);
            printCombination(numbers, n, 3);
           
        }
        
        
        
        static void combinationUtil(int[] arr, int[] data,
                                int start, int end,
                                int index, int r)
        {
            // Current combination is
            // ready to be printed,
            // print it
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }

            // replace index with all
            // possible elements. The
            // condition "end-i+1 >=
            // r-index" makes sure that
            // including one element
            // at index will make a
            // combination with remaining
            // elements at remaining positions
            for (int i = start; i <= end &&
                      end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1,
                                end, index + 1, r);
            }
        }

        // The main function that prints
        // all combinations of size r
        // in arr[] of size n. This
        // function mainly uses combinationUtil()
        static void printCombination(int[] arr,
                                     int n, int r)
        {
            // A temporary array to store
            // all combination one by one
            int[] data = new int[r];

            // Print all combination
            // using temprary array 'data[]'
            combinationUtil(arr, data, 0,
                            n - 1, 0, r);
        }

        // Driver Code
       

    // This code is contributed by m_kit


    }
}

