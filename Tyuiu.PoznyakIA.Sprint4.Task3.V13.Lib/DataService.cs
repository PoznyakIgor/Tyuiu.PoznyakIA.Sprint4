using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PoznyakIA.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j == 3)
                    {
                        sum = sum + array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
