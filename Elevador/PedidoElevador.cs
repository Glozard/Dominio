﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Elevador
{
    class PedidoElevador
    {

        string comida;
        int cantidad;
        byte estado;
        int numero_orden;
        int codigo;
        int codigo_producto;
        string direccion;

        public PedidoElevador(string comida, int cantidad, byte estado, int numero_orden, int codigo, int codigo_producto, string direccion)
        {
            this.comida = comida;
            this.cantidad = cantidad;
            this.estado = estado;
            this.numero_orden = numero_orden;
            this.codigo = codigo;
            this.codigo_producto = codigo_producto;
            this.direccion = direccion;
        }

        public string Comida { get => comida; set => comida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public byte Estado { get => estado; set => estado = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}