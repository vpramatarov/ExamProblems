using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 1: Напишете програма на C#, която да извършва следното:
- Съставя списък от цветове: червен, жълт, син, бял.
- Извежда списъка.
- Вмъква цвета: зелено.
- Извежда списъка.
- Сортира и извежда списъка след вмъкването на цвета.*/

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Списък на цветовете преди добавянето:");
            List<string> colors = new List<string> { "Червен", "Жълт", "Син", "Бял" };
            string joinedString = string.Join(",", colors);
            Console.WriteLine(joinedString);
            Console.WriteLine("Списък на цветовете след добавянето:");
            colors.Add("Зелен");
            joinedString = string.Join(",", colors);
            Console.WriteLine(joinedString);
            Console.WriteLine("Списък на цветовете след сортирането:");
            colors.Sort();
            Console.WriteLine(string.Join(",",colors));

        }
    }
}
