using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint5.Task2.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint5.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 9, 6, 6 },
                                         {8,7,2 },
                                         {1,7,8 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Панасенко Р.А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Панасенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечётные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл и вывести на консоль.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
