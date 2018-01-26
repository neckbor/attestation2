using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameUtils;

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
            GameField.Refresh(gameFieldGrid);
        }

        private void gameFieldGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GameField.AddLine();
        }
    }
}
