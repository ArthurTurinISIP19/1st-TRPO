using System;

namespace Solve_TRPO__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Х килло конфет стоит У ");
            double n;
            double m;

            double x;
            double a;
            double y;
            double k;

            Console.WriteLine("Ведите кол-во килло.");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите цену за этот вес.");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сколько вам надо конфет.");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сколько хотите потратить.");
            k = Convert.ToDouble(Console.ReadLine());

            m = y/x * a;
            n = k / a * x;
            Console.WriteLine();
            Console.WriteLine("Сколько потратите = " + m);

            Console.WriteLine("Сколько получите = " + n);

            Console.WriteLine("Изменения для GIT");

            Console.WriteLine("2 Изменения для GIT");

            Console.ReadKey();
        }
    }
}
