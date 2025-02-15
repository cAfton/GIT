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
    public partial class EnterSquare : Form
    {
        public IShapeProject.Models.Square square = new Models.Square() { Side = 0.01 };

        public EnterSquare()
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
            square.Side = (double)numericUpDown1.Value;
        }
    }
}
