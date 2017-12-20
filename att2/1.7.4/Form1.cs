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

namespace _1._7._4
    /* Раздел 7 номер 4
     4.	Дан массив размера N. Определить произведение нечетных элементов, имеющих четные индексы.
     */
{
    //    ЗАДАЧА РЕШЕНА

    public partial class Task1Block7 : Form
    {
        public Task1Block7()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayItemsProizv arrObj = new ArrayItemsProizv(ArrInput.Text);

                //double[] mas = ArrayItemsProizv.StrToArray<double>(;
                //mas[] = StrToArray<double>(str);

                ResultText.Text = arrObj.ItemsProizv();
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }
    }
}
