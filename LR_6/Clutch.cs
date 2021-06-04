using System;

namespace LR_6
{
    class Program
    {
        static void Main()
        {
            IClutch clutch = new Clutch();
            Console.WriteLine("Выберите машину: ");
            Console.WriteLine("1. MercedesBenz\n2. BMW\n3. Volkswagen\n");
            Car car = null;
            bool stat = true;
            while (stat)
            {
                Console.Write("Ваш выбор: ");
                int carChoice = Convert.ToInt32(Console.ReadLine());

                switch (carChoice)
                {
                    case 1:
                        car = new MercedesBenz();
                        stat = false;
                        break;
                    case 2:
                        car = new BMW();
                        stat = false;
                        break;
                    case 3:
                        car = new Volkswagen();
                        stat = false;
                        break;
                    default:
                        Console.WriteLine("\nВведите действительный номер.");
                        break;
                }
            }

            bool globalCheck = true;
            while (globalCheck)
            {
                Console.WriteLine("\nСписок воозможных действий: ");
                Console.WriteLine("1. Разгон\n2. Движение\n3. Переключить коробку передач\n4. Торможение\n5. Узнать марку\n6. Сравнить машины\n7. Бибикнуть\n8. Выйти из машины");
                Console.Write("\nВыберите действие: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nУкажите желаемое время разгона: ");
                        int time1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Укажите желамое ускорение: ");
                        car.SetAcceleration(Convert.ToInt32(Console.ReadLine()));
                        car.Overclocking(time1);
                        Console.WriteLine("\nРазгон завершен. Текущая скорость: " + car["SStatus"]);
                        Console.WriteLine("Текущие координаты: " + car["CStatus"] + "\n");
                        break;

                    case 2:
                        Console.Write("\nУкажите желаемое время движения: ");
                        int time = Convert.ToInt32(Console.ReadLine());
                        car.Move(time);
                        Console.WriteLine("Движение завершено. Текущие координаты: " + car["CStatus"] + "\n");
                        break;

                    case 3:
                        Console.WriteLine("\nДоступные передачи:\n1. Drive\n2. Parking\n3. Revers");
                        Console.Write("\nВыберите передачу: ");
                        for (; ; )
                        {
                            int transmis = Convert.ToInt32(Console.ReadLine());
                            bool check = false;
                            switch (transmis)
                            {
                                case 1:
                                    clutch.StartDrive(car);
                                    check = true;
                                    break;
                                case 2:
                                    check = true;
                                    clutch.StartPark(car);
                                    break;
                                case 3:
                                    check = true;
                                    clutch.StartRevers(car);
                                    break;
                                default:
                                    Console.WriteLine("Введите действительный номер: ");
                                    break;
                            }

                            if (check)
                                break;
                        }
                        break;

                    case 4:
                        Console.Write("\nУкажите желаемое время торможения: ");
                        int timeB = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Укажите желаемую скорость торможения: ");
                        car.SetBraking(Convert.ToInt32(Console.ReadLine()));
                        car.Braking(timeB);
                        Console.WriteLine("\nТорможение завершено. Текущая скорость: " + car["SStatus"]);
                        Console.WriteLine("Текущие координаты: " + car["CStatus"] + "\n");
                        break;

                    case 5:
                        Console.Write("\nМарка вашего автомобиля: " + car.MkStatus() + "\n\n");
                        break;

                    case 6:
                        if (car.Equals(new MercedesBenz()))
                            Console.WriteLine("\nMercedesBenz: одинаковые");
                        else
                            Console.WriteLine("\nMercedesBenz: разные");

                        if (car.Equals(new BMW()))
                            Console.WriteLine("BMW: одинаковые");
                        else
                            Console.WriteLine("BMW: разные");

                        if (car.Equals(new Volkswagen()))
                            Console.Write("Volkswagen: одинаковые\n");
                        else
                            Console.Write("Volkswagen: разные\n");
                        break;

                    case 7:
                        car.Beep();
                        break;

                    case 8:
                        if (car["SStatus"] != 0)
                        {
                            Console.Write("Я понимаю, что представленный модельный ряд мягко говоря удручает, но все же выходить из машины на ходу - не самая лучшая идея. Хотя кто я такой, чтобы вас судить?");
                            Random alive = new Random();
                            int value = alive.Next(0, 2);
                            if (value == 1)
                                Console.WriteLine("\n\nНу ничего себе. Вспомнив уроки гимнастики времен младшей школы вы сгруппировались и пережили падение, поразив проезжающих мимо.");
                            else if (value == 0)
                                Console.WriteLine("\n\nПриземление прошло довольно неудачно, вы сломали шею. Ну что ж, бывает.");
                        }
                        globalCheck = false;
                        break;

                    default:
                        Console.WriteLine("Такого действия не существует");
                        break;
                }
            }
        }
    }
}