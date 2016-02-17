using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 4: Напишете програма на C#, която да изобразява пирамида от символ “*”
Потребителят трябва да въведе в променлива колко да е висока пирамидата. Използвайте оператора FOR */

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Въведете височина на пирамидата: ");
            num = Int32.Parse(Console.ReadLine());
            int count = 1;

            for (int lines = num; lines >= 1; lines--)
            {

                for (int spaces = lines - 1; spaces >= 1; spaces--)
                {
                    Console.Write(" ");

                }
                for (int star = 1; star <= count; star++)
                {
                    Console.Write("*");
                    Console.Write(" ");

                }
                count++;

                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
