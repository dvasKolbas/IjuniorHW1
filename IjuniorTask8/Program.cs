using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IjuniorTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople;
            int timeForPatient = 10;
            int timeInLine;
            int hoursInLine;
            int remainderMinutes;

            Console.WriteLine("Введите кол-во старушек: ");
            numberPeople = Convert.ToInt32(Console.ReadLine());

            timeInLine = numberPeople * timeForPatient;
            hoursInLine = timeInLine / 60;
            remainderMinutes = timeInLine % 60; 

            Console.WriteLine($"Вы должны отстоять в очереди {hoursInLine} часа и {remainderMinutes} минут.");
        }
    }
}
