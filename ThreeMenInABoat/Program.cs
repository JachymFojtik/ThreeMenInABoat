using System;
using System.Collections.Generic;
using System.IO;

namespace ThreeMenInABoat
{
    class Program
    {
        static Dictionary<string, List<int>> register = new Dictionary<string, List<int>>();
        static void Main(string[] args)
        {
            string file = File.ReadAllText("ThreeMenInABoat.txt");
            string[] f = file.Split(' ');
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i].Contains(' '))
                {
                    continue;
                }
                if (register.ContainsKey(f[i]))
                {
                    register[f[i]].Add(i + 1);
                    continue;
                }
                else 
                {
                    List<int> counter = new List<int>();
                    counter.Add(i);
                    register.Add(f[i],counter);
                }
            }
            string res = "";
            foreach (var item in register)
            {
                res += $"{item.Key} - ";
                foreach (int pos in item.Value)
                {
                    res += $"{pos} ,";
                }
                res += "\n";

            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
