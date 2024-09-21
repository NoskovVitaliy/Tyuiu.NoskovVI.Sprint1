using Tyuiu.NoskovVI.Sprint1.Task3.V16.Lib;

namespace Tyuiu.NoskovVI.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите первый корень: ");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите второй корень: ");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Коэффициент приведенного квадратного уравнения равен: ");
            Console.WriteLine(ds.CoeffOfQuadraticEquation(x1, x2));

            Console.ReadKey();
        }
    }
}
