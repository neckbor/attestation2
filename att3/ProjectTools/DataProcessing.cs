using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTools
{
    public class DataProcessing
    {
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
