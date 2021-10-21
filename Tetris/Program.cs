using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int y1 = 3;
            char c1 = '*';
            Draw(x1, y1, c1);
            int x2 = 2;
            int y2 = 4;
            char c2 = '#';
            Draw(x2, y2, c2);
            Console.ReadKey();
        }
        static void Draw(int x,int y, char c)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
