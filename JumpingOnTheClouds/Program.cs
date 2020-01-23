﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumpingNumber = 0;
            List<int> tmp = new List<int>(c);
            for (int i = 0; i < tmp.Count-1; i++)
            {
                if (tmp[i] == 0 && tmp[i+1] != 0)
                {
                    jumpingNumber++;
                    i += 1;
                }
                else if(tmp[i] == 0 && tmp[i+1] == 0)
                {
                    if(i+2 != tmp.Count && tmp[i+2] == 0)
                    {
                        jumpingNumber++;
                        i += 1;
                    }
                    else
                    {
                        jumpingNumber++;
                    }
                }
            }

            return jumpingNumber;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

	// QUESTION
	
    //Emma is playing a new mobile game that starts with consecutively numbered clouds.
    //Some of the clouds are thunderheads and others are cumulus.
    //She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2. 
    //She must avoid the thunderheads.Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. 
    //It is always possible to win the game.

    //For each game, Emma will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided. 
    //For example, c=[0,1,0,0,0,1,0] indexed from 0....6 . The number on each cloud is its index in the list so she must avoid the clouds at indexes 1 and 5.
    //She could follow the following two paths: 0->2->4->6 or 0->2->3->4->6.The first path takes 3 jumps while the second takes 4.

    //Function Description:
    //Complete the jumpingOnClouds function in the editor below.It should return the minimum number of jumps required, as an integer.

    //jumpingOnClouds has the following parameter(s):
    //c: an array of binary integers

    //Input Format:
    //The first line contains an integer n, the total number of clouds.The second line contains n space-separated binary integers describing clouds c[i] where 0<=i<n.

    //Constraints:
    // 2<=n<=100
    // c[i] € {0,1}
    // c[0] = c[n-1] = 0

    //Output Format:
    //Print the minimum number of jumps needed to win the game.

    //Sample Input 0:

    //7
    //0 0 1 0 0 1 0

    //Sample Output 0:
    //4

    //Explanation 0: 
    //Emma must avoid c[2] and c[5]. She can win the game with a minimum of 4 jumps:

    //Sample Input 1:
    //6
    //0 0 0 0 1 0

    //Sample Output 1:
    //3

    //Explanation 1: 
    //The only thundercloud to avoid is c[4]. Emma can win the game in 3 jumps:
}
