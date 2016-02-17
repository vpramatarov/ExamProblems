using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете лихва:");
            double interest = Double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете сума по влога:");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете брой месеци:");
            int period = int.Parse(Console.ReadLine());
            int numberOfYears;
            double valueAtEndOfPeriod;

            if (interest > 0 && interest < 100)
            {
                numberOfYears = period / 12;
                Console.WriteLine(12 * numberOfYears);
                for(int i = 1; i <= period; i++)
                {
                    valueAtEndOfPeriod = sum * Math.Pow(1 + (interest / 100) / 12, 12 * numberOfYears);
                    
                    Console.WriteLine(valueAtEndOfPeriod);
                }
                
            }
        }
    }
}
