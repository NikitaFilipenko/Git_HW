using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, c, v, b, otic, pol, A, B, srednee;
            double price;
            pol = 0;
            otic = 0;
            Debug.Log("Vvedite x: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
                x++;
            else if (x < 0)
                x = x - 2;
            else if (x == 0)
                x = 10;
            Console.WriteLine(x);

            Console.WriteLine("Введите три числа: ");
            Console.Write("Vvedite c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite v: ");
            v = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (c >= 0)
            {
                pol++;
                Console.WriteLine("c polozitelnoe");
            }
            else
            {
                Console.WriteLine("c otricatelnoe");
                otic++;
            }
            if (v >= 0)
            {
                pol++;
                Console.WriteLine("v polozitelnoe");
            }
            else
            {
                otic++;
                Console.WriteLine("v otricatelnoe");
            }
            if (b >= 0)
            {
                pol++;
                Console.WriteLine("b polozitelnoe");
            }
            else
            {
                otic++;
                Console.WriteLine("b otricatelnoe");
            }
            Console.WriteLine("Количество положительных чисел = " + pol);
            Console.WriteLine("Количество отрицательных чисел = " + otic);


            Console.Write("Vvedite A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite B: ");
            B = Convert.ToInt32(Console.ReadLine());
            int l = A;
            int f = B;
            if (A != B)
            {
                A = l + f;
                B = l + f;
            }
            else
            {
                A = 0;
                B = 0;
            }

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            Console.WriteLine("Три числа, которые ты вводил ранее  " + c + "  " + v + "  " + b);
            srednee = (c + v + b) / 3;
            Console.WriteLine("Их среднее " + srednee);

            if (c == srednee)
                Console.WriteLine("Ошибка");
            else if (v == srednee)
                Console.WriteLine("Ошибка");
            else if (b==srednee)
                Console.WriteLine("Ошибка");
            else
                Console.WriteLine("Все ок");

            Console.WriteLine("Введите цену конфет ");
            price = Convert.ToDouble(Console.ReadLine());



            for (double ves = 1; ves <= 2; ves = ves + 0.2)
            {
                Console.WriteLine("Cena knofet za " + ves + "kg: " + price);
                price = price * ves;
            }


                Console.Write("Введите двузначное число: ");
                string s = Console.ReadLine();
                int i = 0, j = 1;
                while (i < s.Length && j < s.Length)
                {
                    if (s[i] == '3' || s[j] == '3')
                    {
                        Console.WriteLine("Число содержит тройку");
                    }
                    else
                    {
                        Console.WriteLine("В числе нет тройки");
                    }
                break;
                    
                }
                
            



                Console.ReadKey();


        }
    }
}
