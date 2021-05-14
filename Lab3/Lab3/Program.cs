using System;

namespace Lab3
{
    class Human
    {

        protected string firstName;
        protected string surName;
        protected int age;
        protected int weight;

        public Human(string firstName, string surName, int age, int weight)
        {
            this.weight = weight;
            this.age = age;
            this.surName = surName;
            this.firstName = firstName;
        }

    }
    class sportsman : Human
    {
        protected string section;
        protected int time;
        protected bool check1;
        protected int count1 = 0, count2 = 0, v = 0;
        protected bool check2 =false;
        protected bool check3=true;

        public sportsman(string firstName, string surName, string section, int age, int weight, int time, int count1, int count2) :
            base(firstName, surName, age, weight)
        {
            this.section = section;
            this.time = time;
            this.count1 = count1;
            this.count2 = count2;

        }

        public void Information()
        {
            Console.WriteLine($"Фамилия: {surName} \nИмя: {firstName} \nВозраст: {age} \nВес: {weight} " +
                $"\nСекция: {section}\nКоличество побед: {count1}\nКоличество поражений: {count2}");
        }

        public void Workout()
        {
            Console.WriteLine("Вы отправили спортсмена на тренеровку.");
            check1 = true;
            check2 = true;
            check3 = false;
        }

        public void GoHome()
        {
            if (check3)
            {
                if (check1 && check2)
                    Console.WriteLine("Спортсмен пошел домой!");
                else
                {
                    Console.WriteLine("Спортсмен дома");
                    check1 = false;
                }
            }
            else
                Console.WriteLine("Cпортсмен не закончил тренировку"); 
        }

        public void Workout(int time)
        {
            if (time <= 4)
                Console.WriteLine($"Спротсмен будет тренироваться {time} часа.");
            else
                Console.WriteLine($"Спротсмен будет тренироваться {time} часов.");
            check1 = true;
        }

        public void Competitions()
        {
            if (check3)
            {
                Console.WriteLine("Вы отправили спортсмена на соревнования.");
                if (check1)
                {
                    Console.WriteLine("Cпортсмен победил!");
                    count1++;
                }
                else
                {
                    Console.WriteLine("Cпортсмен проиграл!");
                    count2++;
                }
            }
            else
                Console.WriteLine("Cпортсмен не закончил тренировку");
        }

        public void End_of_Trening()
        {
            if (check2)
                Console.WriteLine("Спортсмен закончил тренеровку!");
            else
                Console.WriteLine("Cпортсмен не ходил на тренировку");

            check3 = true;
        }
    }

    class People

    {
        sportsman[] data;
        public People()

        {
            data = new sportsman[6];
        }
        public sportsman this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
    class Program
    {
        static int m = 0, v, c;
        public static void Main(string[] args)
        {       
            var people = new People();
            people[0] = new sportsman("Ivan", "Ivanov", "Бокс", 34, 78, 2, 0, 0);
            people[1] = new sportsman("Petr", "Makaroм", "Бокс", 41, 92, 3, 0, 0);
            people[2] = new sportsman("Artem", "Smolskiy", "Бокс", 25, 60, 2, 0, 0);
            people[3] = new sportsman("John", "Baker", "Борьба", 39, 66, 2, 0, 0);
            people[4] = new sportsman("Joseph", "Howard", "Борьба", 19, 120, 2, 0, 0);
            people[5] = new sportsman("James", "Marshall", "Борьба", 28, 75, 2, 0, 0);
            sportsman Ivan = people[0];
            sportsman Petr = people[1];
            sportsman Artem = people[2];
            sportsman John = people[3];
            sportsman Joseph = people[4];
            sportsman James = people[5];
            bool check = false;
            bool check1 = false;
            bool check2 = false;

            while (!check)
            {
                Console.WriteLine("    \tВыберите секцию\n   1-Бокс   \t2-Борьба");
                try
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    if(c==1 || c==2)
                        check = true;
                    else
                        Console.WriteLine("Введен неверный символ");
                }
                catch
                {
                    Console.WriteLine("Введен неверный символ");
                }
            }

            while (!check1)
            {
                Console.WriteLine("\tВыберите весовую категорию\n1-Легкий вес\t2-Средний вес\t3-Тяжелый вес");

                try
                {
                    v = Convert.ToInt32(Console.ReadLine());
                    if (v == 1 || v == 2 || v==3)
                        check1 = true;
                    else
                        Console.WriteLine("Введен неверный символ");
                }
                catch
                {
                    Console.WriteLine("Введен неверный символ");
                    
                }
            }
            
            Console.WriteLine("\t\t---НАЖМИТЕ---\n1-чтобы получить информацию о спортсмене\n2-отправить спортсмена на сревнования" +
                      "\n3-начать тренеровку\n4-закончить тренеровку\n5-Пойти домой\n6-выйти");
            while (m != 6)
            {
                while (!check2)
                {
                    try
                    {
                        m = Convert.ToInt32(Console.ReadLine());
                        if (m>=1 && m<=6)
                            check2 = true;
                        else
                            Console.WriteLine("Введен неверный символ");
                    }
                    catch
                    {
                        Console.WriteLine("Введен неверный символ");
                        
                    }
                }
                switch (m)
                {
                    case 1:
                        if (v == 1 && c == 1)
                            Artem.Information();
                        if (v == 2 && c == 1)
                            Ivan.Information();
                        if (v == 3 && c == 1)
                            Petr.Information();
                        if (v == 1 && c == 2)
                            John.Information();
                        if (v == 3 && c == 2)
                            Joseph.Information();
                        if (v == 2 && c == 2)
                            James.Information();

                        break;

                    case 2:
                        if (v == 1 && c == 1)
                            Artem.Competitions();
                        if (v == 2 && c == 1)
                            Ivan.Competitions();
                        if (v == 3 && c == 1)
                            Petr.Competitions();
                        if (v == 1 && c == 2)
                            John.Competitions();
                        if (v == 3 && c == 2)
                            Joseph.Competitions();
                        if (v == 2 && c == 2)
                            James.Competitions();
                        break;

                    case 3:
                        if (v == 1 && c == 1)
                        {
                            Artem.Workout();
                            Artem.Workout(2);
                        }
                        if (v == 2 && c == 1)
                        {
                            Ivan.Workout();
                            Ivan.Workout(2);
                        }
                        if (v == 3 && c == 1)
                        {
                            Petr.Workout();
                            Petr.Workout(2);
                        }
                        if (v == 1 && c == 2)
                        {
                            John.Workout();
                            John.Workout(2);
                        }
                        if (v == 3 && c == 2)
                        {
                            Joseph.Workout();
                            Joseph.Workout(2);
                        }
                        if (v == 2 && c == 2)
                        {
                            James.Workout();
                            James.Workout(2);
                        }
                        break;
                    case 4:
                        if (v == 1 && c == 1)
                            Artem.End_of_Trening();
                        if (v == 2 && c == 1)
                            Ivan.End_of_Trening();
                        if (v == 3 && c == 1)
                            Petr.End_of_Trening();
                        if (v == 1 && c == 2)
                            John.End_of_Trening();
                        if (v == 3 && c == 2)
                            Joseph.End_of_Trening();
                        if (v == 2 && c == 2)
                            James.End_of_Trening();
                        break;
                    case 5:
                        if (v == 1 && c == 1)
                            Artem.GoHome();
                        if (v == 2 && c == 1)
                            Ivan.GoHome();
                        if (v == 3 && c == 1)
                            Petr.GoHome();
                        if (v == 1 && c == 2)
                            John.GoHome();
                        if (v == 3 && c == 2)
                            Joseph.GoHome();
                        if (v == 2 && c == 2)
                            James.GoHome();
                        break;
                    default:
                        Console.Clear(); break;
                }
                check2 = false;
            }
        }
    }
}
