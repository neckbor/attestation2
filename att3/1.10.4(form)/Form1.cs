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



    //ЗАДАЧА РЕШЕНА



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //инициализация dataGridView, добавление начальных свойств
            DataGridViewUtils.InitGridForArr(gridView, 30, false, true, true, true, false, 30, 8);

        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OutputLbl.Text = "";

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

        private void runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OutputLbl.Text = "";
               //данные из грида
                double[,] data = DataGridViewUtils.GridToArray2<double>(gridView);
                
               //заполняем данными из грида массив точек  
                Points[] points = new Points[data.GetLength(0)];
                for (int r = 0; r < data.GetLength(0); r++)
                {
                    Points pnt = new Points(data[r, 0], data[r, 1], r + 1);
                    points[r] = pnt;
                }

                if (BiggestTriangle.IsTrianglePossible(points))
                {
                    OutputLbl.Text = "Самый треугольник получается из точек: " + BiggestTriangle.MaxTriangleSquare(points);
                }
                else
                    MessageBsc.ShowError("Из таких точек невозможно построить треугольник");
            }

            catch (Exception exc)
            {
                MessageBsc.ShowError(exc.Message);
            }
        }
    }
}
