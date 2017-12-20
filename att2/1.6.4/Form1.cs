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

namespace _1._6._4
/* Раздел 6 номер 4
 4.	Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Вывести строку, содержащую эти же слова (разделенные одним пробелом), но расположенные в обратном порядке. 
 */

    //     ЗАДАЧА РЕШЕНА
{
    public partial class Block6Task4 : Form
    {
        public Block6Task4()
        {
            InitializeComponent();


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StringModifier revString = new StringModifier(InputText.Text);

                ResultText.Text = revString.StrReverse();
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }
    }
}
