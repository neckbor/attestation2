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

namespace _1._8._4
    /* Раздел 8 номер 4
    4.	Реализовать функцию:
public List<int> InList1NotInList2(List<int> list1, List<int> list2)
которая вернет список элементов первого списка, которых нет во втором списке (в порядке появления в первом списке). Для удобства реализовать дополнительную функцию:
public int IndexOf(IList<int> list, int value)	,
которую использовать в реализации функции InList1NotInList2.
*/

    //  ЗАДАЧА РЕШЕНА
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ListsComparer lstObj = new ListsComparer(List1Input.Text, List2Input.Text);

                ResultText.Text = ListsComparer.ListToStr<int>(lstObj.InList1NotInList2(), "; ");
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }

        }
    }
}
