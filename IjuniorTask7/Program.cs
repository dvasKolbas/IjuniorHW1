using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IjuniorTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 3;
            int wallet;
            int numberCrystals;

            Console.WriteLine("Сколько золота в кошельке?");
            wallet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько кристаллов купить?");
            numberCrystals = Convert.ToInt32(Console.ReadLine());
            wallet -= numberCrystals * price;

            Console.WriteLine($"Золота в кошельке: {wallet}, Кристаллов: {numberCrystals}");
        }
    }
}
