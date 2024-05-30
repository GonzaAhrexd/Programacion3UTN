using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaCorriente : Banco{

        private float interes = 0.02f;
        public CuentaCorriente(string nombre, string direccion, Usuario titular) : base(nombre, direccion, titular)
        {
        }

        public override void retirar(float monto)
        {
            if(monto <= this.montoEnCuenta){
            this.montoEnCuenta -= monto;
            }else if(monto <= this.montoEnCuenta + 10000){
                this.montoEnCuenta -= monto;
            }
            else{
   
            }

        }
        public void cobrarInteres()
        {
            if(this.montoEnCuenta < 0)
            {
            this.montoEnCuenta += this.montoEnCuenta * this.interes;
            }
        }

        public void pasarDía()
        {   
            if(this.montoEnCuenta < 0)
            {
            this.interes  = (float)(this.interes * 1.50);
            }
            else
            {
                this.interes = 0.02f;
            }
        }
    }
}
