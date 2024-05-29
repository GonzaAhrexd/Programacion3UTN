using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    namespace Examen
    {
        public class Correo
        {
            private Usuario remitente;
            private Usuario destinatario;
            private String asunto;
            private String cuerpo;

            public Correo(Usuario remitente, Usuario destinatario, String asunto, String cuerpo)
            {
                this.remitente = remitente;
                this.destinatario = destinatario;
                this.asunto = asunto;
                this.cuerpo = cuerpo;
            }
            //Getters
            public Usuario getRemitente()
            {
                return this.remitente;
            }
            public Usuario getDestinatario()
            {
                return this.destinatario;
            }
            public String getAsunto()
            {
                return this.asunto;
            }
            public String getCuerpo()
            {
                return this.cuerpo;
            }
            //Setters
            public void setRemitente(Usuario remitente)
            {
                this.remitente = remitente;
            }
            public void setDestinatario(Usuario destinatario)
            {
                this.destinatario = destinatario;
            }
            public void setAsunto(String asunto)
            {
                this.asunto = asunto;
            }
            public void setCuerpo(String cuerpo)
            {

                this.cuerpo = cuerpo;
            }


        }

    }

}
