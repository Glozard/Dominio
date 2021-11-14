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
        private int telefono;
        private string direccion;
        private DataRow aux;
        private int puntos;

        public ClienteElevador(int ci , string nombre , string apellido , string direccion , int telefono)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public ClienteElevador(int ci, string nombre, string apellido, string direccion, int telefono , int puntos)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.puntos = puntos;
        }
        public ClienteElevador(DataTable aux) 
        {
        }

        public ClienteElevador(DataRow aux)
        {
            this.aux = aux;
        }

        public ClienteElevador()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Ci { get => ci; set => ci = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
