using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTools
{
    public class MessageBsc
    {
        // Отображает окно с произвольным сообщением
        public static void Show(string message)
        {
            MessageBox.Show(message);
        }

        // Отображает окно с текстом ошибки и кнопкой "Ок"
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

