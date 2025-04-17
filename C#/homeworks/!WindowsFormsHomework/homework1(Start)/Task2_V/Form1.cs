using System.Windows.Forms;

namespace Task2_V
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor("cursor.cur");
            this.TopMost = true;
            timer1.Enabled = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            bool isRunX = Math.Abs(e.X - yura_pictureBox.Location.X) <= 250;
            bool isRunY = Math.Abs(e.Y - yura_pictureBox.Location.Y) <= 250;
            if (isRunX && isRunY)
            {
                Random rand = new Random();
                int newX = rand.Next(0, this.ClientSize.Width - yura_pictureBox.Width);
                int newY = rand.Next(0, this.ClientSize.Height - yura_pictureBox.Height);
                yura_pictureBox.Location = new Point(newX, newY);
            }
        }

        private void Run()
        {
            Random random = new Random();
            int maxX = this.ClientSize.Width - yura_pictureBox.Width;
            int maxY = this.ClientSize.Height - yura_pictureBox.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            yura_pictureBox.Location = new Point(newX, newY);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point locationOfCursor = this.PointToClient(Cursor.Position);
            Rectangle pictureArea = new Rectangle(yura_pictureBox.Location, yura_pictureBox.Size);

            if (pictureArea.Contains(locationOfCursor))
            {
                Run();
            }

            Point centerOfImage = new Point(yura_pictureBox.Location.X + yura_pictureBox.Width / 2, yura_pictureBox.Location.Y + yura_pictureBox.Height / 2);

            double distance = Math.Sqrt(Math.Pow(locationOfCursor.X - centerOfImage.X, 2) + Math.Pow(locationOfCursor.Y - centerOfImage.Y, 2));

            if (distance < 250)
            {
                Run();
            }
        }
    }
}
