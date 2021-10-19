using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cliente : Persona
    {
        private string direccion;

        public Cliente(string direccion, string nombre, string apellido, int ci, int telefono) : base(nombre, apellido, ci, telefono)
        {
            direccion = " ";
        }

        public string Direccion { get => direccion; set => direccion = value; }
    }

}
