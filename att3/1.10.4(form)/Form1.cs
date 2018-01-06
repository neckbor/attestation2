using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTools;


namespace _1._10._4_form_
{
    /*4.	Для набора точек на плоскости найти такие три точки,
     для которых площадь треугольника с вершинами в данных точках будет максимальна.
     В случае существования нескольких подходящих троек точек – выбрать произвольную. */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //инициализация dataGridView, добавление начальных свойств
            DataGridViewUtils.InitGridForArr(gridView, 30, true, true, true, true, false);

        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + Inp_Out.GetDataDirectiry());

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<List<double>> data = Inp_Out.InpTXT(openFileDialog.FileName);

                        DataGridViewUtils.ArrayToGrid<double>(gridView, DataProcessing.ListToArray(data));

                }
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }
    }
}
