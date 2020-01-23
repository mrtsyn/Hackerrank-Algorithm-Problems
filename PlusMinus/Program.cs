using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            int numberOfPositives = 0, numberOfNegatives = 0, numberOfZeros = 0;
            decimal rateOfPositives = 0.0M;
            decimal rateOfNegatives = 0.0M;
            decimal rateOfZeros = 0.0M;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    numberOfNegatives++;
                if (arr[i] > 0)
                    numberOfPositives++;
                if (arr[i] == 0)
                    numberOfZeros++;
            }

            rateOfNegatives = Convert.ToDecimal(numberOfNegatives) / Convert.ToDecimal(arr.Length);
            rateOfPositives = Convert.ToDecimal(numberOfPositives) / Convert.ToDecimal(arr.Length);
            rateOfZeros = Convert.ToDecimal(numberOfZeros) / Convert.ToDecimal(arr.Length);

            Console.WriteLine(Math.Round(rateOfPositives, 6));
            Console.WriteLine(Math.Round(rateOfNegatives, 6));
            Console.WriteLine(Math.Round(rateOfZeros, 6));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }
    }

    // QUESTION

    //Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros.
    //Print the decimal value of each fraction on a new line.

    //Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to 10^-4 are acceptable.

    //For example, given the array arr=[1,1,0,-1,-1] there are 5 elements, two positive, two negative and one zero.
    //Their ratios would be 2/5=0.400000, 2/5=0.400000 and 1/5=0.200000. It should be printed as

    //0.400000
    //0.400000
    //0.200000

    //Function Description:
    //Complete the plusMinus function in the editor below.
    //It should print out the ratio of positive, negative and zero items in the array, each on a separate line rounded to six decimals.

    //plusMinus has the following parameter(s):
    //arr: an array of integers

    //Input Format:
    //The first line contains an integer, n, denoting the size of the array.
    //The second line contains n space-separated integers describing an array of numbers.

    //Constraints:
    // 0<n<=100
    // -100<=arr[i]<=100

    //Output Format:
    //You must print the following 3 lines:
    //1. A decimal representing of the fraction of positive numbers in the array compared to its size.
    //2. A decimal representing of the fraction of negative numbers in the array compared to its size.
    //3. A decimal representing of the fraction of zeros in the array compared to its size.

    //Sample Input:
    //6
    //-4 3 -9 0 4 1
             
    //Sample Output:
    //0.500000
    //0.333333
    //0.166667

    //Explanation:
    //There are 3 positive numbers, 2 negative numbers, and 1 zero in the array. 
    //The proportions of occurrence are positive: 3/6=0.500000, negative: 2/6=0.333333 and zeros: 1/6=0.166667.
}
