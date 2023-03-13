/* By Chris Carruthers. I don't know why I didn't think to save these before. Below is the question from HackerRank.

taircase detail

This is a staircase of size :

   #
  ##
 ###
####
Its base and height are both equal to . It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size .

Function Description

Complete the staircase function in the editor below.

staircase has the following parameter(s):

int n: an integer
Print

Print a staircase as described above.

Input Format

A single integer, , denoting the size of the staircase.

Constraints

 .

Output Format

Print a staircase of size  using # symbols and spaces.

Note: The last line must have  spaces in it.

Sample Input

6 
Sample Output

     #
    ##
   ###
  ####
 #####
######
Explanation

The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of .

*/
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

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n) // system provided code for the question. We're getting called with the int n passed through representing the number of lines we need to print
    {
        for (int i = n; i > 0; i--) // So, we start with i = n, which is the number of lines the user requested. We will need to print 6 total lines, so we'll count down from 6 and start at 0.
        {
            // Before we start our for statement here, ler's 
            for (int j = i-2; j >= 0; j--) // We need a new intiger, because i still exists here. Since we want to print 1 less space than we want to print symbols, so we need to take away 2 (one for the space, one for the last symbol) we will make j = i - 2. If j = 4, the first line will mean we print 3 spaces.
            {
                Console.Write(" "); // print the space without a hardline return.
            }
            for (int j= n - i; j > 0; j--) // For our next loop, we are printing all but the last #. For this, we'll look at n - i, because that would result in 0 and result in all but 1 at the end. And remember, j doesn't exist anymore, because it's for loop ended. We can use it again here.
            {
                Console.Write("#"); // print the # without a hardline return.
            }
            Console.WriteLine("#"); //and now print the last # with a hard return to move to the next line.
        }
    }

}
// Question provided the class Solution. Not supposed to touch it.
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
