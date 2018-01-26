using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameController controller = new GameController();
            GameField model = new GameField(controller);
            Form1 view = new Form1(controller);

            controller.Init(model, view);

            Application.Run(controller.GetMainForm());
        }
    }
}
