using Elevador;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Empleado : Persona
    {
       private int rol;
       private string direccion;
       

        public Empleado(int rol, string nombre, string apellido, int ci, int telefono , string direccion) : base(nombre, apellido, ci, telefono)
        {
            this.rol = rol;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.telefono = telefono;
            this.direccion = direccion;
        }
        public Empleado() : base() { }
        public Empleado(string nombre , int ci ) : base(nombre , ci) 
        {
            this.ci = ci;
            this.nombre = nombre;
        }
        public Empleado (EmpleadoElevador empleado)
        {
            this.nombre = empleado.Nombre;
            this.ci = empleado.Ci;
            this.apellido = empleado.Apellido;
            this.direccion = empleado.Direccion;
            this.telefono = empleado.Telefono;
            this.rol = (byte)empleado.Rol;
        }

        public int Rol { get => rol; set => rol = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}
