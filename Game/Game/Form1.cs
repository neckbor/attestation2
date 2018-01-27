using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        GameController _controller;

        public Form1(GameController controller)
        {
            InitializeComponent();

            _controller = controller;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameFieldGrid.RowCount = _controller.GetColCount();
            gameFieldGrid.ColumnCount = _controller.GetColCount();
            gameFieldGrid.ReadOnly = true;
            gameFieldGrid.ScrollBars = ScrollBars.None;
            gameFieldGrid.ColumnHeadersVisible = false;
            gameFieldGrid.RowHeadersVisible = false;
            gameFieldGrid.Width = 400;
            gameFieldGrid.Height = 240;
            gameFieldGrid.AllowUserToResizeColumns = false;
            gameFieldGrid.AllowUserToResizeRows = false;

            FieldRefresh();
        }

        private void gameFieldGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _controller.GetCellIndexes(e.RowIndex, e.ColumnIndex);
        }

        public void FieldRefresh()
        {
            GameField.CellColor[,] field = _controller.GetField();
            for (int r = 0; r < _controller.GetRowCount(); r++)
                for (int c = 0; c < _controller.GetColCount(); c++)
                {
                    DataGridViewColumn col = gameFieldGrid.Columns[c];
                    col.Width = 16;
                    DataGridViewRow row = gameFieldGrid.Rows[r];
                    row.Height = 16;

                    if (field[r, c] == GameField.CellColor.BLUE)
                        gameFieldGrid[c, r].Style.BackColor = Color.MidnightBlue;
                    if (field[r, c] == GameField.CellColor.GREEN)
                        gameFieldGrid[c, r].Style.BackColor = Color.ForestGreen;
                    if (field[r, c] == GameField.CellColor.YELLOW)
                        gameFieldGrid[c, r].Style.BackColor = Color.Gold;
                    if (field[r, c] == GameField.CellColor.RED)
                        gameFieldGrid[c, r].Style.BackColor = Color.Crimson;
                    if (field[r, c] == GameField.CellColor.GRAY)
                        gameFieldGrid[c, r].Style.BackColor = Color.Gray;
                    if (field[r, c] == GameField.CellColor.SELECTED)
                    { }
                }
        }
    }
}
