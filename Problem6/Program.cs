using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 6: Напишете програма на C#, която извършва следното:
Обявява масив. Запълва масива с положителни и отрицателни стойности. Изчислява сумата от положителните и сумата от отрицателните стойности. Обхождането на масива да стане с оператора FOR. Получените суми да се изведът на екрана.*/

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Въведете брой елементи в масива: ");

            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];
            int totalPositive = 0;
            int totalNegative = 0;
            Console.Write("Въведете числа за масива: ");
            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayLength; i++)
            {
                //Negative
                if (numbers[i] < 0)
                {
                    totalNegative +=  numbers[i];
                }

                // Negative
                if (numbers[i] > 0)
                {
                    totalPositive += numbers[i];
                }
            }

            Console.WriteLine("Сумата от положителните числа е = {0}", totalPositive);
            Console.WriteLine("Сумата от отрицателните числа е = {0}", totalNegative);

        }
    }
}
