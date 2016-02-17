using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*Зад. 24: Съставете програма на С#, която да:
Генерира случайни символи в един низ с дължина 255.
Да се обходи низа и да се сменят всички главни букви с малки такива.
Да се отпечатат двата низа на дава отделни реда.*/

namespace Problem24
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
            Console.WriteLine(finalString);
            Console.WriteLine();
            string replacedString = Regex.Replace(finalString, @"\B\p{Lu}", m =>  m.ToString().ToLower());
            Console.WriteLine(replacedString);

        }
    }
}
