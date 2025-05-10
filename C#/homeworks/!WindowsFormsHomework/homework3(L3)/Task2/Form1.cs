using Newtonsoft.Json;
using Task2.Models;

namespace Task2
{
    public partial class Form1 : Form
    {
        public List<Product> Products { get; set; }

        private double Sum { get; set; }
        public Form1()
        {
            InitializeComponent();

            string readP = File.ReadAllText("Products.json");
            Products = JsonConvert.DeserializeObject<List<Product>>(readP);
            textBox_BusketCost.Text = Sum.ToString();

            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var item in Products)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                textBox_cost.Text = Products[comboBox1.SelectedIndex].Cost.ToString();
            }
        }
        /// <summary>
        /// Open Edit Form
        /// </summary>
        /// <param name="num"> 1 - Add, 2 - Edit, 3 - Delete </param>
        private void openEditForm(int num)
        {
            EditForm editForm = new EditForm(num, Products);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                Products = editForm.Upd_Products;
                UpdateComboBox();

                string items = JsonConvert.SerializeObject(Products);
                File.WriteAllText("Products.json", items);

                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "";
                textBox_cost.Text = "";
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openEditForm(1);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openEditForm(2);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openEditForm(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                listBox1.Items.Add($"{Products[comboBox1.SelectedIndex].Name}, {Products[comboBox1.SelectedIndex].Cost}");
                Sum += Products[comboBox1.SelectedIndex].Cost;
                textBox_BusketCost.Text = Sum.ToString();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var item = listBox1.Items[listBox1.SelectedIndex].ToString().Split(' ');
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Sum -= double.Parse(item[1]);
                textBox_BusketCost.Text = Sum.ToString();
            }
        }

    }
}
