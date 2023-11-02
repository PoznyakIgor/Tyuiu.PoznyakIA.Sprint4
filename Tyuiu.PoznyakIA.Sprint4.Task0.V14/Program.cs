using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.PoznyakIA.Sprint4.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Позняк И.А. | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка структурных данных                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Позняк И.А. | ИСТНб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать                *");
            Console.WriteLine("* сумму нечетных элементов массива.  {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };        

            Console.WriteLine("* Исходный массив: ");
            for (int i = 0; i<=numsArray.Length-1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Cумма нечетных чисел" + ds.GetSumOddArrEl(numsArray));

            Console.ReadLine();
        }
    }
}
