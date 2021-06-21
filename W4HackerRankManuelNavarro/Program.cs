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

    public static void staircase(int n)
    {
        int count = 0;
        int countSpaces = n - 1;
        int countPounds = n - n + 1;

        // do while loop to print the staircase int "n" number of times
        do
        {
            // List created to store staircase increment
            List<string> print = new List<string>();

            // for loop to add spaces to list
            for (int k = 0; k < countSpaces; k++)
            {
                print.Add(" ");
            }

            // for loop to add #'s to list
            for (int l = 0; l < countPounds; l++)
            {
                print.Add("#");
            }

            string result = "";

            // foreach loop to add each string in the list to a single string value
            foreach (string s in print)
            {
                result += s;
            }
            Console.WriteLine(result);

            // spaces decrement counter
            countSpaces--;

            // #'s increment counter
            countPounds++;
            count++;

        } while (count < n);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
