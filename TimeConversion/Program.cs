using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            string result = "";
            string hour = "", minut="",second="";
            string AmPmFormat = "";
            hour = s.Substring(0, 2);
            minut = s.Substring(3, 2);
            second = s.Substring(6, 2);
            AmPmFormat = s.Substring(8, 2);

            if(AmPmFormat == "AM")
            {
                if (hour == "12")
                    hour = "00";
            }
            if(AmPmFormat == "PM" && hour != "12")
            {
                hour = Convert.ToString(Int32.Parse(hour) + 12);
            }
            result = hour + ":" + minut + ":" + second;
            return result;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    // QUESTION
    //Given a time in 12-hour AM/PM format, convert it to military(24-hour) time.

    //Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock.Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.


    //Function Description:
    //Complete the timeConversion function in the editor below.It should return a new string representing the input time in 24 hour format.

    //timeConversion has the following parameter(s):
    //s: a string representing time in  hour format

    //Input Format:
    //A single string s containing a time in 12-hour clock format(i.e.: hh:mm:ssAM or hh:mm:ssPM), where 01<=hh<=12 and 00<=mm,ss<=59.

    //Constraints:
    //All input times are valid

    //Output Format:
    //Convert and print the given time in 24-hour format, where 00<=hh<=23.

    //Sample Input 0:
    //07:05:45PM

    //Sample Output 0:
    //19:05:45
}
