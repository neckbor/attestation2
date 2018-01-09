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
        //ЗАДАЧА РЕШЕНА

        static void Main(string[] args)
        {
            Console.WriteLine("Прочитать данные из файла? (ответ - yes/no)");
            
            switch (Console.ReadLine())
            {
                case "yes":
                    string fileName = Inp_Out.ReadValueFromConsole("имя файла");

                    List<List<double>> data = Inp_Out.InpTXT(fileName);

                    Console.WriteLine("Исходные данные:");
                    Inp_Out.Arr2Print_Console<double>(DataProcessing.ListToArray(data));

                    Console.WriteLine("Обработанный массив:");
                    Inp_Out.Arr2Print_Console<double>(DataProcessing.ListToArray(DataProcessing.ColumEject(data)));
                    break;

                case "no":
                    Console.WriteLine("Введите количество строк массива:");
                    int rowCount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите двухмерный массив (через пробел или запятую) по строкам:");
                    List<List<double>> consData = new List<List<double>>();

                    int i = 0;
                    while (i <= rowCount)
                    {
                        consData.Add(DataProcessing.ArrayToList(Inp_Out.StrToArray<double>(Console.ReadLine())));
                        i++;
                    }
                    Console.WriteLine("Обработанный массив:");
                    Inp_Out.Arr2Print_Console<double>(DataProcessing.ListToArray(DataProcessing.ColumEject(consData)));

                    break;
                default:
                    Console.WriteLine("команда не распoзнана");
                    break;
            }

            Console.ReadKey();
        }
    }
}
