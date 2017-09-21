using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int num = Convert.ToInt32(Console.ReadLine());
            int binary_num = 0;
            int remainder = 0;
            int base_num = 1;
            List<int> num_list = new List<int>();
            while (num > 0)
            {
                remainder = num % 2;
                binary_num = binary_num + remainder * base_num;
                base_num = base_num * 10;
                num = num / 2;
                num_list.Add(remainder);
            }
            int[] num_array = num_list.ToArray();
            int len = num_array.Length;
            int count = 1;
            List<int> one_list = new List<int>();
            for (int i = 0; i < len-1; i++)
            {
                if ((num_array[i] == 1) && (num_array[i + 1] == 1))
                {
                    count++;
                    one_list.Add(count);
                }
                else if (num_array[i] == 0)
                {
                    count = 1;
                }
            }
            count = one_list.Max();
            Console.WriteLine(count);
            Console.ReadLine();
    }
}
