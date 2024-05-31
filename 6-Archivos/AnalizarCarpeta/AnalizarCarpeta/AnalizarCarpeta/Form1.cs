using System.IO;
using System.Reflection;
using System.Text;

namespace AnalizarCarpeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                textBox1.Text = string.Empty;
                folderBrowserDialog.Description = "Seleccione una carpeta que contiene archivos de texto";

                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta de la carpeta seleccionada
                    string folderPath = folderBrowserDialog.SelectedPath;

                    // Concatenar el contenido de todos los archivos de texto
                    StringBuilder allText = new StringBuilder();

                    string[] files = Directory.GetFiles(folderPath);
                    long totalSize = files.Sum(file => new FileInfo(file).Length);
                    // Obtener el total del tamaño de la carpeta

                    foreach(string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        //Obten el tamaño del archivo
                        FileInfo info = new FileInfo(file);
                        string fileSize = FormatFileSize(info.Length);
                        double percentage = (double)info.Length / totalSize * 100;
                        string filePercentageString = Math.Round(percentage, 2) + "%";
                        textBox1.Text = textBox1.Text + Environment.NewLine + fileName + " - Tamaño: " + fileSize + " - Espacio: " + filePercentageString;
                    }

                    label2.Visible = true;
                    label2.Text = "El tamaño total de los archivos es: " + FormatFileSize(totalSize);
                   
                }
            }
        }
        private string FormatFileSize(long fileSize)
        {
            string[] unidades = { "B", "KB", "MB", "GB", "TB" };
            double totalLenght = fileSize;
            int order = 0;
            while(totalLenght >= 1024 && order < unidades.Length - 1)
            {
                order++;
                totalLenght = totalLenght/ 1024;
            }
            return Math.Round(totalLenght, 2) + unidades[order];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files | *.txt";
            saveFileDialog.Title = "Texto";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Save the file using the filePath
                // Example code:
                File.WriteAllText(filePath, textBox1.Text + "\n" + label2.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}