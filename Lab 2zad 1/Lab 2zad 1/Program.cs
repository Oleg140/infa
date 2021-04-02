using System;

namespace Lab_2zad_1
{
    class Program
    {
        static void FindNonEnglish(String s)
        {
            foreach (char c in s)
            {
                if (char.IsUpper(c) && (c > 90))
                {
                    Console.WriteLine(c);
                }
            }
        }
        static void Main(string[] args)
        {
            String s;
            Console.WriteLine("Enter the line:");
            s = Console.ReadLine();
            FindNonEnglish(s);
        }
    }
}
