using System;
using System.Collections.Generic; 

namespace IGRA12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random d = new Random();
            int otvet;
            Console.Write("IGRAEM W IGRU");
            Console.WriteLine("Zagadal chislo ot 1 do 10, popitok 100 ");
            int chislo = d.Next(1, 10);
            int i;
            for(i=0; i<100; i++)
            {
                Console.WriteLine("pisci chislo");
                otvet = Convert.ToInt32(Console.ReadLine());
                if(otvet !=chislo)
                {
                    Console.WriteLine("NET!!! XA XA XA XA");
                }
                if(otvet==chislo)
                {
                    Console.WriteLine("NU LADNO UGADAL ZA {0} popitok! chislo={1}!", i, chislo);
                    break;
                }
            }
            

            Console.ReadKey();



        }
        
    } 
   
    

}
