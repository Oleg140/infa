using System;
namespace Slowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();

            string[] words = d.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", words[i]);
            }
            Array.Reverse(words);// слова в words в обратном порядке

            Console.WriteLine("reversed:");

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
