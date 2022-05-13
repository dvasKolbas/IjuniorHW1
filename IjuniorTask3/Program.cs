using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IjuniorHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 38;
            int c = (31 - 5 * a) / b;
            Console.WriteLine($"5 * {a} = {5 * a} - первое действие\n" +
                              $"31 - {5 * a} = {31 - 5 * a} - второе действие\n" +
                              $"{31 - 5 * a} / {b} = {(31 - 5 * a) / b} - последнее действие, получаем целую часть от деления, int на int");
        }
    }
}
