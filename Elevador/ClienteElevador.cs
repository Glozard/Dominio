using System;
using System.Collections.Generic;
using System.Text;

namespace Elevador
{


    public class ClienteElevador
    {
        private string nombre;
        private string apellido;
        private int ci;
        private int telefono;
        private string direccion;

        
        public ClienteElevador(int ci , string nombre , string apellido , string direccion , int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Ci { get => ci; set => ci = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
