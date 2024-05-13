using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzamientoDeDados
{
   
public class Dado{
        private int valorEnCabecera = 0;
        private int valorEnBase = 0;
        private int valorEnDerecha = 0;
        private int valorEnIzquierda = 0;
        private int valorEnFrente = 0;
        private int valorEnAtras = 0;
        private int[] valores = new int[] { 1, 2, 3, 4, 5, 6 };

        public Dado(){
            valorEnCabecera = valores[0];
            valorEnBase = valores[1];
            valorEnDerecha = valores[2];
            valorEnIzquierda = valores[3];
            valorEnFrente = valores[4];
            valorEnAtras = valores[5];
        }

        public int GetValorEnCabecera()
        {
            return valorEnCabecera;
        }

        public int GetValorEnBase()
        {
            return valorEnBase;
        }

        public int GetValorEnDerecha()
        {
            return valorEnDerecha;
        }

        public int GetValorEnIzquierda()
        {
            return valorEnIzquierda;
        }

        public int GetValorEnFrente()
        {
            return valorEnFrente;
        }

        public int GetValorEnAtras()
        {
            return valorEnAtras;
        }

        public void LanzarDado(){
            Random random = new Random();
            int valor = random.Next(1, 6);
            int valorCopia = valor;
            int i = 0;
            do{
                valores[i] = valor;
                valor++;
                if(valor==6){
                    valor = 1;
                }
                i++;
            } while(valor!=valorCopia);

            valorEnCabecera = valores[0];
            valorEnBase = valores[1];
            valorEnDerecha = valores[2];
            valorEnIzquierda = valores[3];
            valorEnFrente = valores[4];
            valorEnAtras = valores[5];

        }
        public void mostrarTodasLasCaras(){
            Console.WriteLine("Cabecera: " + valorEnCabecera);
            Console.WriteLine("Base: " + valorEnBase);
            Console.WriteLine("Derecha: " + valorEnDerecha);
            Console.WriteLine("Izquierda: " + valorEnIzquierda);
            Console.WriteLine("Frente: " + valorEnFrente);
            Console.WriteLine("Atras: " + valorEnAtras);
        }
        public string EncontrarNumero(int numero){
            String[] posicionesDado = ["Cabecera", "Base", "Derecha", "Izquierda", "Frente", "Atras"];
            int numberFound = 0;
            for(int i = 0;i < 6; i++){
                if(valores[i] == numero){
                    numberFound = i;
                    break;
                }
            }
            if(numberFound != 0){
                return "El número " + numero + " se encuentra en la posición " + posicionesDado[numberFound];
            }
            return "No se encuentra";
        }
    }
}
