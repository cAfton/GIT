using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
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
        public int NumberOfMin;
        public const int Size = 10;
        public const int SizeOfButton = 50;
        public Button[,] buttons = new Button[Size, Size];
        private Control control;
        public GameManager(int Mins, Control control)
        {
            this.control = control;
            NumberOfMin = Mins;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    buttons[i, j] = new Button() {Location = new Point(i * SizeOfButton, j * SizeOfButton), Size = new Size(SizeOfButton, SizeOfButton) };
                    buttons[i, j].Tag = new ButtonTag(Status.Empty);
                    control.Controls.Add(buttons[i, j]);
                }
            }
        }
        public void StartGame()
        {
            Random random = new Random();

            for (int i = 0; i < NumberOfMin; i++)
            {
                int n = random.Next(Size), m = random.Next(Size);
                if (((ButtonTag)buttons[n, m].Tag).ButtonStatus == Status.Mina)
                {
                    i--;
                    continue;
                }
                else{
                    (buttons[n, m].Tag as ButtonTag).ButtonStatus = Status.Mina;
                    buttons[n, m].Text = "";
                    buttons[n, m].Image = Properties.Resources.Bomba;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int k = -1; k <= 1; k++)
                        {
                            if ((n + j >= 0 && m + k >= 0 && n + j < Size && m + k < Size) && (buttons[n + j, m + k].Tag as ButtonTag).ButtonStatus != Status.Mina)
                            {
                                if ((buttons[n + j, m + k].Tag as ButtonTag).ButtonStatus == Status.Empty)
                                {
                                    (buttons[n + j, m + k].Tag as ButtonTag).ButtonStatus = Status.Number;
                                    (buttons[n + j, m + k].Tag as ButtonTag).Number = 1;
                                }
                                else
                                {
                                    (buttons[n + j, m + k].Tag as ButtonTag).Number++;
                                }
                                buttons[n + j, m + k].Text = (buttons[n + j, m + k].Tag as ButtonTag).Number.ToString();
                            }
                        }
                    }

                }
            }




        }

    }
}
