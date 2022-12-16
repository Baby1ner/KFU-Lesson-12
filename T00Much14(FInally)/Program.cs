using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much14_FInally_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /
            Console.WriteLine("Задание 1");
            Bank bank = new Bank("Azat",10000, Bank.tip.saving);
            bank.DumpToScreen();
            

            Console.WriteLine("Задание 2");
            System.Reflection.MemberInfo inf;
            inf = typeof(RationalDigits);
            object[] arr = inf.GetCustomAttributes(false);
            foreach (object i in arr) 
            {
                DeveloperInfoAttribute a = (DeveloperInfoAttribute)i;
                Console.WriteLine($"Разработчик :{a.Name} \n Время:{DateTime.Parse(a.datereliz)}");
            }
            
            System.Reflection.MemberInfo inf1;
            inf1 = typeof(Bank);
            object[] arr1 = inf1.GetCustomAttributes(false);
            foreach (object i in arr1) 
            {
                NameOrgAtribute a = (NameOrgAtribute)i;
                Console.WriteLine($"Разработчик :{a.Name} \n Организация:{a.Organization}");
            }


            Console.ReadKey();


        }
    }
}
