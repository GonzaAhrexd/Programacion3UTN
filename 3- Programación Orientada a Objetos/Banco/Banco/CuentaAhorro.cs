using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaAhorro : Banco{
        public CuentaAhorro(string nombre, string direccion, Usuario titular) : base(nombre, direccion, titular)
        {
            }
    
            public override void retirar(float monto){
                if(monto <= this.montoEnCuenta)
            {
                this.montoEnCuenta -= monto;
                }
            else
            {
                    
                }
    
            }
    }
}
