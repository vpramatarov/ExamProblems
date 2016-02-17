using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 30: Дадена е правоъгълна целочислена матрица с размери 4х5. Същата да се запълни със случайни стойности в диапазона [-100,100]. Съставете програма на С#, която да:
Намира минималната и максималната стойности в матрицата. Програмата да отпечатва индексите на съответните елементи.*/

namespace Problem30
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrix = new int[4, 5];
            string maxIndex = string.Empty;
            string minIndex = string.Empty;

            //generate matrix
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100); //generate random numbers
                    Console.WriteLine("[{0}, {1}] = {2}", i, j, matrix[i, j]); //output matrix & indexes
                    
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            int min = matrix.Cast<int>().Min();
            
            int max = matrix.Cast<int>().Max();

            for (int i = 0; i < 4 ; i++) {
                for (int j = 0; j < 5 ; j++) {
                    if (max == matrix[i, j])
                        maxIndex = i + "," + j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (min == matrix[i, j])
                        minIndex = i + "," + j;
                }
            }

            Console.WriteLine("Max: {0} / Index: {1}",max, maxIndex);
            Console.WriteLine("Min: {0} / Index: {1}", min, minIndex);
        }
    }
}
