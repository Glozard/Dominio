using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Recepcionista : Empleado
    {
        public Recepcionista(byte rol, string nombre, string apellido, int ci, int telefono, string direccion) : base(rol, nombre, apellido, ci, telefono, direccion)
        {
            rol = 1;
        }
    }
}
