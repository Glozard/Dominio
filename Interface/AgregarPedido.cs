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
        int unCodigo;
        int unCodigo_producto = -1;
        string comida = "";
        byte estado = 0;
        int unaPocision = -1;
        int unTelefono;

        public agregarPedido(Restaurante unRestaurante ,int posicion)
        {
            
            this.restaurante = unRestaurante;
            InitializeComponent();
            btnDisponible.Visible = false;
            btnNoDisponble.Visible = false;
            unaPocision = posicion;

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
            unTelefono = Convert.ToInt32(txtTelefono);

            dataPedido.Rows.Add(comida, unaCantidad, unaDireccion, unNumero_orden, unCodigo, unTelefono);
            txtCantidad.Text = "";
            txtDireccion.Text = "";
            listaPizza.SelectedIndex = -1;
            listaHamburguesa.SelectedIndex = -1;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow aux in dataPedido.Rows) {
                if (aux.Cells[0].Value != null)
                {
                    int cantidadAux = Convert.ToInt32(aux.Cells[1].Value);
                    int codigoAux = Convert.ToInt32(aux.Cells[5].Value);
                    int numeroDeOrdenAux = Convert.ToInt32(aux.Cells[4].Value);
                    string direccionAux = aux.Cells[2].Value.ToString();
                    int telefono = Convert.ToInt32(aux.Cells[6].Value);

                    restaurante.agregarPedido(aux.Cells[0].Value.ToString(), cantidadAux, estado, numeroDeOrdenAux, codigoAux, unCodigo_producto, direccionAux,telefono);
                    
                    dataPedido.Rows.RemoveAt(0);
                }
            }
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
                Size = new Size(918, 431);
                btnDisponible.Visible = true;
                btnNoDisponble.Visible = true;
            }
        
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            listaPizza.Items.Add(listaPizzaNoDisponible.SelectedItem);
            listaPizzaNoDisponible.Items.Remove(listaPizzaNoDisponible.SelectedItem);
        }

        private void btnNoDisponble_Click(object sender, EventArgs e)
        {
            listaPizzaNoDisponible.Items.Add(listaPizza.SelectedItem);
            listaPizza.Items.Remove(listaPizza.SelectedItem);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente cliente = new AgregarCliente(restaurante);
            cliente.Show();
        }
    }
}
