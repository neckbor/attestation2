using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ListsComparer
    {
        private List<int> _list1 = null;
        private List<int> _list2 = null;


        public ListsComparer(string lst1, string lst2)
        {
            _list1 = new List<int>(StrToList<int>(lst1));
            _list2 = new List<int>(StrToList<int>(lst2));
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

        public List<int> InList1NotInList2()
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < this._list1.Count; i++)
                if (IndexOf(this._list1[i]) == -1)
                    resultList.Add(this._list1[i]);

            if (resultList.Count > 0)
                return resultList;
            else
                return null;
        }

        private int IndexOf(int value)
        {
            int result = -1;

            for (int i = 0; i < this._list2.Count; i++)
                if (this._list2[i] == value)
                    result = i;

            return result;
        }

        public static string ListToStr<T>(IList<T> lst, string separator = ", ")
        {
            return lst == null ? "Нет совпадений" : string.Join(separator, lst);
        }

    }
}
