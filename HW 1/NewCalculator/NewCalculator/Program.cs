using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    class Program
    {
        class calculate
        {
            public double first, second, sum;
            char oper;
            public void plus()
            {
                sum = first + second;
                Console.WriteLine(sum + " это сумма этих двух чисел");
            }
            public void minus()
            {
                sum = first - second;
                Console.WriteLine(sum + "  это разница этих двух чисел");
            }
            public void podelit()
            {
                sum = first / second;
                Console.WriteLine(sum + " это деление этих двух чисел");
            }
            public void umnozit()
            {
                sum = first * second;
                Console.WriteLine(sum + "  это умножение этих двух чисел");
            }

            public void Choose()
            {

                Console.WriteLine("Введите оператор  (/  *  +   -)");
                oper = Convert.ToChar(Console.Read());
                if (oper == '+')
                {
                    sum = first + second;
                    Console.WriteLine("Сумма этих двух чисел = " + sum);
                }
                else if (oper == '-')
                {
                    sum = first - second;
                    Console.WriteLine("Разность этих двух чисел = " + sum);
                }
                else if (oper == '*')
                {
                    sum = first * second;
                    Console.WriteLine("Результатом умножения этих двух чисел = " + sum);
                }
                else if (oper == '/')
                {
                    sum = first / second;
                    Console.WriteLine("Результатом деления этих двух чисел = " + sum);
                }
                else Console.WriteLine("Неизвестный оператор.");
            }
        }
        static void Main(string[] args)
        {

                calculate test = new calculate();
                Console.Write("Введите первое число: ");
                test.first = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                test.second = Convert.ToDouble(Console.ReadLine());
                test.plus();
                test.minus();
                test.podelit();
                test.umnozit();
            test.Choose();
            Console.ReadKey();
            

        }
    }
}
