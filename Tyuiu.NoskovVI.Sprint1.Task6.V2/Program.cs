using Tyuiu.NoskovVI.Sprint1.Task6.V2.Lib;
namespace Tyuiu.NoskovVI.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Носков В. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Носков Виталий Игоревич | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, есть и в строке слово Hello.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string maybeAGreeting;

            Console.WriteLine("Введите текст: ");
            maybeAGreeting = Console.ReadLine();

            if (ds.CheckHello(maybeAGreeting))
            {
                Console.WriteLine("Ваш текст содержит приветствие");
            }
            else
            {
                Console.WriteLine("Ваш текст не содержит приветствие");
            }
            Console.ReadKey();
        }
    }
}
