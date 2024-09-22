using Tyuiu.NoskovVI.Sprint1.Task7.V15.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*          cos x^3 +7*x^2                                                 *");
            Console.WriteLine("*|x^2-x^3|- ------------                                                  *");
            Console.WriteLine("*             x^3-15x                                                     *");

            double x;
            Console.WriteLine("Введите переменную x: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Выражение равно: " + ds.Calculate(x));

            Console.ReadKey();
        }
    }
}
