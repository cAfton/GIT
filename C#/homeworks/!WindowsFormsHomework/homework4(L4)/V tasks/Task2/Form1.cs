using Microsoft.VisualBasic;
using System.IO;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode node = new TreeNode(drive.Name);
                    node.Tag = drive.Name;
                    node.Nodes.Add("");
                    treeView1.Nodes.Add(node);
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();

            try
            {
                List<string> insides = Directory.GetDirectories(e.Node.Tag.ToString()/*<-path*/).ToList();
                foreach (string file in insides)
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(file));
                    subNode.Tag = file;
                    if (Directory.GetDirectories(file).Length > 0)
                        subNode.Nodes.Add("");
                    e.Node.Nodes.Add(subNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                e.Node.Nodes.Add("❌ Access denied!");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            textBox1.Text = e.Node.Tag.ToString();

            try
            {
                foreach (string file in Directory.GetFiles(e.Node.Tag.ToString()))
                {
                    listView1.Items.Add(new ListViewItem(Path.GetFileName(file)));
                }
                foreach (string folder in Directory.GetDirectories(e.Node.Tag.ToString()))
                {
                    listView1.Items.Add(new ListViewItem(Path.GetFileName(folder)));
                }
            }
            catch (UnauthorizedAccessException)
            {
                e.Node.Nodes.Add("❌ Access denied!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                //File.Delete(textBox1.Text);
                Directory.Delete(textBox1.Text);
                treeView1.SelectedNode.Remove();

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("The directory is not empty!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Input name:", "Name");
            Directory.CreateDirectory($"{textBox1.Text}\\{name}");
            TreeNode newNode = new TreeNode(Path.GetFileName(name));
            newNode.Tag = $"{textBox1.Text}\\{name}";
            treeView1.SelectedNode.Nodes.Add(newNode);
        }
    }
}
