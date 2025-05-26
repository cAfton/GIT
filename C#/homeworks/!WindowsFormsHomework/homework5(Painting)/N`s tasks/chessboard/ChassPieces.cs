using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessboard
{
    public class ChassPieces
    {
        public Dictionary<(int,int), Image> FiguresInArrangement = new Dictionary<(int, int), Image>();
        
        public ChassPieces()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    FiguresInArrangement.Add((i, j), Image.FromFile("..\\..\\..\\Images\\null.png"));

                }

            }
            FiguresInArrangement[(1, 1)] = Image.FromFile("..\\..\\..\\Images\\chess-black-rook.png");
            FiguresInArrangement[(2, 1)] = Image.FromFile("..\\..\\..\\Images\\black-knight.png");
            FiguresInArrangement[(3, 1)] = Image.FromFile("..\\..\\..\\Images\\chess-black-bishop.png");
            FiguresInArrangement[(4, 1)] = Image.FromFile("..\\..\\..\\Images\\chess-black-queen.png");
            FiguresInArrangement[(5, 1)] = Image.FromFile("..\\..\\..\\Images\\chess-king-dark.png");
            FiguresInArrangement[(6, 1)] = Image.FromFile("..\\..\\..\\Images\\chess-black-queen.png");
            FiguresInArrangement[(7, 1)] = Image.FromFile("..\\..\\..\\Images\\black-knight.png");
            FiguresInArrangement[(8, 1)] = Image.FromFile("..\\..\\..\\Images\\chess-black-rook.png");
            for (int i = 1; i <= 8; i++)
            {
                FiguresInArrangement[(i, 2)] = Image.FromFile("..\\..\\..\\Images\\chess-pawn-dark.png");
                FiguresInArrangement[(i, 7)] = Image.FromFile("..\\..\\..\\Images\\chess-pawn.png");
            }

            FiguresInArrangement[(1, 8)] = Image.FromFile("..\\..\\..\\Images\\chess-white-rook.png");
            FiguresInArrangement[(2, 8)] = Image.FromFile("..\\..\\..\\Images\\white-knight.png");
            FiguresInArrangement[(3, 8)] = Image.FromFile("..\\..\\..\\Images\\chess-bishop-solid.png");
            FiguresInArrangement[(4, 8)] = Image.FromFile("..\\..\\..\\Images\\chess-white-queen.png");
            FiguresInArrangement[(5, 8)] = Image.FromFile("..\\..\\..\\Images\\chess-king.png");
            FiguresInArrangement[(6, 8)] = Image.FromFile("..\\..\\..\\Images\\chess-white-queen.png");
            FiguresInArrangement[(7, 8)] = Image.FromFile("..\\..\\..\\Images\\white-knight.png");
            FiguresInArrangement[(8, 8)] = Image.FromFile("..\\..\\..\\Images\\chess-white-rook.png");

        }
        public Image FigureOnRequest(int x, int y)
        {
            return FiguresInArrangement[(x, y)];
        }
    }
}
