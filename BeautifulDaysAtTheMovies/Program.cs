using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            var result = 0;
            for (int m = i; m <= j; m++)
            {
                int left = m;
                int reverse = 0;
                while (left>0)
                {
                    reverse = reverse * 10 + left % 10;
                    left /= 10;
                }
                int subs = Math.Abs(m - reverse);
                if(subs%k == 0)
                {
                    result++;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}

// QUESTION

//Lily likes to play games with integers.She has created a new game where she determines the difference between a number and its reverse.
//For instance, given the number 12, its reverse is 21. Their difference is 9. The number 120 reversed is 21, and their difference is 99.

//She decides to apply her game to decision making.She will look at a numbered range of days and will only go to a movie on a beautiful day.

//Given a range of numbered days, [i...j] and a number k, determine the number of days in the range that are beautiful.
//Beautiful numbers are defined as numbers where |i - reverse(i)| is evenly divisible by k.
//If a day's value is a beautiful number, it is a beautiful day. 
//Print the number of beautiful days in the range.

//Function Description:
//Complete the beautifulDays function in the editor below.It must return the number of beautiful days in the range.

//beautifulDays has the following parameter(s):

//i: the starting day number
//j: the ending day number
//k: the divisor

//Input Format
//A single line of three space-separated integers describing the respective values of i, j, and k.

//Constraints
// 1<=i<=j<=2*10^6
// 1<=k<=2*10^9

//Output Format:
//Print the number of beautiful days in the inclusive range between i and j.

//Sample Input:
//20 23 6

//Sample Output:
//2

//Explanation:
//Lily may go to the movies on days 20, 21, 22, and 23.We perform the following calculations to determine which days are beautiful:


//Day 20 is beautiful because the following evaluates to a whole number: 18/6 = 3
//Day 21 is not beautiful because the following doesn't evaluate to a whole number: 9/6 = 1,5
//Day 22 is beautiful because the following evaluates to a whole number: 0/6 = 0
//Day 23 is not beautiful because the following doesn't evaluate to a whole number: 9/6= 1,5
//Only two days, 20 and 22, in this interval are beautiful.Thus, we print 2 as our answer.
