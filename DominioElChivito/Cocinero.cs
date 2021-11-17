using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Cocinero : Empleado
    {
        public Cocinero(byte rol, string nombre, string apellido, int ci, string telefono , string direccion) : base(rol, nombre, apellido, ci, telefono, direccion)
        {
            rol = 2;
        }
    }
}
