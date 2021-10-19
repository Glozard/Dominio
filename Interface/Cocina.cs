using DominioElChivito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class Cocina : Form
    {
        Restaurante restaurante;
        public Cocina(Restaurante unRestaurante )

        {
            this.restaurante = unRestaurante;
            InitializeComponent();
        }
       
        public Cocina (string comida ,string direccion, int cantidad, int numero_orden, int codigo, int codigo_producto)
        {   
            string unaComida = comida;
            string unaDirección = direccion;
            int unaCantidad = cantidad;
            int unNumero_orden = numero_orden;
            int unCodigo = codigo;
            int unCodigo_producto = codigo_producto;      
        }


        private void dataListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataListaPedidos.Rows.Add();
        }
    }
}
