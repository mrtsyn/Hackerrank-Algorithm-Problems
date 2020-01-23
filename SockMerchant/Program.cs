using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            List<int> tmp = new List<int>(ar);
            if (tmp.Contains(-1))
                tmp.RemoveAt(tmp.Count - 1);
            int pairSockNumber = 0;
            for (int i = 0; i < tmp.Count - 1; i++)
            {
                for (int j = i + 1; j < tmp.Count; j++)
                {
                    if (tmp[i] == tmp[j])
                    {
                        tmp.RemoveAt(i);
                        tmp.RemoveAt(j-1);
                        pairSockNumber++;
                        i = i-1;
                        break;
                    }
                }
            }
            return pairSockNumber;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => arTemp!="" ? Convert.ToInt32(arTemp) : -1);

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    // QUESTION

    //John works at a clothing store.He has a large pile of socks that he must pair by color for sale.
    //Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

    //For example, there are n=7 socks with colors ar=[1,2,1,2,1,3,2]. There is one pair of color 1 and one of color 2. 
    //There are three odd socks left, one of each color. The number of pairs is 2.

    //Function Description:

    //Complete the sockMerchant function in the editor below.It must return an integer representing the number of matching pairs of socks that are available.

    //sockMerchant has the following parameter(s):

    //n: the number of socks in the pile
    //ar: the colors of each sock

    //Input Format:

    //The first line contains an integer n, the number of socks represented in ar. 
    //The second line contains n space-separated integers describing the colors ar[i] of the socks in the pile.

    //Constraints:
    // 1.  1<=n<=100
    // 2.  1<=ar[i]<=100 where 0<=i<=n
    
    //Output Format:
    //Return the total number of matching pairs of socks that John can sell.


    //Sample Input:
    //9
    //10 20 20 10 10 30 50 10 20

    //Sample Output:
    //3
}
