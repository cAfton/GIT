using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2;
using Task2.Models;

namespace Task2
{
    public partial class EditForm : Form
    {
        private int Type { get; set; }

        public List<Product> Upd_Products { get; set; }
        public EditForm(int type, List<Product> list)
        {
            InitializeComponent();
            Type = type;
            Upd_Products = list;

            comboBox1.Items.Clear();
            foreach (var item in list)
            {
                comboBox1.Items.Add(item.Name);
            }

            switch (type)
            {
                case 1:
                    comboBox1.Visible = false;
                    button1.Text = "Add";
                    break;
                case 2:
                    button1.Text = "Save";
                    break;
                case 3:
                    groupBox_Edit.Visible = false;
                    button1.Text = "Delete";
                    break;

                default:
                    Close();
                    break;
            }

            button1.Enabled = false;
        }


        private void AddNew()
        {
            Upd_Products.Add(new Product { Name = textBox_Name.Text, Characteristic = textBox_Characteristic.Text, Description = richTextBox_Description.Text, Cost = (double)numericUpDown_Cost.Value });
        }

        private void Delete()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Upd_Products.Remove(Upd_Products[comboBox1.SelectedIndex]);
            }
        }

        private void Edit()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Upd_Products[comboBox1.SelectedIndex].Name = textBox_Name.Text;
                Upd_Products[comboBox1.SelectedIndex].Characteristic = textBox_Characteristic.Text;
                Upd_Products[comboBox1.SelectedIndex].Description = richTextBox_Description.Text;
                Upd_Products[comboBox1.SelectedIndex].Cost = (double)numericUpDown_Cost.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case 1:
                    AddNew();
                    break;
                case 2:
                    Edit();
                    break;
                case 3:
                    Delete();
                    break;

                default:
                    Close();
                    break;
            }
            DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Name.Text = Upd_Products[comboBox1.SelectedIndex].Name;
            textBox_Characteristic.Text = Upd_Products[comboBox1.SelectedIndex].Characteristic;
            richTextBox_Description.Text = Upd_Products[comboBox1.SelectedIndex].Description;
            numericUpDown_Cost.Value = (decimal)Upd_Products[comboBox1.SelectedIndex].Cost;

            button1.Enabled = true;

        }
    }
}
