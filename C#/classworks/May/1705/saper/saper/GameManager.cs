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
                    buttons[i, j].Tag = new ButtonTag(Status.Empty);
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
                button.Tag = new ButtonTag(Status.Empty);
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
                    (sender as Button).Enabled = false;
                    if(((sender as Button).Tag as ButtonTag).ButtonStatus == Status.Mina)
                    {
                        GameOver();
                    }
                }           
                if (WinCheck() == true)
                {
                    if (MessageBox.Show("Ті маладєца", "пірімоґа", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
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
                else
                {
                    (sender as Button).Image = Properties.Resources.Flag;
                    CurrentMines--; 
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentMines)));

                }
            }
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
