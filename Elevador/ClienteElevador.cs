using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Elevador
{
    public class ClienteElevador
    {
        private string nombre;
        private string apellido;
        private int ci;
        private string telefono;
        private string direccion;
        private DataRow aux;
        private int puntos;

        public ClienteElevador(int ci , string nombre , string apellido , string direccion , string telefono)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public ClienteElevador()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Ci { get => ci; set => ci = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
