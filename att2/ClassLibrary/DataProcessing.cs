using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DataProcessing
    {
        // выделение 1го столбца из данных
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
        // поиск аналогичного столбца с выделенным
        private static List<List<double>> SameColDetect(List<List<double>> data, double[] col, int i)
        {
            int j = 0;

            for (int c = i + 1; c < data[0].Count; c++)
            {
                for (int r = 0; r < data.Count; r++)
                    if (col[r] == data[r][c])
                        j++;
                    else
                    {
                        j = 0;
                        break;
                    }

                if (j == data.Count)
                    data = RemoveSameColums(data, c);
            }

            return data;
        }
        //удаление повторяещгося столбца
        private static List<List<double>> RemoveSameColums(List<List<double>> data, int c)
        {
            for (int r = 0; r < data.Count; r++)
                data[r].RemoveAt(c);


            return data;
        }
        //преобразование списка списков в массив
        public static double[,] ListToArray(List<List<double>> dataList) 
        {
            int rowCount = dataList.Count,
                colCount = dataList[0].Count;

            double[,] dataArr = new double[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                    dataArr[r, c] = dataList[r][c];

            return dataArr;
        }
        //преобразование двумерногомассива в список списков
        public static List<List<double>> Array2ToList2(double[,] dataArr)
        {
            int rowCount = dataArr.GetLength(0),
                colCount = dataArr.GetLength(1);

            List<List<double>> dataList = new List<List<double>>(rowCount);

            for (int r = 0; r < rowCount; r++)
            {
                List<double> line = new List<double>();

                for (int c = 0; c < colCount; c++)
                    line.Add(dataArr[r, c]);

                dataList.Add(line);
            }
            return dataList;
        }
        //преобразование массива в список 
        public static List<double> ArrayToList(double[] arr)
        {
            List<double> line = new List<double>();

            for (int c = 0; c < arr.Length; c++)
                line.Add(arr[c]);

            return line;
        }
    }
}
