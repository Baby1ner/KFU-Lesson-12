using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much14_FInally_
{
    [NameOrgAtribute("Azat", "KFU")]
    public class Bank
    {
        public enum tip
        {
            current,
            saving
        }
        private string Holder;
        private int Id = 0;
        private int Balans;
        private tip Type = tip.current;
        private static int Idk;
        private Queue<BankTransaction> queue = new Queue<BankTransaction>();

        public BankTransaction this[int index] => queue.ToArray()[index];


        public Bank(tip Type)
        {
            Idk++;
            Id = Idk;
            this.Type = Type;
        }
        public Bank(string Holder, int Balans, tip Type)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
            this.Type = Type;
            this.Holder = Holder;
        }

        public Bank(int Balans, tip Type)
        {
            Idk++;
            Id = Idk;
            this.Balans = Balans;
            this.Type = Type;
        }



        public string PrintID => $"Создан новый счет в банке, его номер:{Id}";
        public int GetBalans => Balans;
        public int GetId => Id;
        public tip GetTyp => Type;
        public string holder
        {
            get => Holder;
            set => Holder = value;
        }



        public void Takeoff()
        {
            Console.WriteLine("Введите сумму, которую хотите снять");
            int off = int.Parse(Console.ReadLine());
            BankTransaction bankTransaction = new BankTransaction(-off);

            if (Balans > off)
            {
                Balans -= off;
                queue.Enqueue(bankTransaction);
            }
            else
            {
                Console.WriteLine("Неправильно попробуй еще раз");
                Takeoff();
            }
        }
        public void Takeon()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int on = int.Parse(Console.ReadLine());
            BankTransaction bankTransaction = new BankTransaction(on);
            queue.Enqueue(bankTransaction);
            Balans += on;
        }
        public void transfer(Bank Bank, int sum)
        {
            if (Balans > sum)
            {
                BankTransaction bankTransaction = new BankTransaction(-sum);
                BankTransaction bankTransaction2 = new BankTransaction(sum);

                queue.Enqueue(bankTransaction);
                Balans -= sum;
                Bank.Balans += sum;
                Bank.queue.Enqueue(bankTransaction2);
            }
            else Console.WriteLine("Не хватает денег для перевода");
        }
        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
        public void PrintMoneySell()
        {
            foreach (BankTransaction item in queue)
                Console.WriteLine(item.PrintInfo);

        }

        [Conditional("DEBUG")]
        public void DumpToScreen()
        {
            Console.WriteLine($"{Holder}, {Balans}, {Type},");
        }

    }
}
