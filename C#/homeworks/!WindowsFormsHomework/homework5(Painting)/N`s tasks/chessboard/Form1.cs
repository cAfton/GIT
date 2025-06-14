namespace chessboard
{
    public partial class Form1 : Form
    {
        private Painter painter;
        public Form1()
        {
            InitializeComponent();
            painter = new Painter();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            painter.Draw(g);
        }
    }
}
