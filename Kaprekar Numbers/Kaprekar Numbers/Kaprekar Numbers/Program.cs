using System.CodeDom.Compiler;//system provided code
using System.Collections.Generic;//system provided code
using System.Collections;//system provided code
using System.ComponentModel;//system provided code
using System.Diagnostics.CodeAnalysis;//system provided code
using System.Globalization;//system provided code
using System.IO;//system provided code
using System.Linq;//system provided code
using System.Reflection;//system provided code
using System.Runtime.Serialization;//system provided code
using System.Text.RegularExpressions;//system provided code
using System.Text;//system provided code
using System;//system provided code

class Result//system provided code
{

    /*
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)//system provided code
    {
        /*Here's where we get to play.
         * There's a few steps here. First, we have 2 numbers. Every number we are dealing with is between p and q.
         * We need to check each number between p and q inclusive to see if it's a Kaprekar number.
         * We know if it's a Kaprekar number. See question details for how to find that.
         * Then we need to store the results in an array, and return the array.
         * If the array is empty, return "INVALID RANGE" instead
         */
        List<int> result = new List<int>();
        for (int i = p; i <= q; i++)
        {
            long isquared = (long)i * i; // use a long here to make sure we don't have overflow.
            int numDigits = (int)Math.Floor(Math.Log10(i)) + 1; // get the number of digits in i
            int secondPart = (int)(isquared % Math.Pow(10, numDigits)); // get the second part of the split by using 10 to the power of the number of digits, then 
            int firstPart = (int)(isquared / Math.Pow(10, numDigits)); // get the first part of the split by dividing the number by 10 to the power of the number of digits. Since its an intiger value it'll drop what's after the decimal.
            int sum = firstPart + secondPart; // add em up 
            if (sum == i && secondPart != 0) // If the second part wasn't a 0, and the sum is equal to our original value i, add i to our result list
            {
                result.Add(i);
            }
        }
        if (result.Any() == false) // if result has no values, return INVALID RANGE
        {
            Console.WriteLine("INVALID RANGE");
        }
        else
        {
            Console.WriteLine(string.Join(" ", result)); //otherwise print our result list as a string adding spaces in between each value.
        }
    }
}

    class Solution//system provided code
    {
        public static void Main(string[] args)//system provided code
        {
            int p = Convert.ToInt32(Console.ReadLine().Trim());//system provided code

            int q = Convert.ToInt32(Console.ReadLine().Trim());//system provided code

            Result.kaprekarNumbers(p, q);//system provided code
        }
    }
