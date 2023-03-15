/* Chris Carruthers
 * 03/15/2023
 * example solution for https://www.hackerrank.com/challenges/halloween-sale/problem*/

using System.CodeDom.Compiler; // question provided code
using System.Collections.Generic; // question provided code
using System.Collections; // question provided code
using System.ComponentModel; // question provided code
using System.Diagnostics.CodeAnalysis; // question provided code
using System.Globalization; // question provided code
using System.IO; // question provided code
using System.Linq; // question provided code
using System.Reflection; // question provided code
using System.Runtime.Serialization; // question provided code
using System.Text.RegularExpressions; // question provided code
using System.Text; // question provided code
using System; // question provided code
using System.Runtime.InteropServices;

class Result
{

    /*
     * Complete the 'howManyGames' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER d
     *  3. INTEGER m
     *  4. INTEGER s
     */

    public static int howManyGames(int p, int d, int m, int s) // question provided code
    {
        // Return the number of games you can buy
        /* This is where we get to play
         * We get an input of p (starting number), d (reduction of p each iteration), m(the lowest p can go), and s which is your total money.
         */
        int result = 0;
        for (int i = p; i < s; i = i-d)
        {
            if (i <= m)
            {
                s = s-m;
                result++;
            }
            else
            {
                s = s-i;
                result++;
            }
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args) // question provided code
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true); // question provided code

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' '); // question provided code

        int p = Convert.ToInt32(firstMultipleInput[0]); // question provided code

        int d = Convert.ToInt32(firstMultipleInput[1]); // question provided code 

        int m = Convert.ToInt32(firstMultipleInput[2]); // question provided code

        int s = Convert.ToInt32(firstMultipleInput[3]); // question provided code

        int answer = Result.howManyGames(p, d, m, s); // question provided code

        textWriter.WriteLine(answer); // question provided code

        textWriter.Flush(); // question provided code
        textWriter.Close(); // question provided code
    } 
}
