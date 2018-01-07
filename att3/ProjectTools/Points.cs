using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTools
{
    public class Points
    {
        private double _X;
        private double _Y;

        public Points(double x, double y)
        {
            _X = x;
            _Y = y;
        }

        public static bool IsPointOnSameLine(Points[] points)
        {
            double a,
                   b;

            for (int i = 0; i < points.Length - 2; i++)
            {
                a = (points[i + 1]._Y - points[i]._Y) / (points[i + 1]._X - points[i]._X);
                b = points[i]._Y - a * points[i]._X;

                if (points[i + 2]._Y == a * points[i + 2]._X + b)
                    return true;
            }
            return false;
        }
    }
}
