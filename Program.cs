using System;
using System.Collections.Generic;

namespace C_Sharp_Basic_13
{
    public class Program
    {
        // Print 1-255:
        public static void print_1_255()
        {
            for(int i = 1; i<=255; i++)
            {
                Console.WriteLine(i);
            }
        }
// print odds:
        public static void print_odds_1_255()
        {
            for(int i = 1; i<=255; i++)
            {
                if (i%2 == 1)
                {
                Console.WriteLine(i);
                }
            }
        }
// print ints and sum 0-255:
        public static void  print_ints_sum_0_255()
        {
            int sum = 0;
            for(int i = 0; i<=255; i++)
            {
                sum = sum + i;
                Console.WriteLine($"{i}->{sum}");
            }
        }
// Iterating through an Array:
        public static void iter_print_array(int[] arr)
        {
           int len = arr.Length;
           for (int i = 0; i < len; i++) {
               Console.Write($"{arr[i]} ");
           }
        }
    // print max:
        public static int print_max(int[] arr)
        {
            int max = arr[0];
            int len = arr.Length;
            for (int i = 0; i < len; i++) {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
           }
           Console.Write($"This is MAX {max} ");
           return max;
        }
    // print avarage:
        public static void print_avg(int[] arr)
        {
            int sum = 0;
            int avg = 0;
            int len = arr.Length;
            for (int i = 0; i < len; i++) {

                sum = sum + arr[i];

           }
           avg = sum / len;
           Console.Write($"{avg} ");
        }

        // create Odd array:

        private static int count_arr_255(){
            int count = 0;
            for (int i = 1; i <= 255;i++) {
               if (i % 2 != 0) {
                   count++;
               }
            }
            return count - 1;
        }
        public static int[] create_odd_arr()
        {
            int[] result = new int[count_arr_255()];
            Console.WriteLine($"length is {count_arr_255()}");
            int count = 0;
            for(int i = 0; i<255; i++)
            {
                if (i%2 == 1)
                {
                   result[count] = i;
                   count++;
                }
            }
            int len = result.Length;
            for (int i = 0; i < len; i++) {
               Console.Write($"{result[i]} ");
            }
            return result;
        }

        // Greater than Y
        public static int GreaterThanY(int Y, int[] numbers)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num > Y)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} number(s) greater than  {Y} value");
            return count;
        }
        // Square the Values:
        public static int[] SquareValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        // Eliminate Negative Numbers:
        public static int[] EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }


        // Min, Max, and Average:

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
        
            int min = numbers[0];
            int max = numbers[0];
            int sum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }

            float average = ((float)sum / numbers.Length);
            string result = $"Min: {min},\n Max: {max},\n Average: {average},\n Sum: {(double)sum},\n Length: {(double)numbers.Length}";

            Console.WriteLine(result);
       
        }

        // Shifting the values in an array:

        public static int[] ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
                Console.WriteLine(numbers[i]);
            }
            int last = numbers[numbers.Length-1] = 0;
            Console.WriteLine(last);
            return numbers;
        }

        // Number to String:
        public static object[] NumToString(object[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] is int)
                {
                    if((int)numbers[i] < 0)
                    {
                        numbers[i] = "Dojo";
                    }
                }
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }





        public static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello, {place}!");
            print_1_255();
            print_odds_1_255();
            print_ints_sum_0_255();
            int[] arr = {1,6,100,2,3,4};
            iter_print_array(arr);
            print_max(arr);
            print_avg(arr);
            create_odd_arr();
            GreaterThanY(3, new int[] {1,3, 5, 7});
            SquareValues(new int[] {1,5,10,-10});
            EliminateNegatives(new int[] {-1, 5, 10, -2});
            int[] arr2 = {1, 5, 10, -2};
            MinMaxAverage(arr2);
            int[] arr3 = {1, 5, 10, 7, -2};
            ShiftValues(arr3);
            object[] arr4 = new object[] {4, -3, 2, -1};
            NumToString(arr4);

        }
            
        
    }
}
