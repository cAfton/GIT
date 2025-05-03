using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taska2
{
    public partial class DificultLevel : Form
    {
        public DificultLevel()
        {
            InitializeComponent();
        }

        public HardLevel ShowDialogHardLvl()
        {
            ShowDialog();
            return SelectedLvl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedLvl = HardLevel.Easy;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedLvl = HardLevel.Medium;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedLvl = HardLevel.Hard;
            this.Close();
        }

        public HardLevel SelectedLvl { get; set; }


    }

}
