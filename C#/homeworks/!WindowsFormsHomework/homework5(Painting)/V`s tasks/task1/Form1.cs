using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task1
{
    public partial class Form1 : Form
    {
        private const int Squares = 8;
        private Label[,] labels = new Label[Squares, Squares];

        private string[,] board = new string[8, 8] {
            { "♜", "♞", "♝", "♛", "♚", "♝", "♞", "♜" },
            { "♟", "♟", "♟", "♟", "♟", "♟", "♟", "♟" },
            { "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "" },
            { "", "", "", "", "", "", "", "" },
            { "♙", "♙", "♙", "♙", "♙", "♙", "♙", "♙" },
            { "♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖" }
        };

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


                    Point labelPoint = new Point((int)((sideW * j) + (this.ClientSize.Width * 0.02)), (int)((sideH * i) + (this.ClientSize.Height * 0.02)));
                    labels[i, j] = new Label
                    {
                        Text = board[i, j],
                        Font = new Font("Segoe UI Symbol", (int)(((this.ClientSize.Width * this.ClientSize.Height) * 0.000045))),
                        Location = labelPoint,
                        Tag = $"{Squares - j}{(char)('A' + i)}",
                        AutoSize = true,
                        Size = new Size(20, 20),

                        BackColor = ((i + j) % 2 == 0 ? Color.Black : Color.White),
                        ForeColor = ((i + j) % 2 == 1 ? Color.Black : Color.White),
                        ContextMenuStrip = contextMenuStrip1
                    };
                    this.Controls.Add(labels[i, j]);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Invalidate();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label clickedSquare = contextMenuStrip1.SourceControl as Label;
            MessageBox.Show($"Piece: {clickedSquare.Text}\nLocation: {clickedSquare.Tag}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Label clickedSquare = contextMenuStrip1.SourceControl as Label;

            string tag = clickedSquare.Tag.ToString();
            int x = tag[1] - 'A';
            int y = Squares - int.Parse(tag[0].ToString());

            board[x, y] = "";

            Form1_Resize(sender, e);

            MessageBox.Show($"Piece at location {clickedSquare.Tag} deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
