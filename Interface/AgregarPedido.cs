﻿using DominioElChivito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class agregarPedido : Form
    {
        Restaurante restaurante;
        string unaDireccion = "";
        int unaCantidad;
        int unNumero_orden = 0;
        int unCodigo;
        int unCodigo_producto = -1;
        string comida = "";
        byte estado = 0;

        int unaPocision = 1;

        public agregarPedido(Restaurante unRestaurante)
        {
            
            this.restaurante = unRestaurante;
            InitializeComponent();
            btnDisponible.Visible = false;
            btnNoDisponble.Visible = false;
        }
        public agregarPedido(int posicion)
        {
            this.unaPocision = posicion;
            InitializeComponent();
        }

      

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
        private void lblAgregar_Click(object sender, EventArgs e)
        {
      
            if (listaPizza.SelectedIndex != -1)
            {
                comida = listaPizza.SelectedItem.ToString();
                unCodigo_producto = listaPizza.SelectedIndex;
            }
            if (listaHamburguesa.SelectedIndex != -1)
            {
                comida = listaHamburguesa.SelectedItem.ToString();
                unCodigo_producto = listaHamburguesa.SelectedIndex;
            }

            unaDireccion = txtDireccion.Text;
            unaCantidad = Convert.ToInt32(txtCantidad.Text);
            unNumero_orden =unNumero_orden +1;
            unCodigo = unCodigo +1;

            dataPedido.Rows.Add(comida, unaCantidad, estado, unNumero_orden, unCodigo, unCodigo_producto, unaDireccion);
            txtCantidad.Text = "";
            txtDireccion.Text = "";
            listaPizza.SelectedIndex = -1;
            listaHamburguesa.SelectedIndex = -1;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            restaurante.agregarPedido(comida , unaCantidad , estado , unNumero_orden, unCodigo, unCodigo_producto , unaDireccion);
        }

        private void agregarPedido_Load(object sender, EventArgs e)
        {
            if (unaPocision == 0)
            {
                btnEnviar.Visible = false;
                lblAgregar.Visible = false;
                txtCantidad.Visible = false;
                txtDireccion.Visible = false;
                dataPedido.Visible = false;
                lblCantidad.Visible = false;
                lblDireccion.Visible = false;
                agregarPedido.Sice 
                
            }
        }
    }
}
