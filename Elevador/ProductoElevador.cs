using System;
using System.Collections.Generic;
using System.Text;

namespace Elevador
{
    public class ProductoElevador
    {
        int codigo;
        string comida = "";
        string tipo_comida = "";
        string estado = "";

        public ProductoElevador(int codigo, string comida, string tipo_comida, string estado)
        {
            this.codigo = codigo;
            this.comida = comida;
            this.tipo_comida = tipo_comida;
            this.estado = estado;
        }
        public ProductoElevador() { }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Comida { get => comida; set => comida = value; }
        public string Tipo_comida { get => tipo_comida; set => tipo_comida = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
