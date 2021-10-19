using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class Empleado : Persona
    {
        byte rol;

        public Empleado(byte rol ,string nombre, string apellido, int ci, int telefono) : base(nombre, apellido, ci, telefono)
        {
           
        }

        public byte Rol { get => rol; set => rol = value; }
    }
}
