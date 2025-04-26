using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace taska2
{
    public partial class ChangeQuiz : Form
    {
        List<Quiz> list = new List<Quiz>();

        private bool UnsavedQuestion;

        public ChangeQuiz()
        {
            InitializeComponent();
            UnsavedQuestion = false;
        }

        private void ChangeUnsavedOperation(bool a)
        {
            UnsavedQuestion = a;

            comboBox1.Enabled = !a;
            comboBox2.Enabled = !a;
            comboBox3.Enabled = !a;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UnsavedQuestion == false)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                //ChangeUnsavedOperation();
                MessageBox.Show("Not saved!", "Error");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UnsavedQuestion == false)
            {
                comboBox3.Enabled = true;

                list = LevelQuizKeeper.LoadFromFile((TypesOfQuiz)comboBox1.SelectedIndex, (HardLevel)comboBox2.SelectedIndex);

                foreach (Quiz quiz in list)
                {
                    comboBox3.Items.Add(quiz.Question);
                }


            }
            else
            {
                //ChangeUnsavedOperation();

                MessageBox.Show("Not saved!", "Error");
            }


        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UnsavedQuestion == false)
            {
                textBoxQuestion.Text = comboBox3.SelectedItem.ToString();

                textBoxAnsvers1.Text = list[comboBox3.SelectedIndex].Answers[0].ToString();
                textBoxAnsvers2.Text = list[comboBox3.SelectedIndex].Answers[1].ToString();
                textBoxAnsvers3.Text = list[comboBox3.SelectedIndex].Answers[2].ToString();
               

                int rightAnswerNumber = list[comboBox3.SelectedIndex].RightAnswer;
                string radioButton = $"radioButton{rightAnswerNumber}";
                RadioButton tmp = this.GetType().GetField(radioButton, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).GetValue(this) as RadioButton;
                tmp.Checked = true;

                ChangeUnsavedOperation(false);
            }
            else
            {
                //ChangeUnsavedOperation();

                MessageBox.Show("Not saved!", "Error");
            }

        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            ChangeUnsavedOperation(true);


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (UnsavedQuestion == true)
            {
                list[comboBox3.SelectedIndex].Question = textBoxQuestion.Text;
                list[comboBox3.SelectedIndex].Answers[0] = textBoxAnsvers1.Text;
                list[comboBox3.SelectedIndex].Answers[1] = textBoxAnsvers2.Text;
                list[comboBox3.SelectedIndex].Answers[2] = textBoxAnsvers3.Text;
                for (int i = 1; list[comboBox3.SelectedIndex].Answers.Length >= i; i++)
                {
                    string radioButton = $"radioButton{i}";
                    RadioButton tmp = this.GetType().GetField(radioButton, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).GetValue(this) as RadioButton;
                    if (tmp.Checked == true)
                    {
                        list[comboBox3.SelectedIndex].RightAnswer = i;
                        break;
                    }
                }
                ChangeUnsavedOperation(false);


                string read = File.ReadAllText($"{comboBox1.SelectedItem}.json");
                LevelQuizKeeper saveNewQuizes = JsonConvert.DeserializeObject<LevelQuizKeeper>(read);

                saveNewQuizes.GetType().GetProperty($"Quizes_{comboBox2.SelectedItem}").SetValue(saveNewQuizes, list);

                string save = JsonConvert.SerializeObject(saveNewQuizes);
                Console.WriteLine(save);
                File.WriteAllText($"{comboBox1.SelectedItem}.json", save);
            }


        }

        private void ChangeQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnsavedQuestion == false)
            {
                textBoxQuestion.Clear();
                textBoxAnsvers1.Clear();
                textBoxAnsvers2.Clear();
                textBoxAnsvers3.Clear();

                Quiz tmp = new Quiz();
                list.Add(tmp);

                comboBox3.Items.Add(tmp.Question.ToString());

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUnsavedOperation(true);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxQuestion.Text = comboBox3.SelectedItem.ToString();

            textBoxAnsvers1.Text = list[comboBox3.SelectedIndex].Answers[0].ToString();
            textBoxAnsvers2.Text = list[comboBox3.SelectedIndex].Answers[1].ToString();
            textBoxAnsvers3.Text = list[comboBox3.SelectedIndex].Answers[2].ToString();

            int rightAnswerNumber = list[comboBox3.SelectedIndex].RightAnswer;
            string radioButton = $"radioButton{rightAnswerNumber}";
            RadioButton tmp = this.GetType().GetField(radioButton, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance).GetValue(this) as RadioButton;
            tmp.Checked = true;
            ChangeUnsavedOperation(false);
        }
    }
}
