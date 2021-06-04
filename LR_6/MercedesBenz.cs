using System;

namespace LR_6
{
    class MercedesBenz : Car
    {
        public MercedesBenz()
        {
            Mk = "MercedesBenz";
            MaxAcceleration = 5;
            MaxSpeed = 45;
            MaxBraking = 2;
        }

        public override void Beep()
        {
            Console.WriteLine("Бип-би-бип. Вы бибикнули.");
        }
    }
}