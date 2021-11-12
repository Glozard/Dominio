using System;
using System.Collections.Generic;
using System.Text;

namespace Elevador
{
    public class PedidoElevador
    {

        private string comida;
        private int cantidad;
        private string estado;
        private int numero_orden;
        private int codigo;
        private int codigo_producto;
        private string direccion;
        private string telefono;
        private int cliente;

        public PedidoElevador(int cantidad, string estado, int numero_orden, int codigo, int codigo_producto, string direccion , string telefono, string comida , int cliente)
        {
            this.cantidad = cantidad;
            this.estado = estado;
            this.numero_orden = numero_orden;
            this.codigo = codigo;
            this.codigo_producto = codigo_producto;
            this.direccion = direccion;
            this.telefono = telefono;
            this.comida = comida;
            this.cliente = cliente;
        }

        public PedidoElevador() { }

        public string Comida { get => comida; set => comida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Cliente { get => cliente; set => cliente = value; }
    }
}
