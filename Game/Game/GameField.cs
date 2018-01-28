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
            REST,
            DELETING
        }   

        public int RowCount { set; get; }
        public int ColCount { set; get; }
        public int NearSameCells = 0;

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
            int r0 = -1, c0 = -1;

            for (int r = 0; r < RowCount; r++)
                for (int c = 0; c < ColCount; c++)
                    if (_stateField[r, c] == CellState.SELECTED)
                    {
                        for (int rowInd = RowCount - 1; rowInd > 0; rowInd--)
                            if (_field[rowInd - 1, colInd] != CellColor.GRAY)
                            {
                                _field[rowInd, colInd] = _field[r, c];

                                _stateField[r, c] = CellState.REST;

                                //BlockDelete(rowInd, colInd);
                                r0 = rowInd;
                                c0 = colInd;
                                break;
                            }
                        _field[r, c] = CellColor.GRAY;
                    }

            BlockDelete(r0, c0);
            //MessageBox.Show("BlockDelete comlete");
            FieldUpdate();
            ShiftAfterDeleting();
            NearSameCells = 0;
        }

        private void BlockDelete(int rowInd, int colInd)
        {
            _stateField[rowInd, colInd] = CellState.DELETING;
            //если север
            if (rowInd > 0 && _field[rowInd - 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd - 1, colInd] != CellState.DELETING)//север
            {
                _stateField[rowInd, colInd] = CellState.DELETING;
                BlockDelete(rowInd - 1, colInd);

                //MessageBox.Show("Иду на север " + rowInd.ToString() + ',' + colInd.ToString());

                //nearSameCells++;

                if (colInd < ColCount - 1 && _field[rowInd, colInd + 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd + 1] != CellState.DELETING)//восток
                {
                    _stateField[rowInd, colInd] = CellState.DELETING;
                    BlockDelete(rowInd, colInd + 1);

                    //MessageBox.Show("Иду на восток " + rowInd.ToString() + ',' + colInd.ToString());

                    //nearSameCells++;

                    if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
                    {
                        _stateField[rowInd, colInd] = CellState.DELETING;
                        BlockDelete(rowInd + 1, colInd);

                        //MessageBox.Show("Иду на юг " + rowInd.ToString() + ',' + colInd.ToString());

                        //nearSameCells++;

                        if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
                        {
                            _stateField[rowInd, colInd] = CellState.DELETING;
                            BlockDelete(rowInd, colInd - 1);

                            //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                            //nearSameCells++;
                        }
                    }

                    if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
                    {
                        _stateField[rowInd, colInd] = CellState.DELETING;
                        BlockDelete(rowInd, colInd - 1);

                        //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                        //nearSameCells++;
                    }
                }

                if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
                {
                    _stateField[rowInd, colInd] = CellState.DELETING;
                    BlockDelete(rowInd, colInd - 1);

                    //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                    //nearSameCells++;

                    if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
                    {
                        _stateField[rowInd, colInd] = CellState.DELETING;
                        BlockDelete(rowInd + 1, colInd);

                        //MessageBox.Show("Иду на юг " + rowInd.ToString() + ',' + colInd.ToString());

                        //nearSameCells++;
                    }
                }
                if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
                {
                    _stateField[rowInd, colInd] = CellState.DELETING;
                    BlockDelete(rowInd + 1, colInd);

                    //MessageBox.Show("Иду на юг " + rowInd.ToString() + ',' + colInd.ToString());

                    //nearSameCells++;
                }
            }

            //если севера нет
            if (colInd < ColCount - 1 && _field[rowInd, colInd + 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd + 1] != CellState.DELETING)//восток
            {
                _stateField[rowInd, colInd] = CellState.DELETING;
                BlockDelete(rowInd, colInd + 1);

                //MessageBox.Show("Иду на восток " + rowInd.ToString() + ',' + colInd.ToString());

                //nearSameCells++;

                if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
                {
                    _stateField[rowInd, colInd] = CellState.DELETING;
                    BlockDelete(rowInd + 1, colInd);

                    //MessageBox.Show("Иду на юг " + rowInd.ToString() + ',' + colInd.ToString());

                    //nearSameCells++;

                    if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
                    {
                        _stateField[rowInd, colInd] = CellState.DELETING;
                        BlockDelete(rowInd, colInd - 1);

                        //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                        //nearSameCells++;
                    }
                }

                if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
                {
                    _stateField[rowInd, colInd] = CellState.DELETING;
                    BlockDelete(rowInd, colInd - 1);

                    //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                    //nearSameCells++;
                }
            }

            //если нет ни севера, ни востока
            if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
            {
                _stateField[rowInd, colInd] = CellState.DELETING;
                BlockDelete(rowInd + 1, colInd);

                //MessageBox.Show("Иду на юг " + rowInd.ToString() + ',' + colInd.ToString());

                //nearSameCells++;

                if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
                {
                    _stateField[rowInd, colInd] = CellState.DELETING;
                    BlockDelete(rowInd, colInd - 1);

                    //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                    //nearSameCells++;
                }
            }

            //если ни севера, ни востока, ни юга
            if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
            {
                _stateField[rowInd, colInd] = CellState.DELETING;
                BlockDelete(rowInd, colInd - 1);

                //MessageBox.Show("Иду на запад " + rowInd.ToString() + ',' + colInd.ToString());

                //nearSameCells++;
            }
        }


        private void FieldUpdate()
        {
            for (int r = 0; r < RowCount; r++)
                for (int c = 0; c < ColCount; c++)
                    if (_stateField[r, c] == CellState.DELETING)
                    {
                        _field[r, c] = CellColor.GRAY;
                        _stateField[r, c] = CellState.REST;
                    }
        }

        private void ShiftAfterDeleting()
        {
            for (int r = 1; r < RowCount; r++)
                for (int c = 0; c < ColCount; c++)
                //if (_field[r - 1, c] == CellColor.GRAY)
                //{
                //    _field[r - 1, c] = _field[r, c];
                //    _field[r, c] = CellColor.GRAY;
                //}
                {
                    bool flag = false;
                    int r0 = r;
                    while (_field[r0 - 1, c] == CellColor.GRAY && r0 > 1)
                    {
                        _field[r0 - 1, c] = _field[r0, c];
                        _field[r0, c] = CellColor.GRAY;
                        r0--;
                        flag = true;
                    }
                    //if (_field[r0, c] != CellColor.GRAY && flag)
                    //{
                      //  BlockDelete(r - 1, c);
                       // FieldUpdate();
                    //}
                }
        }

        public bool IsLost()
        {
            for (int c = 0; c < ColCount; c++)
                if (_field[14, c] != CellColor.GRAY && _stateField[14, c] == CellState.REST)
                    return true;
            return false;
        }
    }
}

//    if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
//    {
//        _stateField[rowInd, colInd] = CellState.DELETING;
//        BlockDelete(rowInd + 1, colInd, 0);

//        MessageBox.Show("Иду на север " + (rowInd + 1).ToString() + ',' + colInd.ToString());

//        nearSameCells++;
//    }
//}
//    if (colInd < ColCount - 1 && _field[rowInd, colInd + 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd + 1] != CellState.DELETING)//восток
//    {
//        _stateField[rowInd, colInd] = CellState.DELETING;
//        BlockDelete(rowInd, colInd + 1, 0);

//        MessageBox.Show("Иду на север " + rowInd.ToString() + ',' + (colInd + 1).ToString());

//        nearSameCells++;
//    }

//        if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
//        {
//            _stateField[rowInd, colInd] = CellState.DELETING;
//            BlockDelete(rowInd + 1, colInd, 0);

//            MessageBox.Show("Иду на север " + (rowInd + 1).ToString() + ',' + colInd.ToString());

//            nearSameCells++;
//        }

//            if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
//            {
//                _stateField[rowInd, colInd] = CellState.DELETING;
//                BlockDelete(rowInd, colInd - 1, 0);

//                MessageBox.Show("Иду на север " + rowInd.ToString() + ',' + (colInd - 1).ToString());

//                nearSameCells++;
//            }

//if (rowInd > 0 && _field[rowInd - 1, colInd] == _field[rowInd, colInd] && NearSameCells < 1000)//север
//{
//    if (NearSameCells >= 4)
//        _stateField[rowInd, colInd] = CellState.DELETING;
//    NearSameCells++;
//    BlockDelete(rowInd - 1, colInd);
//}
////if (colInd < ColCount - 1 && _field[rowInd - 1, colInd + 1] == _field[rowInd, colInd])//северо-восток
////{
////    _field[rowInd, colInd] = CellColor.GRAY;
////    BlockDelete(rowInd - 1, colInd + 1);
////}

//if (colInd < ColCount - 1 && _field[rowInd, colInd + 1] == _field[rowInd, colInd] && NearSameCells < 1000)//восток
//{
//    if (NearSameCells >= 4)
//        _stateField[rowInd, colInd] = CellState.DELETING;
//    NearSameCells++;
//    BlockDelete(rowInd, colInd + 1);
//}
////if (rowInd < RowCount - 1 && colInd < ColCount - 1 && _field[rowInd + 1, colInd + 1] == _field[rowInd, colInd])//юго-восток
////{
////    _field[rowInd, colInd] = CellColor.GRAY;
////    BlockDelete(rowInd + 1, colInd + 1);
////}

//if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && NearSameCells < 1000)//юг
//{
//    if (NearSameCells >= 4)
//        _stateField[rowInd, colInd] = CellState.DELETING;
//    NearSameCells++;
//    BlockDelete(rowInd + 1, colInd);
//}
//if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && NearSameCells < 1000)//запад
//{
//    if (NearSameCells >= 4)
//        _stateField[rowInd, colInd] = CellState.DELETING;
//    NearSameCells++;
//    BlockDelete(rowInd, colInd - 1);
//}






//switch (nearSameCells)
//{
//    case 0:
//        if (rowInd > 0 && _field[rowInd - 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd - 1, colInd] != CellState.DELETING)//север
//        {
//            _stateField[rowInd, colInd] = CellState.DELETING;
//            BlockDelete(rowInd - 1, colInd, 0);

//            MessageBox.Show("Иду на север " + (rowInd - 1).ToString() + ',' + colInd.ToString());

//            nearSameCells++;
//        }
//        break;
//    case 1:
//        if (colInd < ColCount - 1 && _field[rowInd, colInd + 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd + 1] != CellState.DELETING)//восток
//        {
//            _stateField[rowInd, colInd] = CellState.DELETING;
//            BlockDelete(rowInd, colInd + 1, 0);

//            MessageBox.Show("Иду на север " + rowInd.ToString() + ',' + (colInd + 1).ToString());

//            nearSameCells++;
//        }
//        break;
//    case 2:
//        if (rowInd < RowCount - 1 && _field[rowInd + 1, colInd] == _field[rowInd, colInd] && _stateField[rowInd + 1, colInd] != CellState.DELETING)//юг
//        {
//            _stateField[rowInd, colInd] = CellState.DELETING;
//            BlockDelete(rowInd + 1, colInd, 0);

//            MessageBox.Show("Иду на север " + (rowInd + 1).ToString() + ',' + colInd.ToString());

//            nearSameCells++;
//        }
//        break;
//    case 3:
//        if (colInd > 0 && _field[rowInd, colInd - 1] == _field[rowInd, colInd] && _stateField[rowInd, colInd - 1] != CellState.DELETING)//запад
//        {
//            _stateField[rowInd, colInd] = CellState.DELETING;
//            BlockDelete(rowInd, colInd - 1, 0);

//            MessageBox.Show("Иду на север " + rowInd.ToString() + ',' + (colInd - 1).ToString());

//            nearSameCells++;
//        }
//        break;
//    default:
//        BlockDelete(rowInd, colInd, 0);
//        break;
//}



//if (nearSameCells >= 4)
//  return;