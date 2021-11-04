using Elevador;
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
        
        public Cliente() { }

        public Cliente(ClienteElevador cliente) 
        {
            this.direccion = cliente.Direccion;
            this.nombre = cliente.Nombre;
            this.apellido = cliente.Apellido;
            this.ci = cliente.Ci;
            this.telefono = cliente.Telefono;
        }
        
        public string Direccion { get => direccion; set => direccion = value; }
        
    }

}
