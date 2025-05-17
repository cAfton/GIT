namespace Solar_sistem
{
    public partial class Form1 : Form
    {
        private const int N = 8;
        Planet[] planets = new Planet[N];
        System.Windows.Forms.Timer[] timers = new System.Windows.Forms.Timer[N];

        Color[] colors = new Color[] { Color.Gray, Color.OrangeRed, Color.Green, Color.Red, Color.Purple, Color.Yellow, Color.Cyan, Color.Blue};

        double[] turns = { 4.09, 1.60, 1, 0.52, 0.083, 0.033, 0.0117, 0.006 };
        int[] sizes = { 4, 10, 10, 5, 100, 90, 40, 40, };

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= N; i++)
            {
                planets[i - 1] = new Planet(Image.FromFile($"..\\..\\..\\Planets\\{i}.png"), i * 100, sizes[i-1], colors[i - 1], turns[i-1]);

            }
            timers[0] = new System.Windows.Forms.Timer() { Interval = 50};

            timers[0].Tick += TimeTick;
            timers[0].Start();
        }

        private void TimeTick(object sender, EventArgs e)
        {
            for (int i = 0;i < N; i++)
            {
                planets[i].OrbitCalculation();
            }
            //int a = (int)(sender as System.Windows.Forms.Timer).Tag;
            //planets[a].OrbitCalculation();
            Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < N; i++)
            {
                planets[i].Paint(g, Width/2, Height/2);

            }
            Color a = Color.FromArgb(255, 194, 143, 2);
            SolidBrush tmp = new SolidBrush(a);
            g.DrawEllipse(new Pen(Brushes.Yellow, 5), Width/2, Height/2, 10, 10);
            g.FillEllipse(tmp, Width / 2, Height / 2, 10, 10);



        }


    }
}
