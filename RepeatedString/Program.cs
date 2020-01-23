﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
            long repeatNumberOfA = 0;
            int repeatNumberOfAInString = 0;
            //char chkaracter = 'a';
            List<char> str = new List<char>();
            str.AddRange(s);
            long remainder = n % (long)str.Count;
            long division = n / (long)str.Count;

            for (int i = 0; i < str.Count; i++)
            {
                if (str[i] == 'a')
                    repeatNumberOfAInString++;
            }
            long multiply = division * repeatNumberOfAInString;
            for (int j = 0; j < remainder; j++)
            {
                if (str[j] == 'a')
                    repeatNumberOfA++;
            }
            repeatNumberOfA = repeatNumberOfA + multiply;
			return repeatNumberOfA;
			
            //********* this attempt didn't work, the error is System.OutOfMemoryException ***************
            //if (s.Length != 1)
            //{
            //    for (int i = 1; i < division; i++)
            //    {
            //        str.AddRange(s);
            //    }
            //    for (int j = 0; j < remainder; j++)
            //    {
            //        str.Add(str[j]);
            //    }
            //    for (int k = 0; k < str.Count; k++)
            //    {
            //        if (str[k] == character)
            //            repeatNumberOfA++;
            //    }
            //    return repeatNumberOfA;
            //}
            //else
            //{
            //    repeatNumberOfA = n;
            //    return repeatNumberOfA;
            //}
            
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    // QUESTION

    //Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.

    //Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.

    //For example, if the string s='abcac' and n=10, the substring we consider is abcacabcac, the first 10 characters of her infinite string. 
    //There are 4 occurrences of a in the substring.

    //Function Description:
    //Complete the repeatedString function in the editor below.
    //It should return an integer representing the number of occurrences of a in the prefix of length n in the infinitely repeating string.

    //repeatedString has the following parameter(s):
    //s: a string to repeat
    //n: the number of characters to consider

    //Input Format:
    //The first line contains a single string, s. 
    //The second line contains an integer, n.

    //Constraints:
    // 1<=|s|<=100
    // 1<= n <= 10^12
    //For 25% of the test cases, n<=10^6.

    //Output Format:
    //Print a single integer denoting the number of letter a's in the first n letters of the infinite string created by repeating s infinitely many times.

    //Sample Input 0:
    //aba
    //10

    //Sample Output 0:
    //7

    //Explanation 0:
    //The first n=10 letters of the infinite string are abaabaabaa.Because there are 7 a's, we print 7 on a new line.

    //Sample Input 1:
    //a
    //1000000000000

    //Sample Output 1:
    //1000000000000

    //Explanation 1 :
    //Because all of the first n=1000000000000 letters of the infinite string are a, we print 1000000000000 on a new line.
}
