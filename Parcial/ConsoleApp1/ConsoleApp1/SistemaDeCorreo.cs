using ConsoleApp1.Examen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SistemaDeCorreo
    {
        private Usuario usuarioAlQuePertenece;
        private Correo[] correosRecibidos = new Correo[100];
        private int cantidadDeCorreosRecibidos = 0;
        private Correo[] correosEnviados = new Correo[100];
        private int cantidadDeCorreosEnviados = 0;

        public SistemaDeCorreo(Usuario usuario)
        {
            this.usuarioAlQuePertenece = usuario;
        }

        public Usuario getUsuarioAlQuePertenece()
        {
            return this.usuarioAlQuePertenece;
        }

        // Revisar correos
        public void revisarCorreosRecibidos()
        {
            if(this.cantidadDeCorreosRecibidos != 0)
            {
                for(int i = 0; i < cantidadDeCorreosRecibidos; i++)
                {
                    if(this.correosRecibidos[i].getAsunto() != "Correo eliminado")
                    {
                        Console.WriteLine("***************************************");
                        Console.WriteLine("Correo número " + i + 1);
                        Console.WriteLine("Asunto: " + this.correosRecibidos[i].getAsunto());
                        Console.WriteLine("Remitente: " + this.correosRecibidos[i].getRemitente().getDireccion());
                        Console.WriteLine("Cuerpo: " + this.correosRecibidos[i].getCuerpo());
                        Console.WriteLine("***************************************");
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay correos");
            }
        }
        public void revisarCorreosEnviados()
        {

            if(this.cantidadDeCorreosEnviados != 0)
            {
                for(int i = 0; i < cantidadDeCorreosEnviados; i++)
                {
                    Console.WriteLine("***************************************");
                    Console.WriteLine("Correo número " + i + 1);
                    Console.WriteLine("Asunto: " + this.correosEnviados[i].getAsunto());
                    Console.WriteLine("Destinatario: " + this.correosEnviados[i].getDestinatario().getDireccion());
                    Console.WriteLine("Cuerpo: " + this.correosEnviados[i].getCuerpo());
                    Console.WriteLine("***************************************");
                }
            }
            else
            {
                Console.WriteLine("No hay correos");
            }
        }

        public void enviarCorreo(out Correo envio, out string Destinatario)
        {

            Console.WriteLine("Ingrese el destinatario: ");
            Destinatario = Console.ReadLine();
            Console.WriteLine("Ingrese el asunto: ");
            String Asunto = Console.ReadLine();
            Console.WriteLine("Ingrese el cuerpo: ");
            String Cuerpo = Console.ReadLine();

            Usuario usuarioDestinatario = new Usuario(Destinatario);

            Correo nuevoCorreoAEnviar = new Correo(this.usuarioAlQuePertenece, usuarioDestinatario, Asunto, Cuerpo);
            this.cantidadDeCorreosEnviados += 1;
            correosEnviados[cantidadDeCorreosEnviados - 1] = nuevoCorreoAEnviar;
            envio = nuevoCorreoAEnviar;
        }

        public void recibirCorreo(Correo correoARecibir)
        {

            this.correosRecibidos[cantidadDeCorreosRecibidos] = correoARecibir;
            this.cantidadDeCorreosRecibidos++;
        }

        public void eliminarCorreo(int correoAEliminar)
        {
            Correo correoEliminado = new Correo(new Usuario("Eliminado"), new Usuario("eliminado"), "Correo eliminado", "Correo eliminado");
            this.correosRecibidos[correoAEliminar] = correoEliminado;
        }
    }
}
