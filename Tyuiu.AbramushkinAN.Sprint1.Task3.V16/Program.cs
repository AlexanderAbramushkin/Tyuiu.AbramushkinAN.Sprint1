using Tyuiu.AbramushkinAN.Sprint1.Task3.V16.Lib;
namespace Tyuiu.AbramushkinAN.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент            *");
            Console.WriteLine("* приведенного квадратного уравнения, корнями которого являются введенные *");
            Console.WriteLine("* пользователем два вещественных числа (для справки: b=-x1-x2).           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, x2;
            Console.WriteLine("Введите значение X:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(Math.Round(ds.CoeffOfQuadraticEquation(x1, x2), 3, MidpointRounding.AwayFromZero));
        }
    }
}
