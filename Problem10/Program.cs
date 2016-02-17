using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 10: Да се реализира приложение „Познай числото”.
В програмата да се генерира случайно число в диапазона от 1 до 100. Потребителят има максимум 5 опита да отгатне числото. След всеки опит се извежда едно от следните съобщения:
- отгатна числото
- намисленото число е по-голямо
- намисленото число е по-малко*/

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            
            for(int i = 1; i <= 5; i++)
            {
                int userInput = int.Parse(Console.ReadLine());
                if(randomNumber == userInput)
                {
                    Console.WriteLine("Отгатна числото");
                    return;
                }
                else if(userInput > randomNumber)
                {
                    Console.WriteLine("Намисленото число е по-малко");
                }
                else
                {
                    Console.WriteLine("Намисленото число е по-голямо");
                }
            }

        }
    }
}
