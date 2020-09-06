using System;
using System.IO;
using System.Text;

namespace GameOfLife
{
    public class Import
    {
        public bool[,] ImportTxt(string url)
        {
            //string url = @"C:\Users\Gonzalo\Desktop\Probando.txt";
            string content = System.IO.File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

            for (int  y=0; y < contentLines.Length; y++)
            {
                for (int x=0; x < contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[y,x]=true;
                    }
                }
            } 
            return board;  
        }

    }
}
