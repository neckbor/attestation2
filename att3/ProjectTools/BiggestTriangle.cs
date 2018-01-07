using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTools
{
    class BiggestTriangle
    {
        public static bool IsTrianglePossible(Points[] points)
        {
            if (points.Length >= 3)
            {
                return Points.IsPointOnSameLine(points);
            }
            else
                return false;
        }

        //private static bool IsPointOnSameLine(Points[] points)
        //{
        //    double a,
        //           b;

        //    for (int i = 0; i < points.Length - 2; i++)
        //    {
        //        a = (points[i + 1]._Y - points[i]._Y) / (points[i + 1]._X - points[i]._X);
        //        b = points[i]._Y - a * points[i]._X;
        //    }
        //}

    }
}
