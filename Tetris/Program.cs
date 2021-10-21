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

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure s = null;

            while (true)
            {
                s = generator.GetNewFigure();
                for(int i = 0; i < 15; i++)
                {
                    s.Draw();
                    Thread.Sleep(200);
                    s.Hide();
                    s.Move(Direction.DOWN);
                }
                
            }

            
        }
    }
}
