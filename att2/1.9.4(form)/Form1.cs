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
            try
            {
                List<List<double>> data = new List<List<double>>();

                DataGridViewUtils.ArrayToGrid<double>(gridView, DataProcessing.ListToArray(DataProcessing.ColumEject(DataProcessing.ArrayToList(DataGridViewUtils.GridToArray2<double>(gridView)))));
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            //this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            //this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            //инициализация dataGridView, добавление начальных свойств
            DataGridViewUtils.InitGridForArr(gridView, 40, false, false, false, true, true);

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

                    if (Inp_OutTXT.IsArr2Square(data))
                    {
                       // for (int i = 0; i < data.Count; i++)
                           // DataGridViewUtils.ListToGrid<double>(gridView, data[i]);
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
