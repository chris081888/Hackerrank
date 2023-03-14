/* Chris Carruthers 03/13/2023
 * Example Solution to HackerRank problem Grading Students https://www.hackerrank.com/challenges/grading/problem
 * Here's the problem : 
 * HackerLand University has the following grading policy:

Every student receives a  in the inclusive range from  to .
Any  less than  is a failing grade.
Sam is a professor at the university and likes to round each student's  according to these rules:

If the difference between the  and the next multiple of  is less than , round  up to the next multiple of .
If the value of  is less than , no rounding occurs as the result will still be a failing grade.
Examples

 round to  (85 - 84 is less than 3)
 do not round (result is less than 40)
 do not round (60 - 57 is 3 or higher)
Given the initial value of  for each of Sam's  students, write code to automate the rounding process.

Function Description

Complete the function gradingStudents in the editor below.

gradingStudents has the following parameter(s):

int grades[n]: the grades before rounding
Returns

int[n]: the grades after rounding as appropriate
Input Format

The first line contains a single integer, , the number of students.
Each line  of the  subsequent lines contains a single integer, .

Constraints

Sample Input 0

4
73
67
38
33
Sample Output 0

75
67
40
33
Explanation 0

image

Student  received a , and the next multiple of  from  is . Since , the student's grade is rounded to .
Student  received a , and the next multiple of  from  is . Since , the grade will not be modified and the student's final grade is .
Student  received a , and the next multiple of  from  is . Since , the student's grade will be rounded to .
Student  received a grade below , so the grade will not be modified and the student's final grade is .
 */

using System.CodeDom.Compiler; //question provided code
using System.Collections.Generic; //question provided code
using System.Collections; //question provided code
using System.ComponentModel; //question provided code
using System.Diagnostics.CodeAnalysis; //question provided code
using System.Globalization; //question provided code
using System.IO; //question provided code
using System.Linq; //question provided code
using System.Reflection; //question provided code
using System.Runtime.Serialization; //question provided code
using System.Text.RegularExpressions; //question provided code
using System.Text; //question provided code
using System; //question provided code

class Result //question provided code
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades) //question provided code
    {
        /*his is where we get to play.
         * The important part to remember right now is the basics of what we're doing, and what the expected input to our function looks like. Remember, we're creating a function gradingStudents that will receive a List of integers,
         * needs to return a List of rounded integers, and remember that we have rounding rules to follow as described below to keep clarity and fill in any numbers that were really images on the website.
         * 
         * If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
         * If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
         * 
         * So, Unless the number is less than 38: (Any number that ends with a 3, or 4 add 5 minus the number to the grade bring it to 5. And any number that ends with an 8 or 9 add 10 minus the number to the grade to round it up to the nearest 10.
         */
        List<int> finalGrade = new List<int>(); // First, let's create a list called finalGrade so we have a list to return.
        foreach (int grade in grades) // Now we'll iterate through each integer in grades and temporarily save them as the integer value grade as long as we're in the foreach loop.
        {
            if (grade < 38) // if the grade is less than 38 just add the grade into final grade without changing anything.
            {
                finalGrade.Add(grade);
            }
            else if ((grade % 5) > 2) // next, if the grade divided by 5 has a remainder of less than 2 (which covers our 5s and 10s for rounding), round up by
            {
                int tempgrade = grade + (5 - (grade % 5)); // taking the grade, then adding in grade - 5 to round it up to the closest 5.
                finalGrade.Add(tempgrade);
            }
            else
            {
                finalGrade.Add(grade); // just as an exit condition, let's add any grades to the list that don't fit the description above. When it returns a wrong value we can look to see why.
            }
        }
        return finalGrade; // return our list finalGrade to the program that asked for it
    }
}

class Solution //question provided code
{
    public static void Main(string[] args) //question provided code
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true); //question provided code

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim()); //question provided code

        List<int> grades = new List<int>(); //question provided code

        for (int i = 0; i < gradesCount; i++) //question provided code
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());//question provided code
            grades.Add(gradesItem); //question provided code
        }

        List<int> result = Result.gradingStudents(grades); //question provided code

        textWriter.WriteLine(String.Join("\n", result)); //question provided code

        textWriter.Flush(); //question provided code
        textWriter.Close(); //question provided code
    }
}
