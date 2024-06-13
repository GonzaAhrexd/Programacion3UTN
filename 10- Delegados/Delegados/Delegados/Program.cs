namespace Delegados
{

    public delegate void Delegado(String texto);
    public class Program
    {
        static void Main(string[] args)
        {
            Delegado delegando = ClassA.MethodA;


            delegando("Probando");


        }
    }


    class ClassA
    {
        public static void MethodA(String probando )
        {
            Console.WriteLine("HOla " + probando); 
        }
    }
}
