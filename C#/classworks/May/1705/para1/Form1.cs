namespace para1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point Formula1(int x) //y=x^2
        {
            return new Point(x, -(int)Math.Pow(x-500, 2) + 500);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics a = e.Graphics;
            Pen p = new Pen(Brushes.Black, 10);
            List<Point> points = new List<Point>();
            for (int i = -500; i < 5000; i++)
            {
                points.Add(Formula1(i));
            }
            Point[] s = points.ToArray();
            a.DrawPolygon(p, s);

        }
    }
}
