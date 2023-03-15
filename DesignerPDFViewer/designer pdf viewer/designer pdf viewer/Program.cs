// Chris Carruthers, example solution to Designer PDF Viewer on HackerRank. 03/15/2023
// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem?isFullScreen=true

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
     * Complete the 'designerPdfViewer' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h
     *  2. STRING word
     */

    public static int designerPdfViewer(List<int> h, string word)
    {
        //EVERYTHING ABOVE HERE IS PROVIDED BY THE QUESTION
        //Here is where we get to play Not alot to say here because as I kept looking at my code I realized how I could keep condensing it.
        //Now we make a list of our heights
        List<int> heights = new List<int>();
        foreach (char letter in word)
        {
            int index = char.ToUpper(letter) - 65; // Convert the character to it's upper case. This is because the capital character 'A' is = integer value 65. 'B' 66 and so on. We can work with this. We want the index of A to be 0, so -65.   
            heights.Add(h[index]); // we will add the height value in h at the index associated with our letter to our heights list.
        }
        int result = heights.Max() * (word.Length); // So now we have our height * width equation. The word length gets our width. Height is the highest number in the heights list we made.
        Console.WriteLine(result);
        return result;
    }

}
// EVERYTHING UNDER HERE IS CODE FROM THE QUESTION
class Solution
{
    public static void Main(string[] args)
    {

        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

        string word = Console.ReadLine();

        int result = Result.designerPdfViewer(h, word);
    }
}
