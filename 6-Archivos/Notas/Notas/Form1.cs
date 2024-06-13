namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                File.WriteAllText(filePath + ".txt", textBox1.Text);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
