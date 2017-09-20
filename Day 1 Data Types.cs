using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        // Declare second integer, double, and String variables.
        int i1 = int.Parse(Console.ReadLine());
        double d1 = double.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        // Read and save an integer, double, and String to your variables.
        i = i+i1;
        d = d+d1;
        s = s+s1;
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i);
        // Print the sum of the double variables on a new line.
         Console.WriteLine(String.Format("{0:0.0}",d));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s);
        // The 's' variable above should be printed first.
	}
}