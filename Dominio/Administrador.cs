using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Administrador : Empleado
    {
        public Administrador(byte rol, string nombre, string apellido, int ci, int telefono) : base(rol, nombre, apellido, ci, telefono)
        {
            rol = 0;
        }
    }
}
