using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.PanasenkoRA.Sprint5.Task7.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint5.Task7.V0
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Панасенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файд в котором есть набор символьных данных. Удалить все удвоенные  *");
            Console.WriteLine("* буквы 'нн' из файла.                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V17.txt";
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V17.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле:");
            pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSave);
            
            Console.ReadKey();
        }
    }
}
