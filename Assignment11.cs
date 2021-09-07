using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class GFG
    {
        static void thirdLargest(int[] arr,
                                 int arr_size)
        {
            /* There should be
            atleast three elements */
            if (arr_size < 3)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            // Find first
            // largest element
            int first = arr[0];
            for (int i = 1;
                     i < arr_size; i++)
                if (arr[i] > first)
                    first = arr[i];

            // Find second
            // largest element
            int second = -int.MaxValue;
            for (int i = 0;
                     i < arr_size; i++)
                if (arr[i] > second &&
                    arr[i] < first)
                    second = arr[i];

            // Find third
            // largest element
            int third = -int.MaxValue;
            for (int i = 0;
                     i < arr_size; i++)
                if (arr[i] > third &&
                    arr[i] < second)
                    third = arr[i];

            Console.Write("The third Largest " +
                          "element is " + third);
            Console.ReadLine();

        }
       

        // Driver code
        public static void Main()
        {
            int[] arr = {12, 15, 1,
                 10, 34, 16};
            int n = arr.Length;
            thirdLargest(arr, n);
        }
    }
}

// This code is contributed by Smitha
