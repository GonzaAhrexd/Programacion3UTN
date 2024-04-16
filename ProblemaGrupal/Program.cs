/*
 * Tome por teclado la altura en cm de cada persona y cárguela en un arreglo. 
 * Calcular la media y la desviación estándar de un conjunto de 10 personas.
 * Presente los resultados obtenidos.
 * Muestre qué alturas se encuentran por encima de la media y por debajo de ella.
 * Muestre qué alturas se encuentran dentro del rango definido por la desviación estándar.
 */

double[] alturas = { 165, 164, 175, 185, 190, 150, 150, 168, 170, 172 };

double calcularMedia(double[] alturas) {
    double sumaAlturas = 0;
    for (int i = 0; i < 10; i++){

        sumaAlturas += alturas[i];
       
    }
    

    return sumaAlturas / alturas.Length; //Devuelve media
}
double calcularVarianza(double[] alturas){
    double[] alturasVarianza = alturas;
    double media = calcularMedia(alturas);
    for (int i = 0; i < 10; i++){
        alturasVarianza[i]=Math.Pow(alturasVarianza[i] - media, 2);
    }
    return calcularMedia(alturasVarianza);
}

double calcularDesviacion(double[] alturas){
    return Math.Sqrt(calcularVarianza(alturas));
}


//double[] alturasPedir = new double[10];
double[] alturasPedir = alturas;

/*
for (int i = 0; i < 10; i++){
    Console.WriteLine("Ingrese la altura de la persona " + i);
    alturasPedir[i] = int.Parse(Console.ReadLine());
     
}*/

double[] alturasEncimaMedia = new double[10];
double[] alturasDebajoMedia = new double[10];
double media = calcularMedia(alturasPedir);


int cantDebajo = 0;
int cantEncima = 0;

foreach (double altura in alturasPedir)
{

    if (altura < media)
    {
        alturasDebajoMedia[cantDebajo] = altura;
        cantDebajo++;

    }
    else
    {
        alturasEncimaMedia[cantEncima] = altura;
        cantEncima++;
    }
}


//double[] alturasVarianza = alturas;

double desviacionEstandar = calcularDesviacion(alturasPedir);
Console.WriteLine("Desviacion estandar: " + desviacionEstandar);
Console.WriteLine("Las alturas que se encuentran por encima de la media son: ");
foreach (double altura in alturasEncimaMedia){
    Console.Write(altura!=0 ? altura + "," : "");
}
Console.WriteLine("");

Console.WriteLine("Las alturas que se encuentran por debajo de la media son: ");
foreach (double altura in alturasDebajoMedia){
     Console.Write(altura!=0 ? altura + "," : "" );
}

