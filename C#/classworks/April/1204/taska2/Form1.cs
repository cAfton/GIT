using Newtonsoft.Json;
using System.Xml.Linq;

namespace taska2
{
    public partial class Form1 : Form
    {
        int a = 5;
        List<Result> scores;
        HardLevel CurrentLevel;
        TypesOfQuiz CurrentType;


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
            string read = File.ReadAllText($"score.json");
            scores = JsonConvert.DeserializeObject<List<Result>>(read);
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
        private void StartToGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (sender is ToolStripMenuItem menuItem)
            {
                progressBar1.Value = 0;
                string[] stringArr = menuItem.Name.Split('_');
                CurrentLevel = (HardLevel)Enum.Parse(typeof(HardLevel), stringArr[0]);
                CurrentType = (TypesOfQuiz)Enum.Parse(typeof(TypesOfQuiz), stringArr[1]);

                List<Quiz> questions = LevelQuizKeeper.LoadFromFile(CurrentType, CurrentLevel);
                progressBar1.Maximum = questions.Count;
                quizes = questions.GetEnumerator();
                groupBox1.Visible = true;
                CurrentUser.HistoryOfQuizes.Add(new History());
                quizes.MoveNext();
                ShowQuestion(quizes.Current);
                timer1.Start();
                timer2.Start();
                a = 5;
                label1.Text = a.ToString();
                a--;
            }
        }



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

            progressBar1.Increment(1);
            if (quizes.MoveNext())
            {

                timer1.Stop();
                timer2.Stop();
                ShowQuestion(quizes.Current);
                a = 5;
                label1.Text = a.ToString();
                a--;
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer2.Stop();
                timer1.Stop();

                MessageBox.Show($"Your score: {CurrentUser.HistoryOfQuizes.Last().Score}/{progressBar1.Maximum}", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scores.Add(new Result { HardLevel = CurrentLevel, TypesOfQuiz = CurrentType, UserName = CurrentUser.Login, Score = CurrentUser.HistoryOfQuizes.Last().Score, Time = DateTime.Now, NumberOfQestions = progressBar1.Maximum });
                string write = JsonConvert.SerializeObject(scores);
                File.WriteAllText($"score.json", write);
                groupBox1.Visible = false;
            }
        }

        private void myResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string history = "";
            string read = File.ReadAllText($"score.json");
            List<Result> scores = JsonConvert.DeserializeObject<List<Result>>(read);
            scores.Where(x => x.UserName == CurrentUser.Login).ToList().ForEach(result => history += $"{result.HardLevel}, {result.TypesOfQuiz}, {result.Time}, {result.Score}/{result.NumberOfQestions}\n");
            MessageBox.Show(history, "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(ref CurrentUser);
            settings.ShowDialog();
        }

        private void changeVictorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeQuiz changeForm = new ChangeQuiz();
            this.Enabled = false;
            if (changeForm.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            label1.Text = a.ToString();
            a--;
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DificultLevel dificultLevel = new DificultLevel();
                List<Quiz> questions = LevelQuizKeeper.LoadFromFile(openFileDialog1.FileName, dificultLevel.ShowDialogHardLvl());
                progressBar1.Maximum = questions.Count;
                quizes = questions.GetEnumerator();
                groupBox1.Visible = true;
                CurrentUser.HistoryOfQuizes.Add(new History());
                quizes.MoveNext();
                ShowQuestion(quizes.Current);
                timer1.Start();
                timer2.Start();
                a = 5;
                label1.Text = a.ToString();
                a--;
            }



        }

        private void top20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string history = "";
            string read = File.ReadAllText($"score.json");
            List<Result> scores = JsonConvert.DeserializeObject<List<Result>>(read);
            scores
                .Select(x => new
                {
                    PrecenteResult = (double)x.Score/(double)x.NumberOfQestions,
                    TypesOfQuiz = x.TypesOfQuiz,
                    Time = x.Time,
                    HardLevel = x.HardLevel,
                })
                .OrderByDescending(x => x.PrecenteResult)
                .Take(20)
                .ToList()
                .ForEach(result => history += $"{result.HardLevel}, {result.TypesOfQuiz}, {result.Time}, {Math.Round(result.PrecenteResult*100, 2)}%\n");
            MessageBox.Show(history, "History", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
