using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualizeTheArray
{
    class Program
    {
        static int equalizeArray(int[] arr)
        {
            int result = 0;
            int number = 0, repeatedNumber = 1;
            List<int> list = new List<int>(arr);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> listofDuplicates = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                repeatedNumber = 1;
                if(i!=list.Count-1)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        number = list[i];
                        if (list[i] == list[j])
                        {
                            repeatedNumber++;
                        }
                    }
                    if (!dict.ContainsKey(number))
                        dict.Add(number, repeatedNumber);
                }
                else
                {
                    number = list[i];
                    if (!dict.ContainsKey(number))
                        dict.Add(number, repeatedNumber);
                }
            }
            var maxValue = dict.Values.Max();
            result = list.Count - maxValue;
            return result;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = equalizeArray(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    // QUESTION

    //Karl has an array of integers.He wants to reduce the array until all remaining elements are equal.
    //Determine the minimum number of elements to delete to reach his goal.

    //For example, if his array is arr=[1,2,2,3], we see that he can delete the 2 elements 1 and 3 leaving arr=[2,2]. 
    //He could also delete both twos and either the 1 or the 3, but that would take 3 deletions.The minimum number of deletions is 2.

    //Function Description:
    //Complete the equalizeArray function in the editor below.It must return an integer that denotes the minimum number of deletions required.

    //equalizeArray has the following parameter(s):
    //arr: an array of integers

    //Input Format:
    //The first line contains an integer n, the number of elements in arr. 
    //The next line contains n space-separated integers arr[i].

    //Constraints:
    // 1<=n<=100
    //1<=arr[i]<=100

    //Output Format:
    //Print a single integer that denotes the minimum number of elements Karl must delete for all elements in the array to be equal.

    //Sample Input:
    //5
    //3 3 2 1 3

    //Sample Output:
    //2   

    //Explanation:
    //Array arr=[3,3,2,1,3]. If we delete arr[2]=2 and arr[3]=1, all of the elements in the resulting array, A=[3,3,3], will be equal.
    //Deleting these 2 elements is minimal.
    //Our only other options would be to delete 4 elements to get an array of either [1] or [2].
}
