using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IShapeProject.EnterShapeDelta
{
    public partial class EnterRectangle : Form
    {
        public IShapeProject.Models.Rectangle rectangle = new Models.Rectangle() { Side1 = 0.01, Side2 = 0.01 };
        public EnterRectangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rectangle.Side1 = (double)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            rectangle.Side2 = (double)numericUpDown2.Value;
        }
    }
}
