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

        private int _clickCount = 0;

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

            addLineTimer.Start();
            timeProgressBar.Value = 0;

            FieldRefresh();
        }

        private void gameFieldGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _clickCount++;
            if (_clickCount % 2 == 1)
            {
                _controller.GetSelectedCellIndex(e.ColumnIndex);
                //_clickCount++;
            }
            else 
            {
                _controller.GetInputColumnIndex(e.ColumnIndex);
                //_clickCount++;
            }
        }

        public void FieldRefresh()
        {
            GameField.CellColor[,] field = _controller.GetField();
            GameField.CellState[,] stateField = _controller.GetStateField();

            for (int r = 0; r < _controller.GetRowCount(); r++)
                for (int c = 0; c < _controller.GetColCount(); c++)
                {
                    DataGridViewColumn col = gameFieldGrid.Columns[c];
                    col.Width = 16;
                    DataGridViewRow row = gameFieldGrid.Rows[r];
                    row.Height = 16;

                    if (field[r, c] == GameField.CellColor.BLUE)
                    {
                        gameFieldGrid[c, r].Style.BackColor = Color.Blue;
                        if (stateField[r, c] == GameField.CellState.SELECTED)
                        {
                            gameFieldGrid[c, r].Value = 'O';
                            gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                        }
                        else
                            if (stateField[r, c] == GameField.CellState.DELETING)
                            {
                                gameFieldGrid[c, r].Value = 'X';
                                gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                            }
                    }
                    if (field[r, c] == GameField.CellColor.GREEN)
                    {
                        gameFieldGrid[c, r].Style.BackColor = Color.ForestGreen;
                        if (stateField[r, c] == GameField.CellState.SELECTED)
                        {
                            gameFieldGrid[c, r].Value = 'O';
                            gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                        }
                        else
                            if (stateField[r, c] == GameField.CellState.DELETING)
                            {
                                gameFieldGrid[c, r].Value = 'X';
                                gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                            }
                    }
                    if (field[r, c] == GameField.CellColor.YELLOW)
                    {
                        gameFieldGrid[c, r].Style.BackColor = Color.Gold;
                        if (stateField[r, c] == GameField.CellState.SELECTED)
                        {
                            gameFieldGrid[c, r].Value = 'O';
                            gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                        }
                        else
                            if (stateField[r, c] == GameField.CellState.DELETING)
                            {
                                gameFieldGrid[c, r].Value = 'X';
                                gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                            }
                    }
                    if (field[r, c] == GameField.CellColor.RED)
                    {
                        gameFieldGrid[c, r].Style.BackColor = Color.Crimson;
                        if (stateField[r, c] == GameField.CellState.SELECTED)
                        {
                            gameFieldGrid[c, r].Value = 'O';
                            gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                        }
                        else
                            if (stateField[r, c] == GameField.CellState.DELETING)
                            {
                                gameFieldGrid[c, r].Value = 'X';
                                gameFieldGrid[c, r].Style.ForeColor = Color.Black;
                            }
                    }
                    if (field[r, c] == GameField.CellColor.GRAY || stateField[r, c] == GameField.CellState.DELETING)
                    {
                        gameFieldGrid[c, r].Style.BackColor = Color.Gray;
                        gameFieldGrid[c, r].Value = null;
                    }
                }
        }

        private void addLineTimer_Tick(object sender, EventArgs e)
        {
            timeProgressBar.Value++;

            if (timeProgressBar.Value == timeProgressBar.Maximum)
            {
                _controller.AddLine();
                timeProgressBar.Value = 0;
            }

            _controller.LooseDetect();
        }

        public void GameOver()
        {
            addLineTimer.Stop();
            MessageBox.Show("Ну шо пoделать..." + Environment.NewLine +  "Ты проиграл :(");

            _controller.NewGame();

            addLineTimer.Start();
            timeProgressBar.Value = 0;
        }
    }
}
