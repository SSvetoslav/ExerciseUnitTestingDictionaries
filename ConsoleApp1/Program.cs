using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>() { "aaa$%^&", "adgag^&", "6875gm," };

            Dictionary<char, int> charCount = input.SelectMany(s => s).GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

            StringBuilder sb = new StringBuilder() ;
            foreach (KeyValuePair<char, int> pair in charCount)
            {
                sb.AppendLine($"{pair.Key} -> {pair.Value}");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
