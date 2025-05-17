using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saper
{

    public enum Status
    {
        Mina, Empty, Number, Flag
    }
    public class GameManager
    {
        public int MiNumberOfMin;
        public const int Size = 10;
        public Button[,] buttons = new Button[Size, Size];
        private Control control;
        GameManager(int Mins, Control control)
        {
            this.control = control;
            MiNumberOfMin = Mins;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    buttons[i, j] = new Button();
                }
            }
        }
        public void StartGame()
        {
            Random random = new Random();

            for (int i = 0; i < MiNumberOfMin; i++)
            {
                //fix to not set mina in mina
                buttons[random.Next(Size), random.Next(Size)].Tag = Status.Mina;
            }

        }

    }
}
