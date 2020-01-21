﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int pointForA = 0, pointForB = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    pointForA++;
                else if (a[i] < b[i])
                    pointForB++;
            }
            result.Add(pointForA);
            result.Add(pointForB);
            return result;
        }
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }

    // QUESTION

    //Alice and Bob each created one problem for HackerRank.A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: 
    //problem clarity, originality, and difficulty.

    //We define the rating for Alice's challenge to be the triplet a=(a[0],a[1],a[2]), and the rating for Bob's challenge to be the triplet b=(b[0],b[1],b[2]).

    //Your task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].


    //If a[i]>b[i], then Alice is awarded point.
    //If a[i]<b[i], then Bob is awarded point.
    //If a[i]=b[i], then neither person receives a point.
    //Comparison points is the total points a person earned.

    //Given and, determine their respective comparison points.

    //For example, a=[1,2,3] and b=a=[3,2,1].For elements 0, Bob is awarded a point because a[0]<b[0]. For the equal elements a[1] and b[1], no points are earned. 
    //Finally, for elements 2, a[2]>b[2] so Alice receives a point.Your return array would be [1,1] with Alice's score first and Bob's second.


    //Function Description:
    //Complete the function compareTriplets in the editor below.It must return an array of two integers, the first being Alice's score and the second being Bob's.

    //compareTriplets has the following parameter(s):
    //a: an array of integers representing Alice's challenge rating
    //b: an array of integers representing Bob's challenge rating

    //Input Format:
    //The first line contains 3 space-separated integers, a[0], a[1], and a[2], describing the respective values in triplet a.
    //The second line contains 3 space-separated integers, b[0], b[1], and b[2], describing the respective values in triplet b.

    //Constraints:
    // 1<=a[i]<=100
    // 1<=b[i]<=100

    //Output Format:
    //Return an array of two integers denoting the respective comparison points earned by Alice and Bob.

    //Sample Input 0:
    //5 6 7
    //3 6 10

    //Sample Output 0:
    //1 1

    //Sample Input 1:
    //17 28 30
    //99 16 8

    //Sample Output 1:
    //2 1
}
