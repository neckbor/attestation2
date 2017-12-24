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

namespace _1._9._4_form_
    /*Раздел 9 номер 4
    4.	Создать новый двумерный массив, исключив из переданного массива совпадающие столбцы. 
    (Совпадающие столбцы – столбцы, у которых все соответствующие элементы равны друз другу).
    При формировании нового массива оставить только первый из каждого набора совпадающих столбцов.
     */
    // ЗАДАЧА РЕШЕНА

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
                DataGridViewUtils.ArrayToGrid<double>(gridView, DataProcessing.ListToArray(DataProcessing.ColumEject(DataProcessing.Array2ToList2(DataGridViewUtils.GridToArray2<double>(gridView)))));
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //инициализация dataGridView, добавление начальных свойств
            DataGridViewUtils.InitGridForArr(gridView, 40, false, false, false, false, false);
        }

        private void InpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + Inp_Out.GetDataDirectiry());

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<List<double>> data = Inp_Out.InpTXT(openFileDialog.FileName);

                    if (Inp_Out.IsArr2Square(data))
                    {
                        DataGridViewUtils.ArrayToGrid<double>(gridView, DataProcessing.ListToArray(data)); 
                    }
                    else
                        MessageBsc.Show("Данные не являются прямоугольным массивом");
                }
                }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }


    }
}
