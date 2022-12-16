using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_12
{
    public class BankTransaction 
    {
        readonly DateTime data = DateTime.Now;
        readonly decimal summa;

        public string PrintInfo => summa > 0 ? $" Дата:{data} Сумма увеличилась на  {summa}" : $" Дата:{data} Сумма уменьшилась на  {-summa}";

        public BankTransaction(decimal summa)
        {
            this.summa = summa;
        }
        public override string ToString()
        {
            return summa > 0 ? $" Дата:{data} Сумма увеличилась на  {summa}" : $" Дата:{data} Сумма уменьшилась на  {-summa}";
        }
    }
}
