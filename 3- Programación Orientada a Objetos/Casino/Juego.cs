using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuestaDeDados
{
    public class Juego{
        private List<Dado> dados = new List<Dado>();
        private double dineroEnPoso = 10000;
        private double dineroEnApuestas = 0;

        public List<Dado> getDados() { return dados; }
      
        public double getDineroEnPoso() { return dineroEnPoso; }
        public double getDineroEnApuestas() { return dineroEnApuestas; }

    public Juego()
        {
            Dado dado = new Dado();
            dados.Add(dado);
            Dado dado2 = new Dado();
            dados.Add(dado2);

        }
        public void addDados(Dado dado) { dados.Add(dado); }
        public void setDineroEnPoso(double dineroEnPoso) { this.dineroEnPoso = dineroEnPoso; }
        public void setDineroEnApuestas(double dineroEnApuestas) { this.dineroEnApuestas = dineroEnApuestas; }

        public void jugar(Jugador jugador1, Jugador jugador2){
            dineroEnApuestas = jugador1.getApuesta() + jugador2.getApuesta();
        }
    }
}
