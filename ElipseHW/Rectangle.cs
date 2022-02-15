using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElipseHW
{
    public class Rectangle
    {
        public Point LeftTopPoint { get; private set; }
        public Point RightBottomPoint { get; private set; }

        public Rectangle(Point leftTopPoint, Point rightBottomPoint)
        {
            if (leftTopPoint.Y < rightBottomPoint.Y)
            {
                throw new ArgumentException("Right bottom point is higher than left top point");
            }
            if (leftTopPoint.X > rightBottomPoint.X)
            {
                throw new ArgumentException("Left top point is righter than right bottom point");
            }

            LeftTopPoint = leftTopPoint;
            RightBottomPoint = rightBottomPoint;
        }

        public int GetSquare()
        {
            int height = LeftTopPoint.Y - RightBottomPoint.Y;
            int width = RightBottomPoint.X - LeftTopPoint.X;
            return height * width;
        }
    }
}
