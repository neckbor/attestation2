using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DataTreatment
    {

        public static T[,] ListToArr<T>(List<T> data)
        {
            double[,] matrixData = new double[data.Count, data[0].Count];

            for (int r = 0; r < data.Count; r++)
                for (int c = 0; c < data[r].Count; c++)

        }
        public static List<T> ExeptSameColums<T>(List<T> data)
        {
            
            
            return data;
        }

        private int SameColumsDetect<T>(List<T> data)
        {

        }
    }
}
