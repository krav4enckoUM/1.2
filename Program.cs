using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 daysLeft = 0, daysToYearEnd;
            string date;
            DateTime dt;

            Console.Write("Введите день, месяц, год : ");
            date = Console.ReadLine();

            if (DateTime.TryParse(date, out dt)) //Если дата коррректная, то она записывается в dt
            {
                Console.WriteLine("Корректная дата");

                for (int i = 1; i <= dt.Month - 1; i++) //Прогоняем все месяцы от первого до предшествующего текущему
                {
                    daysLeft += DateTime.DaysInMonth(dt.Year, i); //Узнаем кол-во дней в этом месяце и прибавляем к счетчику
                }
                daysLeft += dt.Day; // Прибавляем к счетчику кол-во дней в текущем месяце
                Console.WriteLine("С начала года прошло {0} дней.", daysLeft.ToString());

               
               
                {
                    daysToYearEnd = 365 - daysLeft;
                }
                Console.WriteLine("До конца года осталось {0} дней.", daysToYearEnd.ToString());
            }

            else //Если дата некорректная
            {
                Console.WriteLine("Не корректная дата");
            }

            Console.ReadKey();
        }
    }
}

