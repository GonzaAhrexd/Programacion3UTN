using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class PeriodoDeTiempo{
        private string periodoNombre;
        private DateTime inicio = new DateTime();
        private DateTime fin = new DateTime();
        private TimeSpan periodo_de_tiempo = new TimeSpan();

        public PeriodoDeTiempo(string nombre, DateTime inicio, DateTime fin)
        {
            this.periodoNombre = nombre;
            this.inicio = inicio;
            this.fin = fin;
            this.periodo_de_tiempo = fin - inicio;
        }

        public DateTime getInicio ()
        {
            return inicio;
        }
        public DateTime setInicio(DateTime inicio)
        {
            this.inicio = inicio;
            return inicio;
        }  
        public DateTime getFin ()
        {
            return fin;
        }
        public DateTime setFin(DateTime fin)
        {
            this.fin = fin;
            return fin;
        

        }

        public string getPeriodoNombre ()
        {
            return periodoNombre;
        }
        public void setPeriodoNombre(string periodoNombre)
        {
            this.periodoNombre = periodoNombre;
        }
    }
}
