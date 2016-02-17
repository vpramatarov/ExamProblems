using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 2: Напишете програма на C#, която извършва следното:
След въвеждане на навършените години на лицето, определя социалната му група според следната скала:
- До 1 година – бебе;
- от 1 до 6 – дете;
- от 7 до 11 – ученик;
- от 12 до 19 – тийнейджър;
- от 20 до 25 – студент;
- от 26 до 65 – работещ;
- над 65 – пенсионер.*/

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age = Byte.Parse(Console.ReadLine());
            if(age < 1)
            {
                Console.WriteLine("бебе");
            }
            else if(age >= 1 && age <= 6)
            {
                Console.WriteLine("дете");
            }
            else if (age >= 7 && age <= 11)
            {
                Console.WriteLine("ученик");
            }
            else if (age >= 12 && age <= 19)
            {
                Console.WriteLine("тийнейджър");
            }
            else if (age >= 20 && age <= 25)
            {
                Console.WriteLine("студент");
            }
            else if (age >= 26 && age <= 65)
            {
                Console.WriteLine("работещ");
            }
            else if (age >= 65 && age <= 120)
            {
                Console.WriteLine("пенсионер");
            }
            else
            {
                Console.WriteLine("Рекордьор в Гинес :)");
            }
        }
    }
}
