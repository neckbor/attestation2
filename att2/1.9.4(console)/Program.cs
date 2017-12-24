using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary;

namespace _1._9._4_console_
{
    class Program
    {
        /*Раздел 9 номер 4(console)
4.	Создать новый двумерный массив, исключив из переданного массива совпадающие столбцы. 
(Совпадающие столбцы – столбцы, у которых все соответствующие элементы равны друз другу).
При формировании нового массива оставить только первый из каждого набора совпадающих столбцов.
 */

        static void Main(string[] args)
        {
            Console.WriteLine("Команды консоли: \n 1.Считать файл: read \n 2.Исключить одинаковые столбцы: run \n ");

            string comand = Console.ReadLine();
            while (true)
            {
                try
                {
                    while (!(comand == "read" || comand == "run"))
                    {
                        Console.WriteLine("Команда не распознана(");
                        comand = Console.ReadLine();
                    }

                    if (comand == "read")
                    {
                            try
                            {
                                Inp_Out.Arr2Print_Console<double>(DataProcessing.ListToArray(Inp_Out.InpTXT(Inp_Out.ReadValueFromConsole<string>("имя файла"))));

                                break;
                            }
                            catch { };
                    }
                    else
                    {

                    };
                }
                catch { };

            }
            Console.ReadKey();
        }
    }
}
