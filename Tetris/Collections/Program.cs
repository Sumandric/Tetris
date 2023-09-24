using System;
using Tetris;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[5];
            nums1[0] = 1;
            nums1[1] = 2;

            foreach (int i in nums1)
            {
                Console.WriteLine(i);
            }

            Point[] points = new Point[3];
            points[0] = new Point(1, 2, '*');
            points[1] = new Point(3, 4, '#');
            points[2] = new Point(5, 6, '*');

            foreach(Point p in points)
            {
                p.Draw();
            }

            Console.ReadLine();
        }
    }
}
