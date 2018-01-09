using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTools;

namespace _1._10._4_console_
/*4.	Для набора точек на плоскости найти такие три точки,
для которых площадь треугольника с вершинами в данных точках будет максимальна.
В случае существования нескольких подходящих троек точек – выбрать произвольную. */

    //ЗАДАЧА РЕШЕНА
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cчитать данные из файла?(yes/no)");

            switch (Console.ReadLine())
            {
                case "yes":
                    string fileName = Inp_Out.ReadValueFromConsole("имя файла");

                    double[,] data = DataProcessing.ListToArray(Inp_Out.InpTXT(fileName));

                    Console.WriteLine("Список точек:" + Environment.NewLine + "X Y");
                    Inp_Out.Arr2Print_Console<double>(data);

                    //заполняем данными из файла массив точек  
                    Points[] points = new Points[data.GetLength(0)];
                    for (int r = 0; r < data.GetLength(0); r++)
                    {
                        Points pnt = new Points(data[r, 0], data[r, 1], r + 1);
                        points[r] = pnt;
                    }
                    if (BiggestTriangle.IsTrianglePossible(points))
                        Console.WriteLine("Самый треугольник получается из точек: " + BiggestTriangle.MaxTriangleSquare(points));
                    else
                        Console.WriteLine("из таких точек невозможно построить треугольник");
                    break;

                case "no":
                    Console.WriteLine("Введите количество ваших точек:");
                    int pointCount = int.Parse(Console.ReadLine());

                    Points[] pointsConsole = new Points[pointCount];
                    int i = 0;
                    while (i < pointCount)
                    {
                        Console.Write("Введите коордитаны точки {0}: X = ", i + 1);
                        double x = double.Parse(Console.ReadLine());
                        Console.Write(" Y = ");
                        double y = double.Parse(Console.ReadLine());

                        //заполняем массив точек данными из файла    
                        Points pnt = new Points(x, y, i + 1);
                        pointsConsole[i] = pnt;
                        i++;
                    }
                    if (BiggestTriangle.IsTrianglePossible(pointsConsole))
                        Console.WriteLine("Самый треугольник получается из точек: " + BiggestTriangle.MaxTriangleSquare(pointsConsole));
                    else
                        Console.WriteLine("из таких точек невозможно построить треугольник");
                    break;

                default:
                        Console.WriteLine("команда не распoзнана");
                        break;
            }

            Console.ReadKey();

        }
    }
}
