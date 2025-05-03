using Newtonsoft.Json;
using SeparateJsonToTreeJson.RequestModels;
using SeparateJsonToTreeJson.ResponceModels;
using static SeparateJsonToTreeJson.GPTAnswer;

namespace SeparateJsonToTreeJson
{
    public partial class Form1 : Form
    {
        private InputJson inputJson {  get; set; }
        public Form1()
        {
            InitializeComponent();
            button_start.Enabled = false;
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string read = File.ReadAllText(openFileDialog1.FileName);
                inputJson = JsonConvert.DeserializeObject<InputJson>(read);
                button_start.Enabled = true;

            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            var res = FeatureResolver.ResolveFeatures(inputJson);
            string write = JsonConvert.SerializeObject(res.product);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, write);
            }
        }
    }
}
