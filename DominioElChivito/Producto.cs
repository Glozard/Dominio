using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    class Producto
    {
        bool disponible;
        int codigo;

        public Producto(bool disponible, int codigo)
        {
            this.disponible = disponible;
            this.codigo = codigo;
        }

        public bool Disponible { get => disponible; set => disponible = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
