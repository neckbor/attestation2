using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArrayItemsProizv
    {
        private double[] _mas;

        public ArrayItemsProizv(string str)
        {
            this._mas = StrToArray<double>(str);
        }

        private static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }


        private static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        public string ItemsProizv()
        {
            double proizv = 1;

            for (int i = 0; i < this._mas.Length; i++)
                if (i % 2 == 0 && this._mas[i] % 2 == 1)
                    proizv *= this._mas[i];

            if (proizv == 1)
                return "Нет таких элементов";

            else
                return proizv.ToString();
        }

    }
}
