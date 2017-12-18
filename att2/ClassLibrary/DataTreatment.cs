using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DataTreatment
    {

        public static List<List<double>> ColumEject(List<List<double>> data)
        {
            double[] col = new double[data.Count];

            for (int c = 0; c < data[0].Count; c++)
            {
                for (int r = 0; r < data.Count; r++)
                    col[r] = data[r][c];

                data = SameColDetect(data, col, c);
            }

            return data;
        }

        private static List<List<double>> SameColDetect(List<List<double>> data, double[] col, int i)
        {
            int j = 0;

            for (int c = i; c < data[0].Count; c++)
            {
                for (int r = 0; r < data.Count; r++)
                    if (col[r] == data[r][c])
                        j++;
                    else
                        break;

                if (j == data.Count)
                    data = RemoveSameColums(data, c);
            }

            return data;
        }

        private static List<List<double>> RemoveSameColums(List<List<double>> data, int c)
        {
            for (int r = 0; r < data.Count; r++)
                data[r].RemoveAt(c);


            return data;
        }

    }
}
