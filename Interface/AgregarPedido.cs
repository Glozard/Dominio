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
    public partial class agregarPedido : Form
    {
        Restaurante restaurante;
        string unaDireccion = "";
        int unaCantidad;
        int unNumero_orden = 0;
        int unCodigo = 0;
        int unCodigo_producto = -1;
        string comida = "";
        byte estado = 0;

        public agregarPedido(Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
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
            unNumero_orden = +1;
            unCodigo = +1;
    
           
            dataPedido.Rows.Add(comida, unaCantidad, unaDireccion, unNumero_orden, unCodigo, unCodigo_producto);


            txtCantidad.Text = "";
            txtDireccion.Text = "";
            listaPizza.SelectedIndex = -1;
            listaHamburguesa.SelectedItem = -1;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            restaurante.agregarPedido(unaDireccion, unaCantidad, unNumero_orden, unCodigo, unCodigo_producto , estado);
        }
    }
}
