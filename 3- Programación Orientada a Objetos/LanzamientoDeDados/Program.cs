// See https://aka.ms/new-console-template for more information
using LanzamientoDeDados;

Dado dado = new Dado();


Console.WriteLine("Lanzando dado...");
dado.LanzarDado();

int numero = 0;

try
{
    Console.WriteLine("Ingrese qué numero piensa que va a salir: ");
    numero = int.Parse(Console.ReadLine());
    if(numero > 6 || numero < 1)
    {
        throw new Exception();
    }

    if(numero == dado.GetValorEnCabecera())
    {
        Console.WriteLine("Acertaste!");
        Console.ReadLine(); 
    }
    else
    {
        Console.WriteLine("El número en la cabecera es " + dado.GetValorEnCabecera());
        Console.WriteLine(dado.EncontrarNumero(numero));
        Console.ReadLine();

    }


}
catch(Exception e)
{
    Console.WriteLine("Ingrese un número válido");
}

