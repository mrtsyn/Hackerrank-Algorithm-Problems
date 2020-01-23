using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            char[] charArray = new char[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j <= n - 2)
                        charArray[j] = ' ';
                    else
                        charArray[j] = '#';
                }
                Console.WriteLine(charArray);
            }
            
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }

    // QUESTION

    //Consider a staircase of size n=4:

    //   #
    //  ##
    // ###
    //####

    //Observe that its base and height are both equal to n, and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.
    //Write a program that prints a staircase of size n.

    //Function Description:
    //Complete the staircase function in the editor below.It should print a staircase as described above.

    //staircase has the following parameter(s):
    //n: an integer

    //Input Format:
    //A single integer, n, denoting the size of the staircase.

    //Constraints:
    // 0<n<=100

    //Output Format:
    //Print a staircase of size n using # symbols and spaces.

    //Note: The last line must have 0 spaces in it.

    //Sample Input:
    //6 

    //Sample Output:
    //     #
    //    ##
    //   ###
    //  ####
    // #####
    //######

    //Explanation:
    //The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of n=6.
}
