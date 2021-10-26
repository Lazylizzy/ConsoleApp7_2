using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double a = Convert.ToInt32(Console.ReadLine());
            double resultS = Area(a);            
            double resultV = V(a);
            Console.WriteLine("Площадь поверхности равна {0}, объем равен {1}", resultS, resultV);
            Console.ReadKey();



        }
        static double Area(double a)
        {
            return 6*Math.Pow(a,2);

        }
        static double V(double a)
        {
            return Math.Pow(a, 3);
        }
    }
    
}
