using System;

namespace LR_6
{
    class Volkswagen : Car
    {
        public Volkswagen()
        {
            MaxSpeed = 35;
            MaxAcceleration = 3;
            MaxBraking = 2;
            Mk = "Volkswagen";
        }

        public override void Beep()
        {
            Console.WriteLine("Би-бииип. Вы бибикнули.");
        }
    }
}