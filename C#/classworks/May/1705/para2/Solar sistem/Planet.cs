using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_sistem
{
    public class Planet
    {
        private Image Image;
        private double Degree;
        private int Length;
        private Point Point;
        private int Size;
        public Pen Pen;
        private double Turn;

        public Planet(Image image, int length, int size, Color color, double turn)
        {
            Image = image;
            Degree = 0;
            Length = length;
            Size = size;
            Pen = new Pen(color, 2);
            Turn = turn;
        }
        public void OrbitCalculation()
        {
            Point = new Point((int)(Length * Math.Cos(Degree * Math.PI / 180)), (int)(Length * Math.Sin(Degree * Math.PI / 180)));
            Point.X-=Size/2;
            Point.Y-=Size/2;
            Degree += Turn;


        }

        public void Paint(Graphics g, int Width, int Height) {
            var destImage = new Bitmap(Image, Size, Size);


            g.DrawImage(destImage, new Point(Point.X + Width, Point.Y + Height));
            //g.DrawEllipse(Pen, Point.X + Width, Point.Y + Height, Size, Size);
        }

    }
}
