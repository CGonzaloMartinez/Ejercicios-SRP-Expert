using System;
using System.IO;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
           Import  txt1 = new Import();
           GamePrinter printer = new GamePrinter();
           GameLogic game= new GameLogic();
           printer.PrintBoard(txt1.ImportTxt(@"C:\Users\Gonzalo\Desktop\Probando1.txt"), game);
        }
    }
}


