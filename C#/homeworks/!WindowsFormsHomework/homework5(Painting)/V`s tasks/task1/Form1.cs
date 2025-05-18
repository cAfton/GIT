using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task1
{
    public partial class Form1 : Form
    {
        private const int Squares = 8;
        private Label[,] labels = new Label[Squares, Squares];

        private readonly string[,] board = new string[8, 8] {
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
            float sideW = this.ClientSize.Width / (float)Squares;
            float sideH = this.ClientSize.Height / (float)Squares;
            for (int i = 0; i < Squares; i++)
            {
                for (int j = 0; j < Squares; j++)
                {
                    Point labelPoint = new Point((int)(sideW * i + 20), (int)(sideH * i + 20));
                    labels[i, j] = new Label
                    {
                        Text = board[i, j],
                        Font = new Font("Segoe UI Symbol", 28),
                        Location = labelPoint,
                        Tag = $"{Squares - j}{(char)('A' + (Squares - i - 1))}",
                        AutoSize = true,
                        Size = new Size(50, 20),

                        BackColor = Color.Black/*((i + j) % 2 == 1 ? Color.Black : Color.White)*/,
                        ForeColor = Color.White/*((i + j) % 2 == 1 ? Color.Black : Color.White)*/,

                        Visible = true
                    };
                    this.Controls.Add(labels[i, j]);
                }
            }
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
