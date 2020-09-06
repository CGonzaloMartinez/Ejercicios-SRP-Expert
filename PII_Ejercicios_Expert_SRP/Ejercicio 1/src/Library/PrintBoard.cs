using System;
using System.IO;
using System.Text;
using System.Threading;

namespace GameOfLife
{
    public class GamePrinter
    {
        public void PrintBoard(bool[,] board, GameLogic obj) //variable que representa el tablero
        {
            int width = board.GetLength(1); //variabe que representa ancho del tablero
            int height = board.GetLength(0); //variabe que representa altura del tablero
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if(board[y,x])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                board = obj.NextGeneration(board);
                Thread.Sleep(300);
            }
        }
    }
}
