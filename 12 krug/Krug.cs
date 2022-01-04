using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_krug
{
    static class Krug
    {
        static public string GetLength(int R)
        {
                        //return 2 * R * Math.PI;
            double L= 2 * R * Math.PI;
            return "длина окружности S={L}";
        }
        static public double GetSquare(int R)
        {
            return R * R * Math.PI;

        }
        static public string GetPlace(int R, int X, int Y)
        {
            double G = Math.Sqrt(X * X + Y * Y);
            if (G < R)
                return "Точка с координатами X, Y в круге";
            return "Точка с координатами X, Y за кругом";
        }
    }
}
