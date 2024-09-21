using Tyuiu.NoskovVI.Sprint1.Task5.V1.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите абциссу первой точки: ");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите ординату первой точки: ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите абциссу второй точки: ");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите ординату второй точки: ");
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между двумя точками равно: " + ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadKey();
        }
    }
}
