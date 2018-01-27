using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameController
    {
        GameField _model;
        Form1 _view;

        public GameController()
        {}

        public void Init(GameField model, Form1 form)
        {
            _model = model;
            _view = form;

            _model.Fill();
        }

        public Form1 GetMainForm()
        {
            return _view;
        }

        public int GetRowCount()
        {
            return _model.RowCount;
        }

        public int GetColCount()
        {
            return _model.ColCount;
        }

        public GameField.CellColor[,] GetField()
        {
            return _model.GetField();
        }

        public void AddLine()
        {
            _model.AddLine();

            _view.FieldRefresh();
        }

        public void GetCellIndexes (int c)
        {
            _model.SelectSameColor(c);
            _view.FieldRefresh();
        }
    }
}
