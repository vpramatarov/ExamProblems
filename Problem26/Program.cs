using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 26: Съставете програма на С#, която:
Генерира случайно число по-голямо от 10000. Изведете го на екрана и след това изведете с думи всяка една от съставящите го десетични цифри.*/

namespace Problem26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string rInt = r.Next(0, 10000).ToString();//generate random number
            string convertedNumbers = string.Empty;
            Console.WriteLine(rInt);

            foreach(char c in rInt)
            {
                switch (c) //convert number to word
                {
                    case '1':
                        convertedNumbers += "едно,";
                        break;
                    case '2':
                        convertedNumbers += "две,";
                        break;
                    case '3':
                        convertedNumbers += "три,";
                        break;
                    case '4':
                        convertedNumbers += "четири,";
                        break;
                    case '5':
                        convertedNumbers += "пет,";
                        break;
                    case '6':
                        convertedNumbers += "шест,";
                        break;
                    case '7':
                        convertedNumbers += "седем,";
                        break;
                    case '8':
                        convertedNumbers += "осем,";
                        break;
                    case '9':
                        convertedNumbers += "девет,";
                        break;
                    default:
                        convertedNumbers += "нула,";
                        break;
                }
            }

            convertedNumbers = convertedNumbers.Remove(convertedNumbers.Length - 1); //remove last comma
            Console.WriteLine(convertedNumbers);
        }
    }
}
