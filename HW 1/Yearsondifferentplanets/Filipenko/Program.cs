using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filipenko
{
    class Program
    {

        static void Main(string[] args)
        {
            char again = 'Y';
            while (again == 'Y')
            {
                double x, y;
                Console.Write("Введите сколько вам полных лет: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сколько прошло с вашего последнего дня рождения: ");
                y = Convert.ToDouble(Console.ReadLine());

                ageofperson test = new ageofperson(x, y);
                test.Choose();
                Console.WriteLine("==================================================================================");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы хотите продолжить работу с программой? (Y/N)");
                Console.ResetColor();
                again = Convert.ToChar(Console.ReadLine());
            }
        }
        
      class ageofperson
            {
            double secoflife;
            public ageofperson(double a, double m)
            {
                secoflife = (a * 365.25 * 86400) + (m * 30 * 86400);
            }

            public void Choose()
            {
                const int V = 86400;
                double x = 30665; // Объясню потом, зачем это сделано
                double y = 60148;
                Console.WriteLine("Выбери планету: ");
                Console.WriteLine("1) Меркурий");
                Console.WriteLine("2) Венера");
                Console.WriteLine("3) Марс");
                Console.WriteLine("4) Юпитер");
                Console.WriteLine("5) Сатурн");
                Console.WriteLine("6) Уран");
                Console.WriteLine("7) Нептун");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                    Console.WriteLine("Если бы ты жил на Меркурии, то сейчас тебе бы было: " + secoflife / (88 * V) + " лет");
                if (c == 2)
                    Console.WriteLine("Если бы ты жил на Венере, то сейчас тебе бы было: " + secoflife / (225 * V) + " лет");
                if (c == 3)
                    Console.WriteLine("Если бы ты жил на Марсе, то сейчас тебе бы было: " + secoflife / (686 * V) + " лет");
                if (c == 4)
                    Console.WriteLine("Если бы ты жил на Юпитере, то сейчас тебе бы было: " + secoflife / (4328 * V) + " лет");
                if (c == 5)
                    Console.WriteLine("Если бы ты жил на Сатурне, то сейчас тебе бы было: " + secoflife / (10748 * V) + " лет");
                if (c == 6)
                    Console.WriteLine("Если бы ты жил на Уране, то сейчас тебе бы было: " + secoflife / (x * V) + " лет");
                if (c == 7)
                    Console.WriteLine("Если бы ты жил на Нептуне, то сейчас тебе бы было: " + (secoflife / (y * V)) + " лет");
                if (c > 7)
                    Console.WriteLine("Увы, но такого варианта нет(404) Перезагрузите программу");
            }
      }
    }
}
