namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<String> coincidencia = new List<String>();
        int intentosRestantes = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] palabras = { "Hola", "Palabra", "Random", "Por", "Asignar" };

            String[] ordenPalabrasCoincidentes = new String[palabras.Length * 2];
            List<int> yaGenerado = new List<int>();
            TextBox[] textBoxes = { textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };


            int iterador = 0;
            for(int i = 0; i < palabras.Length; i++)
            {
                int valorUno = numeroRandomSinRepetir(yaGenerado);
                yaGenerado.Add(valorUno);
                int valorDos = numeroRandomSinRepetir(yaGenerado);
                yaGenerado.Add(valorDos);
                ordenPalabrasCoincidentes[valorUno] = palabras[i];
                textBoxes[valorUno].Text = palabras[i];
                ordenPalabrasCoincidentes[valorDos] = palabras[i];
                textBoxes[valorDos].Text = palabras[i];
            }





        }

        public void verificarCoincidencia(String texto)
        {
            if(coincidencia.Count < 2)
            {
            coincidencia.Add(texto);
            }

            if(coincidencia.Count == 2)
            {
                if(coincidencia[0] == coincidencia[1])
                {
                    MessageBox.Show("IGUALES");
                    intentosRestantes--;
                    textBox1.Text = "Intentos restantes: " + intentosRestantes;
                    textBox12.Text = textBox12.Text + Environment.NewLine + coincidencia[0];

                }else{
                    MessageBox.Show("Distintos");
                    ocultarElTextbox(coincidencia[0]);
                    ocultarElTextbox(coincidencia[1]);
                    intentosRestantes--;
                    textBox1.Text = "Intentos restantes: " + intentosRestantes;
                }
                coincidencia.Clear();

                }
        }

        public void ocultarElTextbox(String texto)
        {
            TextBox[] textBoxes = { textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

            foreach(var text in textBoxes)
            {
                if(text.Text == texto)
                {
                    text.Visible = false;
                
                }
                
            }
        }

        public int numeroRandomSinRepetir(List<int> numsNoDisponibles)
        {
            Random random = new Random();
            int RandomGenerate = 0;
            bool isAvailable = false;
            int candidato = 0;
            while(!isAvailable)
            {
                RandomGenerate = random.Next(0, 10);

                isAvailable = true;
                for(int i = 0; i < numsNoDisponibles.Count; i++)
                {
                    if(RandomGenerate == numsNoDisponibles[i])
                    {
                        isAvailable = false;
                    }

                }
            }


            return RandomGenerate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            verificarCoincidencia(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            verificarCoincidencia(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            verificarCoincidencia(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            verificarCoincidencia(textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            verificarCoincidencia(textBox6.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            verificarCoincidencia(textBox7.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox9.Visible = true;
            verificarCoincidencia(textBox9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            verificarCoincidencia(textBox10.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            verificarCoincidencia(textBox8.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox11.Visible = true;
            verificarCoincidencia(textBox11.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}