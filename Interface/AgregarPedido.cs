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
        string estado = "pendiente";
        int unaPocision = -1;
        int unTelefono;
        string unCliente = "";
        public agregarPedido(Restaurante unRestaurante ,int posicion)
        {            
            this.restaurante = unRestaurante;
            InitializeComponent();
            btnDisponible.Visible = false;
            btnNoDisponble.Visible = false;
            unaPocision = posicion;
            LevantarClientes();
            CargarProductos();
            SeleccionarListasNulo();
        }
       
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }  
        private void lblAgregar_Click(object sender, EventArgs e)
        {
            if (listaMilanesasDisponible.SelectedIndex != -1)
            {
                unCodigo_producto = listaMilanesasDisponible.SelectedIndex;
            }
            if (listaHamburguesasDisponible.SelectedIndex != -1)
            {
                unCodigo_producto = listaHamburguesasDisponible.SelectedIndex;
            }
            
            unaDireccion = txtDireccion.Text;
            unaCantidad = Convert.ToInt32(txtCantidad.Text);
            unNumero_orden =unNumero_orden +1;
            unCodigo = restaurante.CargarCodigo(ComidaSeleccionada());
            unTelefono = Convert.ToInt32(txtTelefono.Text);
            unCliente = comboClientes.SelectedItem.ToString();

            dataPedido.Rows.Add(ComidaSeleccionada(), unaCantidad, unaDireccion, unNumero_orden, unCodigo, unTelefono , unCliente);
            txtCantidad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            comboClientes.SelectedIndex = -1;
            SeleccionarListasNulo();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow aux in dataPedido.Rows) {
                if (aux.Cells[0].Value != null)
                {
                    int cantidadAux = Convert.ToInt32(aux.Cells[1].Value);
                    int codigoAux = Convert.ToInt32(aux.Cells[4].Value);
                    int numeroDeOrdenAux = Convert.ToInt32(aux.Cells[3].Value);
                    string direccionAux = aux.Cells[2].Value.ToString();
                    int telefono = Convert.ToInt32(aux.Cells[5].Value);
                    string cliente = aux.Cells[6].Value.ToString();
                    restaurante.agregarPedido(aux.Cells[0].Value.ToString(), cantidadAux, estado, numeroDeOrdenAux, unCodigo, unCodigo_producto, direccionAux,telefono , cliente);  
                    dataPedido.Rows.RemoveAt(0);
                }
            }
        }
        private void agregarPedido_Load(object sender, EventArgs e)
        {
            if (unaPocision == 0)
            {
                lblClientes.Visible = false;
                comboClientes.Visible = false;
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

        }
        private void btnNoDisponble_Click(object sender, EventArgs e)
        {
            restaurante.ModificarEstadoProducto(ComidaSeleccionada());
            LimpiarListas();
            CargarProductos();

        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente cliente = new AgregarCliente(restaurante);
            cliente.Show();
        }

        private void tablaComida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LimpiarListas()
        {
            listaMilanesasDisponible.Items.Clear();
            listaHamburguesasDisponible.Items.Clear();
            listaPapasDisponible.Items.Clear();
            listaBebidasDisponible.Items.Clear();
            listaCervezasDisponible.Items.Clear();
            //ahora las no disponibles
            listaMilanesasNoDisponible.Items.Clear();
            listaHamburguesasNoDisponible.Items.Clear();
            listaPapasNoDisponible.Items.Clear();
            listaBebidasNoDisponible.Items.Clear();
            listaCervezaNoDisponible.Items.Clear();
        }
        //metodo para relevar el pedido
        string ComidaSeleccionada()
        {
            if (listaMilanesasDisponible.SelectedIndex != -1) comida = listaMilanesasDisponible.SelectedItem.ToString();
            if (listaHamburguesasDisponible.SelectedIndex != -1) comida = listaHamburguesasDisponible.SelectedItem.ToString();
            if (listaPapasDisponible.SelectedIndex != -1) comida = listaPapasDisponible.SelectedItem.ToString();
            if (listaBebidasDisponible.SelectedIndex != -1) comida = listaBebidasDisponible.SelectedItem.ToString();
            if (listaCervezasDisponible.SelectedIndex != -1) comida = listaCervezasDisponible.SelectedItem.ToString();
            return comida;
        }
        void SeleccionarListasNulo()
        {
            listaMilanesasDisponible.SelectedIndex = -1;
            listaHamburguesasDisponible.SelectedIndex = -1;
            listaPapasDisponible.SelectedIndex = -1;
            listaBebidasDisponible.SelectedIndex = -1;
            listaCervezasDisponible.SelectedIndex = -1;
        }
         void CargarProductos()
        {
            List<Producto> productos = new List<Producto>();
            DataTable dt = new DataTable();
            dt = restaurante.CargarProductos();
            for (int i = 0; i < restaurante.CargarProductos().Rows.Count; i++)
            {
                Producto p = new Producto();
                p.Codigo = (int)dt.Rows[i][0];
                p.Comida = (string)dt.Rows[i][1];
                p.Tipo_comida = (string)dt.Rows[i][2];
                p.Estado = (string)dt.Rows[i][3];
                if (p.Comida == "Milanesa") if (p.Estado == "hay") listaMilanesasDisponible.Items.Add(p.Tipo_comida);
                    else listaMilanesasNoDisponible.Items.Add(p.Tipo_comida);
                if (p.Comida == "Hamburguesa") if (p.Estado == "hay") listaHamburguesasDisponible.Items.Add(p.Tipo_comida);
                    else listaHamburguesasNoDisponible.Items.Add(p.Tipo_comida);
                if (p.Comida == "Papas Fritas") if (p.Estado == "hay") listaPapasDisponible.Items.Add(p.Tipo_comida);
                    else listaPapasNoDisponible.Items.Add(p.Tipo_comida);
                if (p.Comida == "Bebida") if (p.Estado == "hay") listaBebidasDisponible.Items.Add(p.Tipo_comida);
                    else listaBebidasNoDisponible.Items.Add(p.Tipo_comida);
                if (p.Comida == "Cerveza") if (p.Estado == "hay") listaCervezasDisponible.Items.Add(p.Tipo_comida);
                    else listaCervezaNoDisponible.Items.Add(p.Tipo_comida);
            }
        }


        private void LevantarClientes()
        {
            foreach (Cliente aux in restaurante.CargarClientes())
            {
                string auxDos = aux.Nombre + "-" + aux.Ci;
                comboClientes.Items.Add(auxDos);
            }
        }
    }
}
