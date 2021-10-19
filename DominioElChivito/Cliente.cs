using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Cliente : Persona
    {
        public string direccion;

        public Cliente(string direccion, string nombre, string apellido, int ci, int telefono) : base(nombre, apellido, ci, telefono)
        {
            direccion = " ";
        }

        public string Direccion { get => direccion; set => direccion = value; }
    }

}
