using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<User> users = ConectorDataBase.GetUsers();
        }
    }
}
