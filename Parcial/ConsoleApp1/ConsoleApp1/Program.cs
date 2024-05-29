using ConsoleApp1.Examen;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {


            SistemaDeCorreo[] sistema = new SistemaDeCorreo[100];
            int cantidadDeCuentas = 0;

            while(true)
            {
                Console.WriteLine("Ingrese una opción: ");
                Console.WriteLine("1. Crear usuario");
                Console.WriteLine("2. Ver mis correos enviados");
                Console.WriteLine("3. Ver correos recibidos");
                Console.WriteLine("4. Enviar correo");
                Console.WriteLine("5. Eliminar correo");
                Console.WriteLine("6. Salir");

                int opcion = Int32.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del usuario a crear: ");
                        String nombre = Console.ReadLine();
                        Usuario nuevoUsuario = new Usuario(nombre);

                        SistemaDeCorreo crearNuevoCorreo = new SistemaDeCorreo(nuevoUsuario);

                        sistema[cantidadDeCuentas] = crearNuevoCorreo;
                        cantidadDeCuentas++;

                        break;

                    case 2:
                        Console.WriteLine("Ingrese su usuario: ");
                        String usuario = Console.ReadLine();

                        for(int i = 0; i<cantidadDeCuentas; i++)
                        {
                            if(sistema[i].getUsuarioAlQuePertenece().getDireccion() == usuario)
                            {
                                sistema[i].revisarCorreosEnviados();
                            }

                        }

                        break;

                    case 3:
                        Console.WriteLine("Ingrese su usuario: ");
                        String recibidos = Console.ReadLine();

                        for(int i = 0; i < cantidadDeCuentas; i++)
                        {
                            if(sistema[i].getUsuarioAlQuePertenece().getDireccion() == recibidos)
                            {
                                sistema[i].revisarCorreosRecibidos();
                            }

                        }
                        break;
                    case 4:
                        Console.WriteLine("Enviar correo");
                        Console.WriteLine("Ingrese el remitente");
                        String findUser = Console.ReadLine();
                        for(int i = 0; i < cantidadDeCuentas; i++)
                        {
                            if(sistema[i].getUsuarioAlQuePertenece().getDireccion() == findUser)
                            {
                                sistema[i].enviarCorreo(out Correo correo, out string Destinatario);
                                for(int j = 0; j < cantidadDeCuentas; j++)
                                {
                                    if(sistema[j].getUsuarioAlQuePertenece().getDireccion() == Destinatario)
                                    {
                                        sistema[j].recibirCorreo(correo);
                                    }
                                }
                            }

                        }
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el usuario");
                        String usuarioEliminarMensaje = Console.ReadLine();
                        Console.WriteLine("Ingrese el número del correo a eliminar");
                        int correoAEliminar = Int32.Parse(Console.ReadLine());

                        for(int i = 0; i < cantidadDeCuentas; i++)
                        {
                            if(sistema[i].getUsuarioAlQuePertenece().getDireccion() == usuarioEliminarMensaje)
                            {
                                sistema[i].eliminarCorreo(correoAEliminar);
                            }
                        }
                        break;
                    case 6:
                        break;
                }

            }

        }
    }
}
