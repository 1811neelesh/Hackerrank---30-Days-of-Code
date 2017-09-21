using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
 static int factorial(int n)
    {
        // Complete this function
        int result = 1;
        for (int i = 0; i < n; i++)
        {
            result = n * factorial(n - 1);
        }
        return result;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int result = factorial(n);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
