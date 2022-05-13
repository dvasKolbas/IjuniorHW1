using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IjuniorTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Васечкин";
            string lastName = "Петр";

            Console.WriteLine($"До изменений: Имя: {firstName}, Фамилия: {lastName}");

            string temp = firstName;
            firstName = lastName;
            lastName = temp;

            Console.WriteLine($"После изменений:Имя: {firstName}, Фамилия: {lastName}");
        }
    }
}
