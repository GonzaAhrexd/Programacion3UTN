// See https://aka.ms/new-console-template for more information
/*
 * Contemple 2 jugadores, 2 dados y apuestas

    Tres modos de apuesta (Conservador 1/2, Arriesgado -2/5, desesperado -4/15)

    Cada jugador cuenta con $100 iniciales y un pozo de $10 000

    El juego termina cuando algún jugador quiere o el pozo o el saldo de algún jugador llega a 0

    Hasta 5 clases
  */
using ApuestaDeDados;


Console.WriteLine("Bienvenido al juego de apuestas de dados");
Console.WriteLine("Ingrese el nombre del jugador 1");
string nombreJugador1 = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del jugador 2");
string nombreJugador2 = Console.ReadLine();


Jugador Jugador1 = new Jugador(nombreJugador1, 5000);
Jugador Jugador2 = new Jugador(nombreJugador2, 5000);

Juego juego = new Juego();
/*

while(true){
    Console.WriteLine(Jugador1.getNombre() + " ingrese el monto a apostar");
    double apuestaJugador1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Jugador1.getNombre() + " ingrese el modo de juego que desea realizar: ");
    Console.WriteLine("1. Conservador");
    Console.WriteLine("2. Arriesgado");
    Console.WriteLine("3. Desesperado");
    int modoJuegoJugador1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Jugador1.getNombre + ", qué dado piensa que va a salir?:");
    int numeroJugador1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Jugador2.getNombre() + " ingrese el monto a apostar");
    double apuestaJugador2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Jugador2.getNombre() + " ingrese el modo de juego que desea realizar: ");
    Console.WriteLine("1. Conservador");
    Console.WriteLine("2. Arriesgado");
    Console.WriteLine("3. Desesperado");
    int modoJuegoJugador2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Jugador2.getNombre + ", qué dado piensa que va a salir?:");
    int numeroJugador2 = Convert.ToInt32(Console.ReadLine());
    
    Jugador1.Apostar(apuestaJugador1, modoJuegoJugador1, numeroJugador1);
    Jugador2.Apostar(apuestaJugador2, modoJuegoJugador2, numeroJugador2);

    juego.jugar(Jugador1, Jugador2);

}*/