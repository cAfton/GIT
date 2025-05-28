using System;
using System.Drawing.Imaging;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Image ToDraw;

        private int HeightSq = 30;
        private int WidthSq = 30;
        private int SideTr = 30;
        private int Radius = 30;

        private List<(Image, Point)> Images = new List<(Image, Point)>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDraw = new Bitmap(Properties.Resources.circle_256x256, Radius, Radius);
        }

        private void SquaretoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToDraw = new Bitmap(Properties.Resources.square_256x256, HeightSq, WidthSq);
        }

        private void TriangletoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ToDraw = new Bitmap(Properties.Resources.triangle_256x226, SideTr, SideTr);
        }

        private void CircleeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditShape(1);
        }

        private void SquareeditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditShape(2);
        }

        private void TriangleeditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditShape(3);
        }

        private void EditShape(int num)
        {
            Editing editing;
            switch (num)
            {
                case 1:
                    editing = new Editing(num, Radius, Radius);
                    break;
                case 2:
                    editing = new Editing(num, HeightSq, WidthSq);
                    break;
                case 3:
                    editing = new Editing(num, SideTr, SideTr);
                    break;
                default:
                    editing = new Editing(num, Radius, Radius);
                    break;
            }

            if (editing.ShowDialog() == DialogResult.OK)
            {
                switch (num)
                {
                    case 1:
                        Radius = editing.Size1;
                        ToDraw = new Bitmap(Properties.Resources.circle_256x256, Radius, Radius);
                        break;
                    case 2:
                        HeightSq = editing.Size1;
                        WidthSq = editing.Size2;
                        ToDraw = new Bitmap(Properties.Resources.square_256x256, HeightSq, WidthSq);
                        break;
                    case 3:
                        SideTr = editing.Size1;
                        ToDraw = new Bitmap(Properties.Resources.triangle_256x226, SideTr, SideTr);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Images.Add((new Bitmap(ToDraw), new Point(e.X, e.Y)));
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Choose figure!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int i = 0; i < Images.Count; i++)
            {
                graphics.DrawImage(Images[i].Item1, Images[i].Item2.X - (Images[i].Item1.Width / 2), Images[i].Item2.Y - (Images[i].Item1.Height / 2));
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap toSave = new Bitmap(this.Width, this.Height);

                using (Graphics g = Graphics.FromImage(toSave)) //for drawing on image
                {
                    g.Clear(this.BackColor);
                    for (int i = 0; i < Images.Count; i++)
                    {
                        g.DrawImage(Images[i].Item1, Images[i].Item2);
                    }
                }

                toSave.Save(saveFileDialog1.FileName);
            }
        }
    }
}
