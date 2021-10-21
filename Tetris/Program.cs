using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(2, 3, '*');
            s.Draw();
            s.Hide();
            Thread.Sleep(500);
            s.Move(Direction.RIGHT);
            s.Draw();

            Console.ReadKey();
        }
    }
}
