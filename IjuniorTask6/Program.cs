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
            int maxRow = numberPicture / pictureInRow;
            int remainderPictures = numberPicture % pictureInRow;


            Console.WriteLine("Целых рядов: {0}\n" +
                              "Сверх меры: {1}", maxRow, remainderPictures);
        }
    }
}
