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

        public enum CellState {
            SELECTED,
            REST
        }   

        public int RowCount { set; get; }
        public int ColCount { set; get; }

        private CellColor[,] _field;
        private CellState[,] _stateField;

        private GameController _controller;

        public GameField(GameController controller)
        {
            _controller = controller;

            RowCount = 15;
            ColCount = 25;

            _field = new CellColor[RowCount, ColCount];
            _stateField = new CellState[RowCount, ColCount];
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

                    _stateField[r, c] = CellState.REST;
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
                    if(_stateField[r + 1, c] != CellState.SELECTED)
                        _field[r + 1, c] = _field[r, c];                
        }

        public CellColor[,] GetField()
        {
            return _field;
        }

        public CellState[,] GetStateField()
        {
            return _stateField;
        }

        public void SelectSameColor(int c)
        {
            int i = 0,
                r = RowCount - 1;

            while (_field[r, c] == CellColor.GRAY)
                r--;

            CellColor color = _field[r, c];
            
            while (color == _field[r - i, c])
            {
                _field[RowCount - i - 1, c] = _field[r - i, c];

                _stateField[RowCount - i - 1, c] = CellState.SELECTED;

                _field[r - i, c] = CellColor.GRAY;
                i++;
            }
        }

        public void BlockInput(int colInd)
        {
            for (int r = 0; r < RowCount; r++)
                for (int c = 0; c < ColCount; c++)
                    if (_stateField[r, c] == CellState.SELECTED)
                        for (int rowInd = RowCount - 2; rowInd > 0; rowInd--)
                            if (_field[rowInd - 1, colInd] != CellColor.GRAY)
                            {
                                _field[rowInd, colInd] = _field[r, c];
                                _field[r, c] = CellColor.GRAY;
                                _stateField[r, c] = CellState.REST;
                                BlockDelete(rowInd, colInd);
                                break;
                            }           
        }

        private void BlockDelete(int rowInd, int colInd)
        {
            if (rowInd > 0 && _field[rowInd - 1, colInd] == _field[rowInd, colInd])//север
            {
                _field[rowInd, colInd] = CellColor.GRAY;
                BlockDelete(rowInd - 1, colInd);
            }
            //if (colInd < ColCount - 1 && _field[rowInd - 1, colInd + 1] == _field[rowInd, colInd])//северо-восток
            //{
            //    _field[rowInd, colInd] = CellColor.GRAY;
            //    BlockDelete(rowInd - 1, colInd + 1);
            //}

            if (colInd < ColCount - 1 && _field[rowInd, colInd + 1] == _field[rowInd, colInd])//восток
            {
                _field[rowInd, colInd] = CellColor.GRAY;
                BlockDelete(rowInd, colInd + 1);
            }
            //if (rowInd < RowCount - 1 && colInd < ColCount - 1 && _field[rowInd + 1, colInd + 1] == _field[rowInd, colInd])//юго-восток
            //{
            //    _field[rowInd, colInd] = CellColor.GRAY;
            //    BlockDelete(rowInd + 1, colInd + 1);
            //}

            if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd])//юг
            {
                _field[rowInd, colInd] = CellColor.GRAY;
                BlockDelete(rowInd + 1, colInd);
            }
            if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd])//запад
            {
                _field[rowInd, colInd] = CellColor.GRAY;
                BlockDelete(rowInd, colInd - 1);
            }
        }


    }
}
