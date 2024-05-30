// See https://aka.ms/new-console-template for more information
/*
 * Cree una aplicación de consola
 * Solicite el ingreso de dos valores por pantalla
 * Al final muestre en forma descriptiva los resultados de aplicar las cuatro operaciones 
 */


// Variables num1 y num2
int num1, num2;

// Se solicita ingresr los valores
Console.WriteLine("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());

//Se guardan los resultados en distintas variables
int suma = num1 + num2;
int resta = num1 - num2;
int multiplicacion = num1 * num2;
//Para la división utilizamos el tipo float por si el resultado es decimal
float division = (float)num1 / num2;
 
Console.WriteLine("El resultado de la suma es: " + suma);
Console.WriteLine("El resultado de la resta es: " + resta);
Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);
Console.WriteLine("El resultado de la división es: " + division);

Console.ReadKey();