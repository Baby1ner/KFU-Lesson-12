using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_12
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1");
            Bank bank1 = new Bank("azat", 100000, Bank.tip.saving);
            Console.WriteLine(bank1.GetId);
            Console.WriteLine(bank1.GetTyp);
            Console.WriteLine(bank1.GetBalans);
            Console.WriteLine(bank1.holder);


            Console.WriteLine("Задание 2");
            Bank bank = new Bank("azat", 100000, Bank.tip.current);
            bank.Takeon();
            bank.Takeoff();
            Console.WriteLine(bank[0].ToString());
            
            Console.WriteLine("Домашнее задание 1");
            House house = new House(100, 5, 300, 5);
            Console.WriteLine(house.Poarch);
            Console.WriteLine(house.Height);
            house.flatinf();

            Console.WriteLine("Домашнее задание 2");
            House[] housessss =
            {
                new House(100, 5, 350, 5),
                new House(130, 4, 430, 7),
                new House(123, 5, 235, 4),
                new House(142, 2, 540, 9),
                new House(123, 5, 120, 1),
                new House(234, 6, 420, 2),
                new House(532, 5, 120, 3),
                new House(123, 8, 430, 4),
                new House(421, 5, 560, 5),
                new House(321, 9, 780, 5),
            };
            Houses houses = new Houses(housessss);
            houses[4].Print();
            houses[2].Print();
            houses[7].Print();
            Console.ReadLine();
        }
    }
}
