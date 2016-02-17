using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 23: Дадена е правоъгълна целочислена матрица с размери 6х7. Същата да се запълни със случайни стойности в диапазона [-200,300]. Съставете програма на С#, която да:
Намира минималната и максималната стойности във всеки стълб на матрицата. Програмата да отпечатва и индексите на съответните елементи.*/

namespace Problem23
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            int[,] matrix = new int[6, 7];
            int indexMin, indexMax;

            //generate matrix
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i, j] = rnd.Next(-200, 300); //generate random numbers
                    Console.WriteLine("[{0}, {1}] = {2}", i, j, matrix[i, j]); //output matrix & indexes
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //find min values
            int[] min = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] c = new int[matrix.GetLength(1)];
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    c[x] = matrix[i, x];
                }
                min[i] = c.Min();
                indexMin = c.ToList().IndexOf(min[i]);//get the index of the number
                Console.WriteLine("Min {0} / Index {1},{2}", min[i], i,indexMin);
            }

            //find max values
            int[] max = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] c = new int[matrix.GetLength(1)];
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    c[x] = matrix[i, x];
                }
                max[i] = c.Max();
                indexMax = c.ToList().IndexOf(max[i]); //get the index of the number
                Console.WriteLine("Max {0} / Index {1},{2}", max[i],i, indexMax);
            }

        }

    }
}
