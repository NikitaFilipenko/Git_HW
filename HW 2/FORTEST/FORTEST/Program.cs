using System;

namespace FORTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int plus, minus;
            plus = 0;
            minus = 0;
            int a, b, c;
            Console.Write("Введите значение A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
                plus++;
            else
                minus++;
            if (b >= 0)
                plus++;
            else
                minus++;
            if (c >= 0)
                plus++;
            else
                minus++;

            Console.WriteLine("Количество положительных = " + plus);
            Console.WriteLine("Количество отрицательных = " + minus);



        }
    }
}
