namespace taska2
{
    public partial class Form1 : Form
    {
        private IEnumerator<Quiz> quizes;
        private User CurrentUser;
        public Form1()
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.CurrentUser = login.CurrentUser;
                InitializeComponent();
            }
            else
            {
                Environment.Exit(0);
                return;
            }

            if (CurrentUser.IsAdmin)
            {
                changeVictorToolStripMenuItem.Visible = true;
            }
        }

        private void ShowQuestion(Quiz quiz)
        {
            Question_label1.Text = quiz.Question;
            radioButton1.Text = quiz.Answers[0];
            radioButton2.Text = quiz.Answers[1];
            radioButton3.Text = quiz.Answers[2];
        }
        //
        //Biology
        //
        private void easyBiologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelQuizKeeper newQuizGame = new LevelQuizKeeper();
            List<Quiz> questions = newQuizGame.LoadFromFile(TypesOfQuiz.Biology, HardLevel.Easy);
            quizes = questions.GetEnumerator();
            groupBox1.Visible = true;
            CurrentUser.HistoryOfQuizes.Add(new History());
            quizes.MoveNext();
            ShowQuestion(quizes.Current);
        }

        private void mediumBiologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelQuizKeeper newQuizGame = new LevelQuizKeeper();
            List<Quiz> questions = newQuizGame.LoadFromFile(TypesOfQuiz.Biology, HardLevel.Medium);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelQuizKeeper newQuizGame = new LevelQuizKeeper();
            List<Quiz> questions = newQuizGame.LoadFromFile(TypesOfQuiz.Biology, HardLevel.Hard);
        }
        //
        //Geografy
        //
        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelQuizKeeper newQuizGame = new LevelQuizKeeper();
            List<Quiz> questions = newQuizGame.LoadFromFile(TypesOfQuiz.Geografy, HardLevel.Easy);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelQuizKeeper newQuizGame = new LevelQuizKeeper();
            List<Quiz> questions = newQuizGame.LoadFromFile(TypesOfQuiz.Geografy, HardLevel.Medium);
        }

        private void hardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LevelQuizKeeper newQuizGame = new LevelQuizKeeper();
            List<Quiz> questions = newQuizGame.LoadFromFile(TypesOfQuiz.Geografy, HardLevel.Hard);
        }
        //
        //Button
        //
        private void choose_button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && quizes.Current.RightAnswer == 1)
            {
                CurrentUser.HistoryOfQuizes.Last().Score++;
            }
            if (radioButton2.Checked && quizes.Current.RightAnswer == 2)
            {
                CurrentUser.HistoryOfQuizes.Last().Score++;
            }
            if (radioButton3.Checked && quizes.Current.RightAnswer == 3)
            {
                CurrentUser.HistoryOfQuizes.Last().Score++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;


            if (quizes.MoveNext())
            {
                ShowQuestion(quizes.Current);
            }
            else
            {
                MessageBox.Show($"Your score: {CurrentUser.HistoryOfQuizes.Last().Score}/15", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Visible = false;
            }
        }

        private void myResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string history = "";
            CurrentUser.HistoryOfQuizes.ForEach(elem => history += elem + "\n\n");
            MessageBox.Show(history, "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(ref CurrentUser);
            settings.ShowDialog();
        }



    }
}
