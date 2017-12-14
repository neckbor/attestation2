using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace _2._7._4
    /* Раздел 7 номер 35
    35.	Вводится массив целых чисел. Найти, какое максимальное количество одинаковых элементов в массиве.
    Например, для массива {1, 2, 7, 12, 2, 7, 2, 3, 4, 5, 12, 7, 8} ответ 3 (3 элемента со значением 2 и 3 элемента со значением 7).
     */
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            SameItemsCount masObj = new SameItemsCount(InputText.Text);

            ResultText.Text = masObj.MaxRepeatCount();
        }
    }
}
