/** Chris Carruthers - example code solution for HackerRank warmup Birthday Cake Candles. Just a heads up, don't expect this code to run in Visual Studio.
Here's the problem

You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

Example

candles = [4, 4, 1, 3]

The maximum height candles are  units high. There are  of them, so return .

Function Description

Complete the function birthdayCakeCandles in the editor below.

birthdayCakeCandles has the following parameter(s):

int candles[n]: the candle heights
Returns

int: the number of candles that are tallest
Input Format

The first line contains a single integer, , the size of .
The second line contains  space-separated integers, where each integer  describes the height of .

Constraints

Sample Input 0

4
3 2 1 3
Sample Output 0

2
Explanation 0

Candle heights are . The tallest candles are  units, and there are  of them.
*/

using System.CodeDom.Compiler; // system provided code
using System.Collections.Generic; // system provided code
using System.Collections; // system provided code
using System.ComponentModel; // system provided code
using System.Diagnostics.CodeAnalysis; // system provided code
using System.Globalization; // system provided code
using System.IO; // system provided code
using System.Linq; // system provided code
using System.Reflection; // system provided code
using System.Runtime.Serialization; // system provided code 
using System.Text.RegularExpressions; // system provided code
using System.Text; // system provided code
using System; // system provided code
using Microsoft.VisualBasic;

class Result // system provided code
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

public static int birthdayCakeCandles(List<int> candles) // system provided code
    {
        // This is where we get to play. We have a list of int values. We want to add up the number of times our largest number shows up in the list. First, let's sort this list .
        candles.Sort();
        // now we'll need an intiger value to keep track of our count.
        int count = 0;
        //now, let's go through each number in candles and count the number of them that match the last value, which is now the largest. We will find the largest value by pulling the candles.Count value, then -1 because the first position is a 0.
        foreach (int candle in candles)
        {
            if (candle == candles[candles.Count - 1])
            {
                count++;
            }
        }
        // and now that we've exited our foreach loop, let's return our count for the answer to our problem
        return(count);
    }

}

class Solution // system provided code
{
    public static void Main(string[] args) // system provided code
    { 
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true); // system provided code

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim()); // system provided code

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList(); // system provided code 

        int result = Result.birthdayCakeCandles(candles); // system provided code 

        textWriter.WriteLine(result); // system provided code

        textWriter.Flush(); // system provided code
        textWriter.Close(); // system provided code
    }
}
