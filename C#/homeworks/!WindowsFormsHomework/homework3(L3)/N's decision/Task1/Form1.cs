namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
