using System.Runtime.InteropServices;

namespace Cool_cursor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr LoadCursorFromFile(string lpFileName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetCursor(IntPtr hCursor);

        private IntPtr animatedCursor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            animatedCursor = LoadCursorFromFile("Ura_manji.ani");
            if (animatedCursor == IntPtr.Zero)
            {
                MessageBox.Show("Не вдалося завантажити анімований курсор!");
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (animatedCursor != IntPtr.Zero)
            {
                Cursor customCursor = new Cursor(animatedCursor);
                pictureBox1.Cursor = customCursor;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
        }
    }
}
