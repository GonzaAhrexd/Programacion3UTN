using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuestaDeDados
{
    public class Jugador{
        private string nombre;
        private double saldo;
        private double apuesta;
        private int modoJuego;
        private int numero;


        public Jugador(string nombre, double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
        }
        //Generar setters y getters
        public string getNombre() { return nombre;}
        public double getSaldo() { return saldo; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setSaldo(double saldo) { this.saldo = saldo; }

        public double getApuesta(){
            return apuesta;
        }
        public int getModoJuego(){
            return modoJuego;
        }
        public int getNumero(){
            return numero;
        }
        
        public void Apostar(double apuesta, int modoJuego, int numero)
        {
            this.apuesta = apuesta;
            this.modoJuego = modoJuego;
            this.numero = numero;
        }

    }
}
