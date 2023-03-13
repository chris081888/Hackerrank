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
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(n);

        for (int m = 1; m < 11; m++){
            int s = n * m;
            string a = Convert.ToString(n).Trim();
            string b = Convert.ToString(m).Trim();
            string c = Convert.ToString(s).Trim();
            Console.WriteLine(a + " x " + b +" = " + c);
        }
    }
}
