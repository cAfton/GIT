using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class GameManager :INotifyPropertyChanged
    {
        public int NumberOfMin;
        public const int Size = 10;
        public const int SizeOfButton = 50;
        public Button[,] buttons = new Button[Size, Size];
        private Control control;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int CurrentMines {  get; set; }
        public GameManager(int Mins, Control control)
        {
            this.control = control;
            NumberOfMin = Mins;
            CurrentMines = Mins;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    buttons[i, j] = new Button() {Location = new Point(i * SizeOfButton, j * SizeOfButton + 50), Size = new Size(SizeOfButton, SizeOfButton) };
                    buttons[i, j].Tag = new ButtonTag(Status.Empty, i, j);
                    buttons[i, j].MouseDown += ButtonClick;
                    control.Controls.Add(buttons[i, j]);
                }
            }
            

            Label label = new Label();
            label.Location = new Point(5, 5);
            label.AutoSize = true;
            Binding binding = new Binding("Text", this, "CurrentMines");
            binding.Format += (sender, e) => e.Value = $"Current mines: {e.Value}";
            label.DataBindings.Add(binding);
            control.Controls.Add(label);


        }
        public void StartGame()
        {
            Random random = new Random();

            foreach (Button button in buttons)
            {
                (button.Tag as ButtonTag).ButtonStatus = Status.Empty;
                (button.Tag as ButtonTag).Number = 0;
                button.Text = "";
                button.Enabled = true;
                button.Image = null;
                CurrentMines = NumberOfMin;
            }

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
                    //buttons[n, m].Image = Properties.Resources.Bomba;

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
                                //buttons[n + j, m + k].Text = (buttons[n + j, m + k].Tag as ButtonTag).Number.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void GameOver()
        {
            foreach (var button in buttons)
            {
                if ((button.Tag as ButtonTag).ButtonStatus == Status.Mina)
                {
                    button.Image = Properties.Resources.Bomba;
                }
            }
            if(MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
            {
                StartGame();
            }
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            if((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                if ((sender as Button).Image?.Flags != Properties.Resources.Flag.Flags)
                {
                    //(sender as Button).Enabled = false;
                    if (((sender as Button).Tag as ButtonTag).ButtonStatus == Status.Mina)
                    {
                        GameOver();
                    }
                    else
                    {
                        CheckClick(((sender as Button).Tag as ButtonTag).IndexX, ((sender as Button).Tag as ButtonTag).IndexY);
                    }
                }           
                if (WinCheck() == true)
                {
                    if (MessageBox.Show("You cool", "You win!", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    {
                        StartGame();
                    }
                }
            }

            if((e as MouseEventArgs).Button == MouseButtons.Right) 
            {
                if((sender as Button).Image?.Flags == Properties.Resources.Flag.Flags)
                {
                    (sender as Button).Image = null;
                    CurrentMines++; 
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentMines)));
                }
                else if((sender as Button).Text != "")
                {

                    FlagCheck(((sender as Button).Tag as ButtonTag).IndexX, ((sender as Button).Tag as ButtonTag).IndexY);

                }
                else
                {
                    (sender as Button).Image = Properties.Resources.Flag;
                    ((sender as Button).Tag as ButtonTag).ButtonStatus = Status.Flag;

                    CurrentMines--; 
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentMines)));

                }
            }
        }

        private void FlagCheck(int X, int Y)
        {
            int count = 0;
            
            /*

               (-1, -1) (0, -1) (1, -1)
               (-1, 0)  (0, 0)  (1, 0)
               (-1, 1)  (0, 1)  (1, 1)

            */
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (X + i >= 0 || Y + j >= 0 || X + i < Size || Y + j < Size)
                    {
                        if ((buttons[X + i, Y + j].Tag as ButtonTag).ButtonStatus == Status.Flag)
                        {
                            count++;
                        }
                    }
                }
            }


            if (int.Parse(buttons[X, Y].Text) == count)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (X + i >= 0 || Y + j >= 0 || X + i < Size || Y + j < Size)
                        {
                            if ((buttons[X + i, Y + j].Tag as ButtonTag).ButtonStatus == Status.Mina)
                            {
                                GameOver();
                                return;
                            }
                            if((buttons[X + i, Y + j].Tag as ButtonTag).ButtonStatus == Status.Empty)
                            {
                                buttons[X, Y].Text = (buttons[X, Y].Tag as ButtonTag).Number.ToString();
                                buttons[X, Y].Enabled = false;
                            }
                        }
                    }
                }
            }

        }

        /*
           1  1,2,3,4,5,6
           2  1,2,3,4,5,6
           3  1,2,3,4,5,6
           4  1,2,3,4,5,6
           5  1,2,3,4,5,6

        */

        private void CheckClick(int X, int Y)
        {
            if (X < 0 || Y < 0 || X >= Size || Y >= Size)
            {
                return;
            }

            if ((buttons[X, Y].Tag as ButtonTag).ButtonStatus == Status.Number)
            {
                buttons[X, Y].Text = (buttons[X, Y].Tag as ButtonTag).Number.ToString();
                buttons[X, Y].Enabled = false;
                return;
            }
            
            if(buttons[X, Y].Enabled == false)
            {
                return;
            }

            buttons[X, Y].Enabled = false;


            CheckClick(X, Y - 1);
            CheckClick(X + 1, Y);
            CheckClick(X, Y + 1);
            CheckClick(X - 1, Y);


        }
        private bool WinCheck()
        {
            foreach (var item in buttons)
            {
                if (item.Enabled == true && (item.Tag as ButtonTag).ButtonStatus != Status.Mina)
                {
                    return false;
                }
            }
            return true;
        } 

    }
}
