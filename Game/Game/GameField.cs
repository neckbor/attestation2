﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    public class GameField
    {
        public enum CellColor {
            BLUE,
            GREEN,
            YELLOW,
            RED,
            GRAY
        }

        public static int rowCount = 15;
        public static int colCount = 25;

        private CellColor[,] _field = new CellColor[rowCount, colCount];

        public void Fill()
        {
            Random rnd = new Random();
            int i;
            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                {
                    if (r < 8)
                    {
                        i = rnd.Next(4);

                        if (i == 0)
                            _field[r, c] = CellColor.BLUE;
                        if (i == 1)
                            _field[r, c] = CellColor.GREEN;
                        if (i == 2)
                            _field[r, c] = CellColor.YELLOW;
                        if (i == 3)
                            _field[r, c] = CellColor.RED;
                    }
                    else
                        _field[r, c] = CellColor.GRAY;
                }
        }

        public void AddLine()
        {
            ShiftDown();

            Random rnd = new Random();
            int i;

            for (int c = 0; c < colCount; c++)
            {
                i = rnd.Next(4);

                if (i == 0)
                    _field[0, c] = CellColor.BLUE;
                if (i == 1)
                    _field[0, c] = CellColor.GREEN;
                if (i == 2)
                    _field[0, c] = CellColor.YELLOW;
                if (i == 3)
                    _field[0, c] = CellColor.RED;
            }
        }

        private void ShiftDown()
        {
            for (int r = rowCount - 1; r > 0; r--)
                for (int c = colCount; c > 0; c--)
                    _field[r + 1, c] = _field[r, c];
        }

        //public static void Refresh(DataGridView gameFieldGrid)
        //{
        //    for (int r = 0; r < rowCount; r++)
        //        for (int c = 0; c < colCount; c++)
        //        {
        //            DataGridViewColumn col = gameFieldGrid.Columns[c];
        //            col.Width = 16;
        //            DataGridViewRow row = gameFieldGrid.Rows[r];
        //            row.Height = 16;

        //            if (field[r, c] == CellColor.BLUE)
        //                gameFieldGrid[c, r].Style.BackColor = Color.MidnightBlue;
        //            if (field[r, c] == CellColor.GREEN)
        //                gameFieldGrid[c, r].Style.BackColor = Color.ForestGreen;
        //            if (field[r, c] == CellColor.YELLOW)
        //                gameFieldGrid[c, r].Style.BackColor = Color.Gold;
        //            if (field[r, c] == CellColor.RED)
        //                gameFieldGrid[c, r].Style.BackColor = Color.Crimson;
        //            if (field[r, c] == CellColor.GRAY)
        //                gameFieldGrid[c, r].Style.BackColor = Color.Gray;
        //        }
        //}
    }
}
