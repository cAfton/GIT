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
    public partial class EnterCircle : Form
    {
        public IShapeProject.Models.Circle circle = new Models.Circle() { Radius = 0.01 };
        public EnterCircle()
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
            circle.Radius = (double)numericUpDown1.Value;
        }
    }
}
