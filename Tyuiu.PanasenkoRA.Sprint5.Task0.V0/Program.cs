using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint5.Task0.V0.Lib;
using System.IO; 
namespace Tyuiu.PanasenkoRA.Sprint5.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Панасенко Р.А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Панасенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при х = 3, результат сохранить в  *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до   *");
            Console.WriteLine("* трёх знаков после запятой                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("Переменная х = " + x);
            Console.WriteLine("Функция:");
            Console.WriteLine("                 x");
            Console.WriteLine("y(x) = ---------------------");
            Console.WriteLine("                     0.5");
            Console.WriteLine("            (x*x + x)");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            double z = Math.Round((x / (Math.Sqrt(Math.Pow(x, 2) + x))), 3);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Успешно создан!");
            Console.WriteLine("Значение функции = " + z);
            Console.ReadKey();
        }
    }
}
