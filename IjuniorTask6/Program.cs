using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IjuniorTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureInRow = 3;
            int numberPicture = 52;

            Console.WriteLine("Целых рядов: {0}\n" +
                              "Сверх меры: {1}", numberPicture / pictureInRow, numberPicture % pictureInRow);
        }
    }
}
