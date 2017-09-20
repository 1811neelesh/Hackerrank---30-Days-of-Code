using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string inp = Console.ReadLine();
                char[] inp_array = inp.ToCharArray();
                int len = inp_array.Length;
                for (int j = 0; j < len; j = j+2)
                {
                    Console.Write("{0}", inp_array[j]);
                }
                Console.Write(" ");
                for (int j = 1; j < len; j = j +2)
                {
                    Console.Write("{0}", inp_array[j]);
                }
                Console.WriteLine();
            }
    }
}