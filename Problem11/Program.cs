using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*Зад. 11: Да се реализира приложение „Зодия”.
Потребителт въвежда дата на раждане и програмта извежда зодията му.
Диалога с програмта да има следния вид:
Въведете дата на раждане:
24.06.1998
Вашата зодия е: Рак*/

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;

            string bDay;
            DateTime date = new DateTime();

            Console.WriteLine("Въведете дата на раждане: (формат: 16.02.1983)");
            bDay = Console.ReadLine();
            Console.WriteLine("\n");

            try
            {
                date = Convert.ToDateTime(bDay);
            }
            catch (Exception e)
            {
                Console.WriteLine("Грешка: " + e.Message + "\nОпитайте отново!");
                Console.ReadKey();
                Environment.Exit(1);
            }

            switch (date.Month)
            {
                case 1:
                    if (date.Day <= 20)
                    {
                        Console.WriteLine("Вашата зодия е: Козирог");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Водолей");
                    }
                    break;
                case 2:
                    if (date.Day <= 19)
                    {
                        Console.WriteLine("Вашата зодия е: Водолей");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Риби");
                    }
                    break;
                case 3:
                    if (date.Day <= 20)
                    {
                        Console.WriteLine("Вашата зодия е: Риби");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Овен");
                    }
                    break;
                case 4:
                    if (date.Day <= 20)
                    {
                        Console.WriteLine("Вашата зодия е: Овен");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Телец");
                    }
                    break;
                case 5:
                    if (date.Day <= 21)
                    {
                        Console.WriteLine("Вашата зодия е: Телец");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Близнаци");
                    }
                    break;
                case 6:
                    if (date.Day <= 22)
                    {
                        Console.WriteLine("Вашата зодия е: Близнаци");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Рак");
                    }
                    break;
                case 7:
                    if (date.Day <= 22)
                    {
                        Console.WriteLine("Вашата зодия е: Рак");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Лъв");
                    }
                    break;
                case 8:
                    if (date.Day <= 23)
                    {
                        Console.WriteLine("Вашата зодия е: Лъв");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Дева");
                    }
                    break;
                case 9:
                    if (date.Day <= 23)
                    {
                        Console.WriteLine("Вашата зодия е: Дева");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Везни");
                    }
                    break;
                case 10:
                    if (date.Day <= 23)
                    {
                        Console.WriteLine("Вашата зодия е: Везни");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Скорпион");
                    }
                    break;
                case 11:
                    if (date.Day <= 22)
                    {
                        Console.WriteLine("Вашата зодия е: Скорпион");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Стрелец");
                    }
                    break;
                case 12:
                    if (date.Day <= 21)
                    {
                        Console.WriteLine("Вашата зодия е: Стрелец");
                    }
                    else
                    {
                        Console.WriteLine("Вашата зодия е: Козирог");
                    }
                    break;
                default:
                    Console.WriteLine("Вашият зодиакален знак не е намерен! Моля, опитайте отново");
                    break;
            }
        }

    }
}
