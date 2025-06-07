using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Editing : Form
    {
        public int Size1 { get; set; }

        public int Size2 { get; set; }
        public Editing(int num, int track1, int track2)
        {
            InitializeComponent();
            switch (num)
            {
                case 1:
                    label2.Visible = false;
                    trackBar2.Visible = false;

                    label1.Text = "Radius";
                    trackBar1.Value = track1;
                    break;
                case 2:
                    label1.Text = "Side 1";
                    trackBar1.Value = track1;
                    label2.Text = "Side 2";
                    trackBar2.Value = track2;
                    break;
                case 3:
                    label2.Visible = false;
                    trackBar2.Visible = false;

                    label1.Text = "Side";
                    trackBar1.Value = track1;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size1 = trackBar1.Value; 
            Size2 = trackBar2.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
