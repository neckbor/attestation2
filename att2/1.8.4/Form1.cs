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
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ListsComparer lstObj = new ListsComparer (List1Input.Text, List2Input.Text);

            ResultText.Text = ListsComparer.ListToStr<int>(lstObj.InList1NotInList2(), "; ");
        }
    }
}
