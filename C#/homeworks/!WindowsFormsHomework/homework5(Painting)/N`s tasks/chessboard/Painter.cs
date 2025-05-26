using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessboard
{
    public class Painter
    {
        private Pen White;
        private Pen Black;
        private ChassPieces Chass = new ChassPieces();
        public Painter()
        {
            White = new Pen(Color.AntiqueWhite);
            Black = new Pen(Color.DarkCyan);
        }
        public Painter(Pen white, Pen black)
        {
            White = white;
            Black = black;
        }
        public void Draw(Graphics g)
        {
            bool isWhite = true;
            int sizeOfCall = 36;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (isWhite)
                    {
                        PointF p1 = new PointF(i * sizeOfCall, j * sizeOfCall);
                        PointF p2 = new PointF(i * sizeOfCall + sizeOfCall, j * sizeOfCall);
                        PointF p3 = new PointF(i * sizeOfCall + sizeOfCall, j * sizeOfCall + sizeOfCall);
                        PointF p4 = new PointF(i * sizeOfCall, j * sizeOfCall + sizeOfCall);
                        g.FillPolygon(White.Brush, [p1, p2, p3, p4]);
                    }
                    else
                    {
                        PointF p1 = new PointF(i * sizeOfCall, j * sizeOfCall);
                        PointF p2 = new PointF(i * sizeOfCall + sizeOfCall, j * sizeOfCall);
                        PointF p3 = new PointF(i * sizeOfCall + sizeOfCall, j * sizeOfCall + sizeOfCall);
                        PointF p4 = new PointF(i * sizeOfCall, j * sizeOfCall + sizeOfCall);
                        g.FillPolygon(Black.Brush, [p1, p2, p3, p4]);
                    }
                    
                    Image image = Chass.FigureOnRequest(i, j);
                    if (image != null)
                    {
                        g.DrawImage(image, new Point(i * sizeOfCall, j * sizeOfCall));
                    }

                    isWhite = !isWhite;
                }
                isWhite = !isWhite;
            }


        }
    }
}
