using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 22: Съставете програма на С#, която да:
Генерира случайни символи в един низ с дължина 255.
Да се изброят колко символи са големи букви (от ‘A’ до ‘Z’).
Всеки резултат да се отпечата на отделен ред.*/

namespace Problem22
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
            var capitalLetters = new String(finalString.Where(c => Char.IsLetter(c) && Char.IsUpper(c)).ToArray());
            var distinctLetters = new string(capitalLetters.ToCharArray().Distinct().ToArray());

            Console.WriteLine(finalString); //output generated string
            Console.WriteLine();
            Console.WriteLine(capitalLetters); //show only capital letters
            Console.WriteLine();
            Console.WriteLine(distinctLetters); //show only distinct capital letters
            Console.WriteLine();

            //output and count each capital letter
            foreach (char c in distinctLetters)
            {
                Console.WriteLine("Буква " + c + " се среща " + capitalLetters.Count(x => x == c) + " пъти");
            }
            
        }
    }
}
