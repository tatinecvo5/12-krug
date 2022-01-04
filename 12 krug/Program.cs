using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите радиус круга R=");
            int R = Convert.ToInt32(Console.ReadLine());
            //double L = 2 * R * Math.PI;
            /*double S = R * R * Math.PI;
                        Console.WriteLine("длина окружности L={0:f3}", 2 * R * Math.PI);
            Console.WriteLine("длина окружности S={0:f3}", S);*/
            Console.Write("введите координату X=");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите координату Y=");
            int Y = Convert.ToInt32(Console.ReadLine());
            /*double G = Math.Sqrt(X * X + Y * Y);
            if (G < R)
            {
                Console.Write("Точка с координатами X, Y в круге");
            }
            else
                if (G > R)
            {
                Console.Write("Точка с координатами X, Y за кругом");
            }
            else
            {
                Console.Write("Точка с координатами X, Y на окружности");
            }
            Console.ReadKey();*/
            string length = Krug.GetLength(R);
            double square = Krug.GetSquare(R);
            string place = Krug.GetPlace(R,X,Y);
                        Console.WriteLine($"{length:f3} \n{square:f3} \n{place}");
            Console.ReadKey();
        }
    }
}
