namespace ExpresionesLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Retorna valor
            Func<int, int> b = (a) => a * 2;
            Action<string> ingresarNombre = (nombre) => Console.WriteLine(nombre);

           int result = b(4);
            Console.WriteLine(result);

        }
    }
}
