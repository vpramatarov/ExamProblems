using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*Зад. 29: Съставете програма на С#, в която:
В даден низ се въвежда някакъв текст. Този низ се подава като указател към функция, която премахва от текста всички шпации. Програмата трябва да отпечата низа преди и след обработката.
Пример:
- Въвеждане на текст: Това е пробен текст
- Вие въведохте: Това е пробен текст
- Въведеният текст след обработката е: Товаепробентекст */

namespace Problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            Console.WriteLine("Вие въведохте: '{0}'", userInput);
            string processedString = removeSpaces(userInput);
            Console.WriteLine("Въведеният текст след обработката е: '{0}'", processedString);

        }

        static private string removeSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }
    }
}
