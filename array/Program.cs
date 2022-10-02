using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 1, 2, 3 } };
            int sum = 0;
            int multiplication = 1;
            int column = 0;
            int row = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write("|");

                    if(j == column)
                    {
                        multiplication *= array[i, j];
                    }

                    if(i == row)
                    {
                        sum += array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Сумма строки " + (row + 1) + ": " + sum + "\nПроизведение столбца " + (column + 1) + ": " + multiplication);
            Console.ReadKey();
        }
    }
}
