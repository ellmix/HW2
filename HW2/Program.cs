using System;

//Задание с авикомпанией
namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] place = { 1, 0, 1, 0, 1, 1, 1, 1, 1, 0 };
            Console.WriteLine("==Авиакомпания==");

            Console.WriteLine("-Список свободных мест: ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Места для курящих: ");
                }
                Console.Write(place[i] + ", ");
                if (i == 4)
                {
                    Console.WriteLine("\nМеста для некурящих: ");
                }

            }

            int choise;
            Console.WriteLine("\n\n1 - выбор места для курящих\n2 - выбор для некурящих");
            int.TryParse(Console.ReadLine(), out choise);

            switch (choise)
            {
                case 1:
                    for (int i = 0; i < 10 && i != 4; i++)
                    {
                        if (place[i] == 5)
                        {
                            Console.WriteLine("Места для курящих закончились.\n-Следущий рейс через 3 часа");
                            break;
                        }
                        if (place[i] == 0)
                        {
                            Console.WriteLine($"Ваше посадочное место №{i + 1}");
                            place[i] = 1;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 5; i < 10; i++)
                    {
                        if (place[i] == 5)
                        {
                            Console.WriteLine("Места для некурящих закончились.\n-Следущий рейс через 3 часа");
                            break;
                        }
                        if (place[i] == 0)
                        {
                            Console.WriteLine($"Ваше посадочное место №{i + 1}");
                            place[i] = 1;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
