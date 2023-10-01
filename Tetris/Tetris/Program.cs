using System;
using System.Reflection.Emit;
using System.Security;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.WIDHT, Field.HEIGHT);
            Console.SetBufferSize(Field.WIDHT, Field.HEIGHT);

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
                    currientFigure.TryMove(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    currientFigure.TryMove(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currientFigure.TryMove(Direction.DOWN);
                    break;
                case ConsoleKey.Spacebar:
                    currientFigure.TryRotate();
                    break;




            }
        }
    }
}
