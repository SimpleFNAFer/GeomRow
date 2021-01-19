using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomRow
{
    class Program
    {
        static private int n;
        static private int x1;
        static private int x2;
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во членов последовательности: \nn = ");

            n = int.Parse(Console.ReadLine());
            x1 = 0;
            x2 = 0;
            for (int i = 0; i < n; i++)
            {
                x1 += (int)Math.Pow(2, i);
            }
            Console.Write("\nСумма геометрической последовательности (через цикл) = " + x1.ToString());
            x2 = (int)Math.Pow(2, n)-1;
            Console.Write("\nСумма геометрической последовательности (через формулу) = " + x2.ToString());

            Console.ReadLine();
        }
    }
}
