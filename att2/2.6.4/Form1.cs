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

namespace _2._6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            double x = double.Parse(this.InputTextX.Text);
            int n = int.Parse(this.InputTextN.Text);
            double E = double.Parse(this.InputTextE.Text);

            if ((x > -1) & (x < 1))
            {

                FunctionCalc calc = new FunctionCalc(x);

                string result = "Сумма N слагаемых: " + calc.CalcFunctionWith_N_E(n, 0) + Environment.NewLine;
                result += "Сумма слагаемых, больших заднанного Е: " + calc.CalcFunctionWith_N_E(n, E) + Environment.NewLine;
                result += "Сумма слагаемых, больших заданного Е/10: " + calc.CalcFunctionWith_N_E(n, E / 10) + Environment.NewLine;
                result += "Точное значение функции: " + calc.CalcFunction();

                this.ResultText.Text = result;
            }
            else
            {
                MessageBox.Show("Необходимо ввести значение Х в интервале (-1: 1)!");
                InputTextX.Text = "";

            }

        }
    }
}
