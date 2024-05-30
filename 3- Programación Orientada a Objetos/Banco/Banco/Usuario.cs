using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Usuario{
        private string nombre;
        private string apellido;
        private string direccion;

        public Usuario(string nombre, string apellido, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }
        //Hazme los getters y setters
        public string getNombre(){
            return this.nombre;
        }
        public string getApellido(){
            return this.apellido;
        }
        public string getDireccion(){
            return this.direccion;
        }
        public void setNombre(string nombre){
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }


    }
}
