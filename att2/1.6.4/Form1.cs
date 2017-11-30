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
{
    public partial class Block6Task4 : Form
    {
        public Block6Task4()
        {
            InitializeComponent();


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StringModifier revString = new StringModifier(InputText.Text);

            ResultText.Text = revString.StrReverse();
        }
    }
}
