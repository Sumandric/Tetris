using System;
using System.Reflection.Emit;
using System.Security;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure currientFigure = generator.GetNewFigure();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                   ConsoleKeyInfo key = Console.ReadKey();  
                   HandleKey(currientFigure, key);
                }
            } 
        }

        private static void HandleKey(Figure currientFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currientFigure.Move(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow: 
                    currientFigure.Move(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currientFigure.Move(Direction.DOWN);
                    break;


            }
        }
    }
}
