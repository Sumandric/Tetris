using System;
using System.Reflection.Emit;
using System.Security;

namespace Tetris
{
    class Program
    {
        static FigureGenerator generator;
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.Width, Field.Height);
            Console.SetBufferSize(Field.Width, Field.Height);
                       
           
            generator = new FigureGenerator(Field.Width / 2, 0, Drawer.DEFAULT_SYMBOL);
            Figure currientFigure = generator.GetNewFigure();
            

            while (true)
            {
                if (Console.KeyAvailable)
                {
                   var key = Console.ReadKey(); 
                   var result = HandleKey(currientFigure, key.Key);  
                   ProcessResult(result, ref currientFigure);
                }
            } 
        }
        
        private static bool ProcessResult(Result result, ref Figure currientFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {
                Field.AddFigure(currientFigure);
                Field.TryDeleteLines();
                currientFigure = generator.GetNewFigure();
                return true;
            }
            else
                return false;
        }
        private static Result HandleKey(Figure f, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    return f.TryMove(Direction.LEFT);
                case ConsoleKey.RightArrow:
                    return f.TryMove(Direction.RIGHT);
                case ConsoleKey.DownArrow:
                    return f.TryMove(Direction.DOWN);
                case ConsoleKey.Spacebar:
                    return f.TryRotate();
            }
            return Result.SUCESS;




            }
        }
    }


