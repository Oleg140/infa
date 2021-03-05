using System;

namespace IGRA12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random d = new Random();
            int answer;
            Console.Write("playing the game");
            Console.WriteLine("I made a number from 1 to 10, 100 attempts ");
            int number = d.Next(1, 10);
            int i;
            for(i=0; i<100; i++)
            {
                Console.WriteLine("choose a number");
                answer = Convert.ToInt32(Console.ReadLine());
                if(answer != number)
                {
                    Console.WriteLine("No!!! XA XA XA XA");
                }
                if(answer == number)
                {
                    Console.WriteLine("Well done, you guessed it, {0} popitok! number={1}!", i, number);
                    break;
                }
            }
            Console.ReadKey();



        }
        
    } 
   
    

}
