using System;

namespace LR_5
{
    class BMW : Car
    {
        public BMW()
        {
            Mk = "BMW";
            MaxAcceleration = 5;
            MaxBraking = 2;
            MaxSpeed = 40;
        }

        public override void Beep()
        {
            Console.WriteLine("Би-би-бип. Вы бибикнули.");
        }
    }
}
