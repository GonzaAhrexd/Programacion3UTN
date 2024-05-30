using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Banco{ 
        protected string nombre;
        protected string direccion;
        protected Usuario titular;
        protected float montoEnCuenta;

        public Banco(string nombre, string direccion, Usuario titular)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.titular = titular;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getDireccion()
        {
            return this.direccion;
        }
        public Usuario getTitular()
        {
            return this.titular;
        }
        public float getMontoEnCuenta()
        {
            return this.montoEnCuenta;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public void setTitular(Usuario titular)
        {
            this.titular = titular;
        }
        public void depositar(float montoEnCuenta){
            this.montoEnCuenta = montoEnCuenta;
        }
        public abstract void retirar(float montoEnCuenta);

    }
}
