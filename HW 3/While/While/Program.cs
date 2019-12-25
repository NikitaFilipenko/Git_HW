using System;
using UnityEngine;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {

            int summ = 0;
            for (int m = 1; m <= 50; m += 2)
                summ += m;

            Console.WriteLine($"Сумма положительных нечетных чисел, меньших 50: {summ}");




            Console.WriteLine("2. Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            if (a < 0 && b < 0 || a > b)
            {
                Console.WriteLine("0");
                return;
            }
            var sum = 0;
            for (int i = a < 0 ? 1 : a; i <= b; i++)
            {
                sum += i % 4 == 0 ? i : 0;
            }
            Console.WriteLine(sum);

            Console.WriteLine("3. Найти: а) все двузначные числа, сумма квадратов цифр которых делится на 13; б) все двузначные числа, обладающие следующим свойством: если к сумме цифр числа прибавить квадрат этой суммы, то получится снова искомое число.");
            for (int i = 1; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if ((i * i + j * j) % 13 == 0) Console.WriteLine($"{i * 10 + j} - a");
                    if (i + j + (i + j) * (i + j) == i * 10 + j) Console.WriteLine($"{i * 10 + j} - b");
                }


            Console.WriteLine("5. Даны два целых числа A и B (A < B). Найти сумму и произведение всех целых чисел от A до B включительно.");
            int suma = 0;
            int proiz = 1;
            Console.WriteLine("Введите первое число: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int g = Convert.ToInt32(Console.ReadLine());
            for (int i = f; i < g + 1; i++)
            {
                suma += i;
            }
            Console.WriteLine("Сумма чисел от A до B: " + suma);

            for (int i = f; i < g + 1; i++)
            {
                proiz *= i;
            }
            Console.WriteLine("Сумма произведения от A до B: " + proiz);


            Console.WriteLine("6. Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, расположенные между A и B (включая сами числа A и B),  а также количество этих чисел.");
            int A = f, B = g, k = 0;
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i.ToString());
                k++;
            }
            Console.WriteLine("Количество: " + k.ToString());
            Console.ReadLine();




            double price = 5d;
            Console.WriteLine($"Стоимость одного килограмма конфет составляет {price} рублей.\n");

            for (double i = 1.1; i <= 2.0; i += 0.1)
            {
                Console.WriteLine($"Цена за {Math.Round(i, 1)} кг: {price * Math.Round(i, 1)} руб");
            }



            Console.WriteLine("8. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).");
            int t = f, y = g;

            for (int i = t; i <= y; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
}
