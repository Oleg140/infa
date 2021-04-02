using System;
using System.Collections.Generic;
using System.Text;

namespace Permutations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");

            var str = Console.ReadLine();

            var comb = new Combinatorics();
            var numb = 0;

            Console.WriteLine("\nПерестановки:\n");

            foreach (var permutation in comb.Permutation(str))
            {
                Console.WriteLine(permutation);
                numb++;
            }

            Console.WriteLine($"\nОбщее число перестановок: {numb}");
        }
    }

    public class Combinatorics
    {
        public IEnumerable<string> Permutation(string s)
        {
            if (s == string.Empty)
                yield return string.Empty;
            else
            {
                var set = new SortedSet<char>(s);

                foreach (var ch in set)
                {
                    var substring = (new StringBuilder(s).Remove(s.IndexOf(ch), 1)).ToString();
                    foreach (var p in Permutation(substring))
                        yield return ch + p;
                }
            }
        }
    }
}