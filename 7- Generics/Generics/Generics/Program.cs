using System.Runtime.CompilerServices;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Los generics, permite definir clases, interfaces, métodos, delegados, etc. que trabajan con un tipo de dato específico, esto permite reutilizar código y tener un código más limpio, ya que no es necesario definir una clase para cada tipo de dato.
            Clase<int> clase = new Clase<int>(1);
            Clase<string> clase2 = new Clase<string>("1");

            Console.WriteLine(clase.GetValor());
        }
    }

    public class Clase<T>
    {
        public T Valor { get; set; }

        public Clase(T valor)
        {
            Valor = valor;
        }

        public T GetValor()
        {
            return Valor;
        }

        public void SetValor(T valor)
        {
            Valor = valor;
        }
        public void SetValor2<T>(T valor)
        {
            Console.WriteLine(valor);
        }
    }
}
