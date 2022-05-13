using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IjuniorTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Какой у вас знак задиака?");
            string signZodiac = Console.ReadLine();

            Console.WriteLine("Кем вы работаете?");
            string work = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age}лет, ваш знак зодиака {signZodiac}, вы работаете {work}!");
        }
    }
}
