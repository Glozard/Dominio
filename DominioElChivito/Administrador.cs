using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
     public class Administrador : Empleado
    {
         
        public Administrador(byte rol, string nombre, string apellido, int ci, int telefono , string direccion) : base(rol, nombre, apellido, ci, telefono, direccion)
        {
            rol = 0;
        }
    }
}
