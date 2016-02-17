using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Зад. 5: Напишете програма на C#, която извършва следното:
Въвежда разстоянието между два обекта А и В. Обектът А се движи в посока към обекта В със стъпка h. С помощта на оператора while да се определи след колко итерации обектът А ще задмине неподвижния обект В.*/

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance, h, maxStep = 0, i = 0;
            Console.Write("Въведете разстоянието между А и В: ");
            distance = int.Parse(Console.ReadLine());
            Console.Write("Въведете стъпка: ");
            h = int.Parse(Console.ReadLine());

            while (distance >= maxStep)     
            {
                maxStep += h;             
                i++;                         
            }
            Console.WriteLine("Обект А задмина обект В след {0} стъпки", i);
        }
    }
}
