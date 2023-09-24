﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tetris
{
     class Point
    {
       public int x;
       public int y;
       public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(c);

        }
        
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;

        }
    }
}