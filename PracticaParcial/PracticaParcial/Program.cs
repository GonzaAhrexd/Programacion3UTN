namespace PracticaParcial
{
    internal class Program
    {   
        static PeriodoDeTiempo[] juntarPeriodosDeTiempo(PeriodoDeTiempo[] periodo){


            //Algoritmo de burbuja para ordenar primero los tiempos
            for(int d = 0; d < periodo.Length; d++)
            {
                for(int j = 0; j < periodo.Length - 1; j++)
                {
                    if(periodo[j].getInicio() > periodo[j+1].getInicio())
                    {
                        PeriodoDeTiempo aux = periodo[j];
                        periodo[j] = periodo[j+1];
                        periodo[j+1] = aux;
                    }
                }
            }


            PeriodoDeTiempo[] nuevoModificado = new PeriodoDeTiempo[periodo.Length];
            int iterador = 0;
            int i = 0;
            while(i <  periodo.Length ){

                PeriodoDeTiempo periodoConjunto = new(periodo[i].getPeriodoNombre(),periodo[i].getInicio(),  periodo[i].getFin());

                for(int j = 0; j< periodo.Length; j++)
                {
                 
                    if(periodoConjunto.getInicio() < periodo[j].getInicio() && periodoConjunto.getFin() > periodo[j].getFin() ){
                      //  Console.WriteLine(periodo[j].getPeriodoNombre() + " se solapa a " + periodoConjunto.getPeriodoNombre());
                        periodoConjunto.setPeriodoNombre(periodoConjunto.getPeriodoNombre() + periodo[j].getPeriodoNombre());
                        i++;
                    }else if(periodoConjunto.getInicio() < periodo[j].getInicio() &&  periodo[j].getInicio() < periodoConjunto.getFin() && periodoConjunto.getFin() < periodo[j].getFin())
                    {
                        //Console.WriteLine(periodo[j].getPeriodoNombre() + " se solapa a " + periodoConjunto.getPeriodoNombre() + " pero pasandolo");
                        periodoConjunto.setFin(periodo[j].getFin());
                        periodoConjunto.setPeriodoNombre(periodoConjunto.getPeriodoNombre() + periodo[j].getPeriodoNombre());
                        i++;
                    }
                    else
                    {
                        //Console.WriteLine(periodo[j].getPeriodoNombre() + " no se solapa");
                    }

                    }
                nuevoModificado[iterador] = periodoConjunto;
                iterador++;
                i++;
                
            }

            PeriodoDeTiempo[] nuevoModificadoAcortado = new PeriodoDeTiempo[iterador];

            for(int f=0; f<iterador;f++) {
                nuevoModificadoAcortado[f] = nuevoModificado[f];

            }

            return nuevoModificadoAcortado;
        }
        static void Main(string[] args){


            //Console.WriteLine("Ingrese la cantidad de periodos de tiempo a ingresar:");
            //int cantidad = int.Parse(Console.ReadLine());
            int cantidad = 9;
            PeriodoDeTiempo[] periodos = new PeriodoDeTiempo[cantidad];

            PeriodoDeTiempo tiempo1 = new PeriodoDeTiempo("A", new DateTime(2023, 02, 1, 0, 0, 0), new DateTime(2023, 02, 6, 0, 0, 0));
            PeriodoDeTiempo tiempo2 = new PeriodoDeTiempo("B", new DateTime(2023, 02, 10, 0, 0, 0), new DateTime(2023, 02, 13, 0, 0, 0));
            PeriodoDeTiempo tiempo3 = new PeriodoDeTiempo("C", new DateTime(2023, 02, 3, 0, 0, 0), new DateTime(2023, 02, 7, 0, 0, 0));
            PeriodoDeTiempo tiempo4 = new PeriodoDeTiempo("D", new DateTime(2023, 03, 3, 0, 0, 0), new DateTime(2023, 03, 7, 0, 0, 0));
            PeriodoDeTiempo tiempo5 = new PeriodoDeTiempo("E", new DateTime(2023, 03, 5, 0, 0, 0), new DateTime(2023, 03, 6, 0, 0, 0));
            PeriodoDeTiempo tiempo6 = new PeriodoDeTiempo("F", new DateTime(2023, 03, 5, 0, 0, 0), new DateTime(2023, 05, 6, 0, 0, 0));
            PeriodoDeTiempo tiempo7 = new PeriodoDeTiempo("G", new DateTime(2023, 03, 5, 0, 0, 0), new DateTime(2023, 05, 6, 0, 0, 0));
            PeriodoDeTiempo tiempo8 = new PeriodoDeTiempo("H", new DateTime(2023, 03, 2, 0, 0, 0), new DateTime(2023, 05, 12, 0, 0, 0));
            PeriodoDeTiempo tiempo9 = new PeriodoDeTiempo("I", new DateTime(2023, 03,7, 0, 0, 0), new DateTime(2023, 05, 25, 0, 0, 0));
            periodos[0] = tiempo6;
            periodos[1] = tiempo2;
            periodos[2] = tiempo3;
            periodos[3] = tiempo4;
            periodos[4] = tiempo5;
            periodos[5] = tiempo7;
            periodos[6] = tiempo8;
            periodos[7] = tiempo9;
            periodos[8] = tiempo1;
            PeriodoDeTiempo[] nuevosPeriodosTiempo = juntarPeriodosDeTiempo(periodos);

            foreach(PeriodoDeTiempo per in nuevosPeriodosTiempo)
            {
                Console.WriteLine(per.getPeriodoNombre());
                Console.WriteLine(per.getInicio());
                Console.WriteLine(per.getFin());

            }
        }
    }
}
