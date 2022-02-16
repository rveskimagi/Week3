using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma tulemus.");
            string userResult = Console.ReadLine().ToLower();

            switch (userResult)
            {
                case "A":
                    Console.WriteLine("Suurepärane.");
                    break;

                case "B":
                    Console.WriteLine("Väga hea.");
                    break;

                case "C":
                    Console.WriteLine("Hea.");
                    break;

                case "D":
                    Console.WriteLine("Rahuldav.");
                    break;

                case "E":
                    Console.WriteLine("Kasin.");
                    break;

                case "F":
                    Console.WriteLine("Puudulik.");
                    break;

                default:
                    Console.WriteLine("Vale väärtus.");
                    break;

            }

        }
    }
}


