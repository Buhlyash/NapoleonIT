using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string replace_str = Console.ReadLine();
            int Left_bracket = str.IndexOf('[');
            int Right_bracket = 0;
            int j = 0;
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '[' && Right_bracket == 0) j++;
                if (str[i] == ']') k++;
                if (j == k)
                {
                    Right_bracket = i;
                    break;
                }
            }
            string old_str = str.Substring(Left_bracket, Right_bracket+1);
            string new_str = str.Replace(old_str, replace_str);
            Console.WriteLine($"Новая строка: {new_str}");
            
        }
    }
}
