using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
       int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (n >= 1 && n <= 5)
                Console.WriteLine("Not Weird");
            else if (n >= 6 && n <= 20)
                Console.WriteLine("Weird");
            else
                Console.WriteLine("Not Weird");
    }
}
