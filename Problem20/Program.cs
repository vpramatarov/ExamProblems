using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 21: Съставете програма на С#, която да:
Генерира случайни символи в един низ с дължина 255.
Да се изброят колко символи са ‘a’, ‘b’ и ‘z’.
Всеки резултат да се отпечата на отделен ред.*/

namespace Problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[255];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            var countA = finalString.Count(x => x == 'a');
            var countB = finalString.Count(x => x == 'b');
            var countZ = finalString.Count(x => x == 'z');
            Console.WriteLine(finalString);
            Console.WriteLine();
            Console.WriteLine("'a' се среща " + countA + " пъти във подадения стринг");
            Console.WriteLine("'b' се среща " + countB + " пъти във подадения стринг");
            Console.WriteLine("'z' се среща " + countZ + " пъти във подадения стринг");
        }
    }
}
