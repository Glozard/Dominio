using Elevador;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominioElChivito
{
    public class Pedido
    {
        string comida;
        int cantidad;
        string estado;        
        int numero_orden;
        int codigo;
        int codigo_producto; 
        string direccion;
        string telefono;
        string cliente;
        DateTime fecha;

        
        public Pedido(PedidoElevador e) 
        {
            this.comida = e.Comida;
            this.cantidad = e.Cantidad;
            this.estado = e.Estado;
            this.numero_orden = e.Numero_orden;
            this.codigo = e.Codigo;
            this.codigo_producto = e.Codigo_producto;
            this.direccion = e.Direccion;
            this.Telefono = e.Telefono;
            this.cliente = e.Cliente;
        }

        public Pedido()
        {
        }

        public Pedido(string comida, int cantidad, string estado, int numero_orden, int codigo, int codigo_producto, string direccion, string telefono, string cliente)
        {
            this.comida = comida;
            this.cantidad = cantidad;
            this.estado = estado;
            this.numero_orden = numero_orden;
            this.codigo = codigo;
            this.codigo_producto = codigo_producto;
            this.direccion = direccion;
            this.telefono = telefono;
            this.cliente = cliente;
        }

        public Pedido(string comida, int cantidad, string estado, int numero_orden, int codigo, int codigo_producto, string direccion, string telefono, string cliente, DateTime fecha)
        {
            this.comida = comida;
            this.cantidad = cantidad;
            this.estado = estado;
            this.numero_orden = numero_orden;
            this.codigo = codigo;
            this.codigo_producto = codigo_producto;
            this.direccion = direccion;
            this.telefono = telefono;
            this.cliente = cliente;
            this.fecha = fecha;
        }

        public string Comida { get => comida; set => comida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public DateTime Fecha { get; set; }
    }
    }
