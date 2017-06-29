using System;
using System.Collections.Generic;
using System.Linq;

namespace RectanglePosition
{
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        internal bool IsInside(Rectangle recB)
        {
            return (Top <= recB.Top && Bottom <= recB.Bottom && Left >= recB.Left && Right <= recB.Right) ? true : false;  
        }
    }

    class Position
    {
        static void Main()
        {
            Rectangle recA = GetRectangle();
            Rectangle recB = GetRectangle();

            Console.WriteLine(recA.IsInside(recB) ? "Inside" : "Not inside");

        }

        static Rectangle GetRectangle()
        {
            var lines = Console.ReadLine().Split(' ').Select(int.Parse);
            Rectangle currentRec = new Rectangle();

            currentRec.Left = lines.First();
            currentRec.Top = lines.Skip(1).First();
            currentRec.Width = lines.Skip(2).First();
            currentRec.Height = lines.Skip(3).First();

            return currentRec;
        }
    }
}
