using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 9: Напишете програма на C#, чрез която:
Създава 2 едномерни масива от тип string, единият да съдържа само първи имена, а другият само фамилни имена. Чрез класа Random да се изпише в конзолата случайно генерирано име и фамилия.*/

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Иван", "Петър", "Димитър", "Йордан", "Георги", "Златин", "Живко"};
            string[] lastNames = { "Иванов", "Петров", "Йорданов", "Димитров", "Славов", "Георгиев", "Дамянов" };
            string firstName = "";
            string lastName = "";
            Random rand = new Random();

            for (int i = 0; i < 2; i++)
            {
                int temp1 = rand.Next(0, firstNames.Length);
                int temp2 = rand.Next(0, lastNames.Length);
                firstName = firstNames[temp1];
                lastName = lastNames[temp2];
            }

            Console.WriteLine("Име: " + firstName);
            Console.WriteLine("Фамилия: " + lastName);

        }
    }
}
