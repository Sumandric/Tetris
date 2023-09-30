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
            Figure s;

            while (true)
            {
                FigureFall(out s,generator);
                s.Draw();
            } 
        }

        static void FigureFall(out Figure fig, FigureGenerator generator)
        {
            fig = generator.GetNewFigure();
            fig.Draw();

            for (int i = 0; i < 15; i++)
            {
                fig.Hide();
                fig.Move(Direction.DOWN);
                fig.Draw();
                Thread.Sleep(200);
            }

        }

        //Figure s = generator.GetNewFigure();

        //s.Draw();
        //Thread.Sleep(1000);

        //s.Hide();
        //s.Rotate();
        //s.Draw();

        //Thread.Sleep(1000);
        //s.Hide();
        //s.Move(Direction.LEFT);
        //s.Draw();
        //Thread.Sleep(1000);
        //s.Hide();
        //s.Move(Direction.DOWN);
        //s.Draw();
        //Thread.Sleep(1000);
        //s.Hide();
        //s.Move(Direction.DOWN);
        //s.Draw();
        //Thread.Sleep(1000);
        //s.Hide();
        //s.Move(Direction.RIGHT);
        //s.Draw();
        //Thread.Sleep(1000);
        //s.Hide();
        //s.Rotate();
        //s.Draw();

        //Stick stick = new Stick(6, 6, '*');
        //stick.Draw();


        // Point p1 = new Point(2,3,'*');
        // p1.Draw();

        // Point p2 = new Point()
        // {
        //   x = 4,
        //    y = 5,
        //   c = '#'

        // };

        //  p2.Draw();

        //console.readline();


    }
}
