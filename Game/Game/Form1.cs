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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataGridViewUtils.InitGridForArr(gameFieldGrid, 25, false, false, false, false, false);
            gameFieldGrid.RowCount = GameField.rowCount;
            gameFieldGrid.ColumnCount = GameField.colCount;
            gameFieldGrid.ReadOnly = true;
            gameFieldGrid.ScrollBars = ScrollBars.None;
            gameFieldGrid.ColumnHeadersVisible = false;
            gameFieldGrid.RowHeadersVisible = false;
            gameFieldGrid.Width = 400;
            gameFieldGrid.Height = 240;
            gameFieldGrid.AllowUserToResizeColumns = false;
            gameFieldGrid.AllowUserToResizeRows = false;


            GameField.Fiil();

        }

        private void gameFieldGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GameField.AddLine();
        }

        public void Refresh()
        {
            for (int r = 0; r < GameField.rowCount; r++)
                for (int c = 0; c < GameField.colCount; c++)
                {
                    DataGridViewColumn col = gameFieldGrid.Columns[c];
                    col.Width = 16;
                    DataGridViewRow row = gameFieldGrid.Rows[r];
                    row.Height = 16;

                    if (GameField.field[r, c] == GameField.CellColor.BLUE)
                        gameFieldGrid[c, r].Style.BackColor = Color.MidnightBlue;
                    if (GameField.field[r, c] == GameField.CellColor.GREEN)
                        gameFieldGrid[c, r].Style.BackColor = Color.ForestGreen;
                    if (GameField.field[r, c] == GameField.CellColor.YELLOW)
                        gameFieldGrid[c, r].Style.BackColor = Color.Gold;
                    if (GameField.field[r, c] == GameField.CellColor.RED)
                        gameFieldGrid[c, r].Style.BackColor = Color.Crimson;
                    if (GameField.field[r, c] == GameField.CellColor.GRAY)
                        gameFieldGrid[c, r].Style.BackColor = Color.Gray;
                }
        }
    }
}
