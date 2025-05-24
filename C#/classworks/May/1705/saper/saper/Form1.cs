namespace saper
{
    public partial class Form1 : Form
    {
        private GameManager gameManager {  get; set; }
        public Form1()
        {
            InitializeComponent();
            gameManager = new GameManager(10, this);
            gameManager.StartGame();
        }

    }
}
