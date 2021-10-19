using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
   public class Pedido
    {

        string direccion;
        int cantidad;
        int numero_orden;
        int codigo;
        int codigo_producto;
        byte estado;

        public Pedido(string direccion, int cantidad, int numero_orden, int codigo, int codigo_producto , byte estado)
        {
            this.direccion = direccion;
            this.cantidad = cantidad;
            this.numero_orden = numero_orden;
            this.codigo = codigo;
            this.codigo_producto = codigo_producto;
            this.estado = estado;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public byte Estado { get => estado; set => estado = value; }
    }    
}
