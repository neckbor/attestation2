﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTools
{
    public class Points
    {
        private double _X;
        private double _Y;
        private double _ind; 

        public Points(double x, double y, int ind)
        {
            _X = x;
            _Y = y;
            _ind = ind;
        }

        public static bool IsPointOnSameLine(Points p1, Points p2,Points p3)
        {
            double a,
                   b;

            a = (p2._Y - p1._Y) / (p2._X - p1._X);
            b = p1._Y - a * p1._X;

            if (p3._Y == a * p3._X + b)
                 return true;

            return false;
        }

        public static string Display_form(Points p1, Points p2, Points p3)
        {
            return p1._ind.ToString() + ", " + p2._ind.ToString() + ", " + p3._ind.ToString();
        }

        public static double Vector(Points p1, Points p2)
        {
            return Math.Sqrt(Math.Pow(p1._X - p2._X, 2) + Math.Pow(p1._Y - p2._Y, 2));
        }
    }
}