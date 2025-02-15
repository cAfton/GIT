using IShapeProject.EnterShapeDelta;
using IShapeProject.Interfaces;
using IShapeProject.Models;

namespace IShape
{
    public partial class Form1 : Form
    {
        private IShapeCalculate currentShape;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var newForm = new EnterCircle();
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    currentShape = newForm.circle;
                    label1.Text = $"Radius: {newForm.circle.Radius}";
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var newForm = new EnterSquare();
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    currentShape = newForm.square;
                    label1.Text = $"Side: {newForm.square.Side}";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultArea = currentShape.CalculateArea();
            double resutPer = currentShape.CalculatePerimeter();
            MessageBox.Show($"Area: {resultArea}\nPerimetr: {resutPer}");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                var newForm = new EnterRectangle();
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    currentShape = newForm.rectangle;
                    label1.Text = $"Side 1: {newForm.rectangle.Side1}    Side 2: {newForm.rectangle.Side2}";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
