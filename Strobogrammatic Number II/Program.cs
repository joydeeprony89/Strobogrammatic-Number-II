using System;
using System.Collections.Generic;

namespace Strobogrammatic_Number_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", FindStrobogrammatic(3)));
        }

        static IList<string> FindStrobogrammatic(int n)
        {
            Dictionary<int, List<string>> hash = new Dictionary<int, List<string>>();
            hash.Add(0, new List<string>() { "" });
            hash.Add(1, new List<string>() { "0", "1", "8" });
            if (n == 0) return hash[1];
            if (n == 1) return hash[1];
            for (int i = 2; i <= n; i++)
            {
                var items = hash[i - 2];
                List<string> list = new List<string>();
                foreach(var item in items)
                {
                    if (i != n)
                        list.Add("0" + item + "0");
                    list.Add("1" + item + "1");
                    list.Add("8" + item + "8");
                    list.Add("6" + item + "6");
                    list.Add("9" + item + "9");
                }
                hash.Add(i, list);
            }
            return hash[n];
        }
    }
}
