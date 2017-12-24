using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary
{
    public class Inp_Out
    {
        public static List<List<double>> InpTXT(string fileName)
        {
            StreamReader lnReader = new StreamReader(fileName);
            
            //создание двумерного массива на основе файла
            List<List<double>> data = new List<List<double>>();

            string lnTXT = lnReader.ReadLine();

            while (lnTXT != null)
            {
                List<double> line = new List<double>(StrToArray<double>(lnTXT));

                data.Add(line);

                lnTXT = lnReader.ReadLine();
            }     
            return data;
        }

        private static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }


        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }
        //проверка массива на "прямоугольность"
        public static bool IsArr2Square(List<List<double>> data)
        {
            int chk = data[0].Count;
            for (int i = 0; i < data.Count(); i++)
                if (data[i].Count != chk)
                    return false;

            return true;
        }

        //вывод массива в консоль
        public static void Arr2Print_Console<T> (T[,] mas)
        {
            for (int r = 0; r < mas.GetLength(0); r++)
            {
                for (int c = 0; c < mas.GetLength(1); c++)
                    Console.Write(mas[r, c] + " ");
                Console.WriteLine();
            }
        }
        // Функция ввода значения с консоли в диалогом режиме:
        //   функции передается название значения (переменной) в виде строки (string),
        //   функция возвращает введенное значение типа T;
        //   (string) -> T
        public static string ReadValueFromConsole(string varName)
        {
            while (true)
                try
                {
                    Console.Write("Введите {0}: ", varName);

                    String fileName = Console.ReadLine();
                    fileName = Environment.CurrentDirectory + "\\" + GetDataDirectiry() + fileName;

                    return fileName;

//                    return Environment.CurrentDirectory + "\u005C" + StrToValue<string>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }

        // Возвращает путь к папке с файлами данных
        public static string GetDataDirectiry()
        {
            return "\\..\\..\\..\\Data\\";
        }

        // Функция ввода массива с консоли в диалогом режиме:
        //   функции передается название массива (переменной) в виде строки (string),
        //   функция возвращает введенное значение типа T[];
        //   (string) -> T[]
        public static T[] ConsoleReadArray<T>(string arrName)
        {
            while (true)
                try
                {
                    Console.WriteLine("Введите (через пробел или запятую) массив {0}: ", arrName);
                    Console.Write("  ");
                    return StrToArray<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }

    }
}
