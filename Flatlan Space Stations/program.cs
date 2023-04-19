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

class Solution
{

    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c)
    {
        Array.Sort(c);
        int maxDistance = c[0]; // initialize to distance from first city to first space station
        for (int i = 1; i < c.Length; i++)
        {
            int distance = (c[i] - c[i - 1]) / 2;
            maxDistance = Math.Max(maxDistance, distance);
        }
        maxDistance = Math.Max(maxDistance, n - 1 - c[c.Length - 1]); // check distance from last space station to last city
        return maxDistance;
    }
}

static void Main(string[] args)
{
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    string[] nm = Console.ReadLine().Split(' ');

    int n = Convert.ToInt32(nm[0]);

    int m = Convert.ToInt32(nm[1]);

    int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
    ;
    int result = flatlandSpaceStations(n, c);

    textWriter.WriteLine(result);

    textWriter.Flush();
    textWriter.Close();
}
}
