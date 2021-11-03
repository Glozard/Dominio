using System;
using System.Collections.Generic;
using System.Text;

namespace Elevador
{
    public class EmpleadoElevador
    {

        private int rol;
        private string nombre;
        private string apellido;
        private int ci;
        private int telefono;
        private string direccion;

        public EmpleadoElevador(int rol, string nombre, string apellido, int ci, int telefono , string direccion)
        {
            this.rol = rol;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.telefono = telefono;
            this.Direccion = direccion;
        }
        public EmpleadoElevador() { }

        public EmpleadoElevador(string nombre , int ci)
        {
            this.nombre = nombre;
            this.ci = ci;
        }
       
        public int Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Ci { get => ci; set => ci = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}
