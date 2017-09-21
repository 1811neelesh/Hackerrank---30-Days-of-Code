using System;
using System.Collections.Generic;
using System.IO;
class Solution {
        static void Main(String[] args)
           {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int num = Convert.ToInt32(Console.ReadLine());
            int number; string name;
            string[] inp = new string[num];
            Dictionary<string, int> contact = new Dictionary<string, int>();
            for (int i = 0; i < num; i++)
            {
                inp[i] = Console.ReadLine();
            }
            for (int i = 0; i < num; i++)
            {
                name = inp[i].Split(' ')[0];
                number = Convert.ToInt32(inp[i].Split(' ')[1]);
                contact.Add(name, number);
            }
            name = Console.ReadLine();
            while (name != null)
            {
                if(contact.TryGetValue(name, out number))
                {
                    Console.WriteLine("{0}={1}", name, number);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                name = Console.ReadLine();
            }
        
        }
    }
