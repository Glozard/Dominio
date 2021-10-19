using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    class Barrio
    {
        int id;
        string nombre;

        public Barrio(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
