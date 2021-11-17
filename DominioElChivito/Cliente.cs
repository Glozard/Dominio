using Elevador;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Cliente : Persona
    {
        string direccion;
        int puntos;

        public Cliente(string direccion, string nombre, string apellido, int ci, string telefono) : base(nombre, apellido, ci, telefono)
        {
            direccion = " ";
        }
        public Cliente(string direccion, string nombre, string apellido, int ci, string telefono , int puntos) : base(nombre, apellido, ci, telefono)
        {
            direccion = " ";
            puntos = puntos;
        }
        public Cliente() { }

        public Cliente(ClienteElevador cliente) 
        {
            this.direccion = cliente.Direccion;
            this.nombre = cliente.Nombre;
            this.apellido = cliente.Apellido;
            this.ci = cliente.Ci;
            this.telefono = cliente.Telefono;
            this.puntos = cliente.Puntos;
        }
        
        public string Direccion { get => direccion; set => direccion = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }

}
