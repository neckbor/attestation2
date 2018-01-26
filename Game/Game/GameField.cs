using System;
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

        public int RowCount { set; get; }
        public int ColCount { set; get; }

        private CellColor[,] _field;

        private GameController _controller;

        public GameField(GameController controller)
        {
            _controller = controller;

            RowCount = 15;
            ColCount = 25;

            _field = new CellColor[RowCount, ColCount];
        }

        public void Fill()
        {
            Random rnd = new Random();
            int i;
            for (int r = 0; r < RowCount; r++)
                for (int c = 0; c < ColCount; c++)
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

            for (int c = 0; c < ColCount; c++)
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
            for (int r = RowCount - 2; r >= 0; r--)
                for (int c = ColCount - 1; c >= 0; c--)
                    _field[r + 1, c] = _field[r, c];                
        }

        public CellColor[,] GetField()
        {
            return _field;
        }
    }
}
