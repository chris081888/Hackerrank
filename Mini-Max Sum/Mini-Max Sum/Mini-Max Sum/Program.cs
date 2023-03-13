/**
 * 
 * Sample response for mini-max sum problem posted on hackerrank by Chris Carrutehrs.

Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Example

The minimum sum is  and the maximum sum is . The function prints

16 24
Function Description

Complete the miniMaxSum function in the editor below.

miniMaxSum has the following parameter(s):

arr: an array of integers
Print

Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

Input Format

A single line of five space-separated integers.

Constraints


Output Format

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

Sample Input

1 2 3 4 5
Sample Output

10 14
Explanation

The numbers are , , , , and . Calculate the following sums using four of the five integers:

Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Sum everything except , the sum is .
Hints: Beware of integer overflow! Use 64-bit Integer.

**/

using System.CodeDom.Compiler; //Question provided line
using System.Collections.Generic; //Question provided line
using System.Collections; //Question provided line
using System.ComponentModel; //Question provided line
using System.Diagnostics.CodeAnalysis; //Question provided line
using System.Globalization; //Question provided line
using System.IO; //Question provided line
using System.Linq; //Question provided line
using System.Reflection; //Question provided line
using System.Runtime.Serialization; //Question provided line
using System.Text.RegularExpressions; //Question provided line
using System.Text; //Question provided line
using System; //Question provided line

class Result //Question provided line
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)//Question provided line
    {
        //Ok, this is where we get to play. First, I want to order my array from highest to lowest and get control of what numbers I'm adding together.
        Int64 largest = 0;
        Int64 smallest = 0;
        arr.Sort();
        for (int i = 0; i < Convert.ToInt32(arr.Count) - 1; i++) // We need to make sure we add all but one number together in each loop
        {
            smallest = smallest + Convert.ToInt64(arr[i]); // For the smallest that's all but the last number.
            largest = largest + Convert.ToInt64(arr[i + 1]); // And for the largest number, that skips the first number. Offset + 1
        }
        Console.WriteLine(smallest.ToString() + " " + largest.ToString()); // Then print both values to the console with a space in between.

    }

}

class Solution//Question provided line
{
    public static void Main(string[] args)//Question provided line
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();//Question provided line

        Result.miniMaxSum(arr);//Question provided line
    }
}
