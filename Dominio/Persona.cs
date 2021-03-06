using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
   public class Persona
    {

       public string nombre;
       public string apellido;
       public int ci;
       public int telefono;

        public Persona(string nombre, string apellido, int ci, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Ci { get => ci; set => ci = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
