namespace task1
{
    public partial class Form1 : Form
    {
        private const int Squares = 8;
        private Label[,] labels = new Label[Squares, Squares];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen p = new Pen(Brushes.Black, 2);

            float sideW = this.ClientSize.Width / (float)Squares;
            float sideH = this.ClientSize.Height / (float)Squares;

            for (int i = 0; i < Squares; i++)
            {
                for (int j = 0; j < Squares; j++)
                {
                    Brush brush = ((i + j) % 2 == 0 ? Brushes.Black : Brushes.White);

                    graphics.DrawRectangle(p, sideW * i, sideH * j, sideW, sideH);
                    graphics.FillRectangle(brush, sideW * i, sideH * j, sideW, sideH);

                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
