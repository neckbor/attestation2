using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTools
{
    public class BiggestTriangle
    {
        //проверяю, возможно ли из этих данных вообще построить треугольник
        public static bool IsTrianglePossible(Points[] points)
        {
            if (points.Length >= 3)
            {
                for (int i = 0; i < points.Length - 2; i++)
                    if (Points.IsPointOnSameLine(points[i], points[i + 1], points[i + 2]))
                        return true;
            }
            else
                return false;

            return false;
        }
        //перебор точек и прверка на самую большую площадь
        public static string MaxTriangleSquare(Points[] points)
        {
            double maxS = 0;
            string result = "";

            //циклов так много чтобы прям все варианты сочетания точек перебрать (при этом ещё точки в разном порядке получаются(шоб уж наверняка))
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = 0; p2 < points.Length; p2++)
                    for (int p3 = 0; p3 < points.Length; p3++)
                        if (p1 != p2 && p1 != p3 && p2 != p3)
                            if (Square(points[p1], points[p2], points[p3]) > maxS)
                                result = Points.Display(points[p1], points[p2], points[p3]);
            return result;     
        }
        //нахождение площади
        private static double Square(Points p1, Points p2, Points p3)
        {
            double a = Points.Vector(p1, p2),
                   b = Points.Vector(p2, p3),
                   c = Points.Vector(p1, p3),
                   p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


    }
}
