using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint4.Task3.V13.Lib;
namespace Tyuiu.PoznyakIA.Sprint4.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Позняк И.А. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка структурных данных                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Позняк И.А. | ИСТНб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("*нечетных элементов массива. {6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7}*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[5, 5] { { 6, 4, 2, 2, 1 },
                                          { 3, 6, 5, 4, 1 },
                                          { 5, 2, 3, 1, 6 },
                                          { 8, 8, 4, 5, 3 },
                                          { 7, 4, 5, 1, 6 }, };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            DataService ds = new DataService();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четвертого столбца = " + ds.Calculate(mtrx));
            Console.ReadKey();
        }
    }
}
