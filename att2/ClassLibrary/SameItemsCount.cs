using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SameItemsCount
    {
        private double[] _mas;

        public SameItemsCount (string str)
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

        public string MaxRepeatCount () {

            int maxRep = 1;

            for (int i = 0; i < this._mas.Length; i++)
            {
                int x = RepeatCount(i);

                if (x > maxRep)
                    maxRep = x;

            }

            if (maxRep == 1)
                return "Нет повторяющихся элементов";

            else
                return maxRep.ToString();
            
        }

        private int RepeatCount(int j)
        {
            int count = 0;

            for (int i = 0; i < this._mas.Length; i++)
                if (this._mas[i] == this._mas[j])
                    count++;

            return count;
        }

    }
}
