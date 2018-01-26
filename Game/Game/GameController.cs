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

        public GameController(GameField model, Form1 form)
        {
            _model = model;
            _view = form;
        }

        public Form1 GetMainForm()
        {
            return _view;
        }
    }
}
