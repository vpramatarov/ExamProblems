using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 8: Напишете програма на C#, която извършва следното:
Въвеждат се 7 естествени числа от интервала [0..5000] в едномерен масив. Програмата да изведе броя на цифрите на въведените числа, както и сумата на въведените четни числа.
Пример: 13, 14, 25, 16, 55, 97 900
Изход: сума 930 брой цифри 15*/

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            int sum = 0;
            Console.Write("Въведете числа за масива: ");
            for (int i = 0; i < 7; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > 0 && numbers[i] < 5000)
                {
                    continue;
                }
                else
                {
                    return;
                }
                
            }

            for (int i = 0; i < 7; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            string digits = string.Join("", numbers);
            Console.WriteLine("Сума: " + sum + " / брой цифри: " + digits.Length);
        }
    }
}
