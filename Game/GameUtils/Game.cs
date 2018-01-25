using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUtils
{
    public class Game
    {
        public enum CellColor {
            BLUE,
            GREEN,
            YELLOW,
            RED
        }

        public static CellColor[,] FillGameField()
        {
            CellColor[,] gameField = new CellColor[15, 25];

            Random rnd = new Random();
            int i;

            for (int r = 0; r < 4; r++)
                for (int c = 0; c < gameField.GetLength(1); c++)
                {
                    i = rnd.Next(1, 4);
                    if (i == 0)
                        gameField[r, c] = CellColor.BLUE;
                    if (i == 1)
                        gameField[r, c] = CellColor.GREEN;
                    if (i == 2)
                        gameField[r, c] = CellColor.YELLOW;
                    if (i == 3)
                        gameField[r, c] = CellColor.RED;

                    i = 5;
                }
                    return gameField;
        }
    }
}
