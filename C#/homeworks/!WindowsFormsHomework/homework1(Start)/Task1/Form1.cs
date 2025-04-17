namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startGame_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your number must be between 1 and 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Random random = new Random();
            List<int> beenNumbers = new List<int>();
            DialogResult result = DialogResult.None;
            while (result != DialogResult.Yes)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next() % 10;
                } while (beenNumbers.Contains(randomNumber));
                result = MessageBox.Show($"Is the number you guessed is {(randomNumber % 10) + 1}?", "Guessing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    beenNumbers.Add(randomNumber);
                }

                if (beenNumbers.Count == 10)
                {
                    DialogResult userChoise = MessageBox.Show("You have been cheating!>:<", "Cheater!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (userChoise == DialogResult.Yes)
                    {
                        Close();
                    }
                    else
                    {
                        while (userChoise != DialogResult.Yes)
                        {
                            userChoise = MessageBox.Show("You HAVE BEEN cheating!!!", "Cheater!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (userChoise == DialogResult.Yes)
                            {
                                Close();
                            }
                        }
                    }
                }
            }
            MessageBox.Show($"I guessed your number in {beenNumbers.Count + 1} temp{(beenNumbers.Count + 1 == 1 ? "" : "s")}", "Final", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
