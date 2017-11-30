using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FunctionCalc
    {
        private double _x;

        public FunctionCalc(double x)
        {
            this._x = x;
        }

        public double CalcFunction()
        {
            return Math.Atan(_x);
        }

        public double CalcFunctionWith_N_E(int n, double e)
        {
            double sum = 0,
                   term = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                term = Math.Pow(_x, 2 * i + 1) / (2 * i + 1);

                if (Math.Abs(term) > e)
                    if (i % 2 == 0)
                        sum += -term;

                    else
                        sum += term;
            }

            return sum;
        }
    }

}
