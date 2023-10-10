using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGHT = 4;
        public Point[] Points = new Point[LENGHT];

        public void Draw()
        {
                foreach (Point p in Points)
            {
                p.Draw();
            }
        }
        internal Result TryMove(Direction dir)
        {
            Hide();

            var clone = Clone();
            Move(clone, dir);

            var result =  VerifyPosition(clone);
            if (result == Result.SUCESS)
                Points = clone;

            Draw();

            return result;
            
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result ==  Result.SUCESS)
                Points = clone;

            Draw();
            return result;
        }

        private Result VerifyPosition(Point[] newPoints)
        {
            foreach (var p in newPoints)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;
                if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }    
                return Result.SUCESS;
            }
        

        private Point[] Clone() 
        {
           var newPoint = new Point[LENGHT];
            for(int i = 0; i < LENGHT; i++) 
            {
                newPoint[i] = new Point(Points[i]);
            }
            return newPoint;
        }

        public void Move(Point[] pList, Direction dir)
        {
            foreach(var p in pList) 
            {
                p.Move(dir);
            }
        }
        //public void Move(Direction dir)
        //{
        //    Hide();
        //    foreach(Point p in points)
        //    {
        //        p.Move(dir);

        //    }
        //    Draw();
        //}
      

        public abstract void Rotate(Point[] pList);

        public void Hide()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }

        }
    }
}
