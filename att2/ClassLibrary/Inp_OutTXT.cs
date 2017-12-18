using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary
{
    public class Inp_OutTXT
    {
        public static List<List<double>> InpTXT(string fileWay)
        {
            StreamReader lnReader = new StreamReader(fileWay);
            
            //создание двумерного массива на основе файла
            List<List<double>> data = new List<List<double>>();


            string lnTXT = lnReader.ReadLine();


            int i = 0;

            
            while (lnTXT != null)
            {
                List<double> line = new List<double>(StrToList<double>(lnTXT));

                data.Add(line);

                i++;
                lnTXT = lnReader.ReadLine();
 
            }

            //проверка на прямоугольность
            //if (!IsArr2Square(data))
            return data;

        }

        private static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }


        private static T[] StrToList<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        public static bool IsArr2Square(List<List<double>> data)
        {
            int chk = data[0].Count;
            for (int i = 0; i < data.Count(); i++)
                if (data[i].Count != chk)
                    return false;

            return true;
        }
    }
}
