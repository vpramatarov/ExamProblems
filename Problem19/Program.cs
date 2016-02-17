using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 19: Да се реализира приложението “ДУБЛИРАНИ БУКВИ”
Потребителят въвежда случаен текст. Трябва да се премахнат от даденият текст удвоените букви, като се заменят само с 1 буква.
Пример:
Вход: aaabbbbcccddabc
Изход: abcdabc*/

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            char lastChar = input[input.Length - 1];
            char resultLastChar;

            for(int i = 0; i + 1 < input.Length; i++)
            {
                
                if (input[i] != input[i + 1])
                {
                    result += input[i];
                }
            }

            resultLastChar = result[result.Length - 1];
            if (resultLastChar != lastChar)
            {
                result += lastChar;
            }

            Console.WriteLine(result);

        }
    }
}
