using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long toplam = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                toplam += ar[i];
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = aVeryBigSum(ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    // QUESTION

    //Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

    //Function Description:
    //Complete the aVeryBigSum function in the editor below.It must return the sum of all array elements.

    //aVeryBigSum has the following parameter(s):
    //ar: an array of integers.

    //Input Format:
    //The first line of the input consists of an integer n.
    //The next line contains n space-separated integers contained in the array.

    //Output Format:
    //Print the integer sum of the elements in the array.

    //Constraints:
    // 1<=n<=10
    // 0<=ar[i]<=10^10

    //Sample Input:
    //5
    //1000000001 1000000002 1000000003 1000000004 1000000005

    //Output:
    //5000000015
}
