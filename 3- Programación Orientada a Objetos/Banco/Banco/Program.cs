// Hazme un main para probar el código
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANCO");
            Usuario usuario = new Usuario("Juan", "Perez", "Calle falsa 123");
            CuentaCorriente cuentaCorriente = new CuentaCorriente("Banco de Chile", "Calle falsa 123", usuario);
            CuentaAhorro cuentaAhorro = new CuentaAhorro("Banco de Chile", "Calle falsa 123", usuario);

            Banco[] listaDeBanco = new Banco[2];
            listaDeBanco[0] = cuentaCorriente;
            listaDeBanco[1] = cuentaAhorro;

            Random random = new Random();
            
            for (int i = 0; i < 100; i++)
            {
                int operacion = random.Next(0, 2);
                int cuenta  = random.Next(0, 2);
                float montoRandom = random.Next(0, 10000);
                    if(operacion == 1){
                    listaDeBanco[cuenta].depositar(montoRandom);
                }
                else
                {
                    listaDeBanco[cuenta].retirar(montoRandom);
               
                    if(listaDeBanco[cuenta] is CuentaCorriente cuentaACobrar)
                    {
                        cuentaACobrar.cobrarInteres();
                        cuentaACobrar.pasarDía();
                    }
                   
                
                }
                        }
                Console.WriteLine("Cuenta 1:" + cuentaCorriente.getMontoEnCuenta());
            Console.WriteLine("Cuenta 2: "  +  cuentaAhorro.getMontoEnCuenta());

        }
    }
}