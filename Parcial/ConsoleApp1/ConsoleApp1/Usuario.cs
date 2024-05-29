using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Usuario
    {

        private String direccion;

        public Usuario(String direccion)
        {
            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return direccion;
        }
    }
}
