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
            DataGridView dgv = new DataGridView();


        }

        private void InpBtn_Click(object sender, EventArgs e)
        {
                
        }

        // Запись данных из массива (одномерного или двухмерного) в DataGridView
        // (основная реализация, закрытый метод, используется в ArrayToGrid и Array2ToGrid)
        private static void ArrayToGridInner<T>(DataGridView dgv, Array data)
        {
            // выравнивание (если T == int - по правому краю, иначе - по-умолчанию)
            dgv.DefaultCellStyle.Alignment =
                typeof(T) == typeof(int) ? DataGridViewContentAlignment.MiddleRight : dgv.DefaultCellStyle.Alignment;

            int rowCount = data.Rank == 1 ? 1 : data.GetLength(0),
                colCount = data.Rank == 1 ? data.GetLength(0) : data.GetLength(1);

            DataGridViewSelectionMode originalSelectionMode = dgv.SelectionMode;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.RowCount = rowCount;
            dgv.ColumnCount = colCount;
            dgv.SelectionMode = originalSelectionMode;

            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                    dgv[c, r].Value = data.Rank == 1 ? data.GetValue(c) : data.GetValue(r, c);
        }

        // Запись данных из списка в DataGridView
        public static void ListToGrid<T>(DataGridView dgv, IList<T> data)
        {
            ArrayToGridInner<T>(dgv, data.ToArray());
        }

        // Выполняется при чтении данных из файла через меню
        private void MainMenuFileOpen_Click(object sender, EventArgs ev)
        {
            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Читаем содержимое выбранного файла и преобразуем его в массив
                    string arrText = FilesUtils.Read(LoadFileDialog.FileName);
                    int[,] arr = DataConverter.StrToArray2D<int>(arrText);

                    // Копируем полученный массив в DataGridView
                    DataGridViewUtils.Array2ToGrid(inputGridView, arr);

                    MessagesUtils.Show("Данные загружены");
                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка загрузки данных");
                }
            }
        }

        // Выполняется при сохранении данных в файл через меню
        private void MainMenuFileSave_Click(object sender, EventArgs ev)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Преобразуем содержимое DataGridView в массив
                    int[,] arr = DataGridViewUtils.GridToArray2<int>(outputGridView);

                    // Записываем полученный массив в файл, предварительно
                    // преобразовав его в строку
                    FilesUtils.Write(SaveFileDialog.FileName, DataConverter.Array2DToStr<int>(arr));

                    MessagesUtils.Show("Данные сохранены");
                }
                catch (Exception e)
                {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }
        }

        // Выполняется при закрытии приложения через меню
        private void MainMenuFileClose_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }

    }
}
