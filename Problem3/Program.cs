using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 3: Напишете програма на C#, която да извършва следното:
- Въвежда 3 реални променливи a, b и c;
- Изчислява израза: d = a / b + b / a * 2.5
- Сравнява d и c и извежда един от следните резултати
1. d > c
2. d < c
3. d = c
Диалога с програмата да има следния вид:
Въведете а =
Въведете b =
Въведете c =
Натиснете <Enter> за завършване на програмата.*/

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Въведете а = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете c = ");
            c = int.Parse(Console.ReadLine());
            double d = a / b + b / a * 2.5;
            var diff = Math.Abs(d - c);
            if (diff < 0.0000001)
            {
                 Console.WriteLine("d = c");
            }
            else if(d > c)
            {
                Console.WriteLine("d > c");
            }
            else if(d < c)
            {
                Console.WriteLine("d < c");
            }

        }
    }
}
