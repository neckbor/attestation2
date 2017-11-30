using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StringModifier
    {
        private string _str;

        public StringModifier (string str)
        {
            this._str = str;
        }

        public string StrReverse ()
        {
    
            string word = "",
                   revStr = "";


            while (_str.Contains("  "))
                _str = _str.Replace("  ", " ");


            for (int i = 0; i < _str.Length; i++)

                if (_str[i] == ' ')
                {
                    revStr = word + " " + revStr;

                    word = "";
                }
                else
                    word += _str[i];

            revStr = word + " " + revStr;
 
            return revStr.Trim();
        }
    }

}
