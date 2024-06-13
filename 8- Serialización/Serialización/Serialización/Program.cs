using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serialización
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNac;
        double altura;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public double Altura { get => altura; set => altura = value; }
        [JsonIgnore]
        public int Edad => ( DateTime.Now - this.fechaNac ).Days / 365;


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(){Nombre = "Juan", FechaNac = new DateTime(1990, 1, 1), Altura = 1.75};
           
            serializar("persona.json", p1);

            Persona p2 = deserializar("persona.json");
            Console.WriteLine(p1);
        }
        
        static void serializar(String nombreArchivo, Object objeto)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(objeto, options);
            File.WriteAllText(nombreArchivo, json);
        }
        static Persona deserializar(String nombreArchivo)
        {
            string json = File.ReadAllText(nombreArchivo);
            Persona objeto = JsonSerializer.Deserialize<Persona>(json);
            return objeto;
        }   
    }
}
