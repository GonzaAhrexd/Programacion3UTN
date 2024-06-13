namespace AnalizarArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribirTxt("C:\\Users\\ryrco\\OneDrive\\UTN\\TUP2_1\\Programación3\\Programación3Practica\\6-Archivos\\AnalisisDeArchivos\\AnalizarArchivos\\AnalizarArchivos\\test.txt", ["Hola", "Cómo", "Estás"]);

            leerTxt("C:\\Users\\ryrco\\OneDrive\\UTN\\TUP2_1\\Programación3\\Programación3Practica\\6-Archivos\\AnalisisDeArchivos\\AnalizarArchivos\\AnalizarArchivos\\test.txt");
        }


        // Leer textos desde un archivo
        public static void leerTxt(String path)
        {
            FileInfo file = new FileInfo(@path);
            FileStream read = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(read);

            string input = null;
            while((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

        }

        // Escribir texto desde consola
        public static void escribirTxt(String path, String[] texto)
        {
            FileInfo file = new FileInfo(@path);
            FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                foreach (String text in texto)
                {
                    sw.WriteLine(text);
                }
            }

            fs.Close();
        }
    }
}
