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
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            //this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            //this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            //инициализация dataGridView, добавление начальных свойств
            DataGridViewUtils.InitGridForArr(gridView, 40, false, true, true, true, true);

        }

        private void InpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<List<double>> data = Inp_OutTXT.InpTXT(openFileDialog.FileName);
                    List<double> ls = new List<double>(1);

                    if (Inp_OutTXT.IsArr2Square(data))
                        DataGridViewUtils.ListToGrid<List<double>>(gridView, data);
                        //DataGridViewUtils.ListToGrid<double>(gridView, ls);
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
