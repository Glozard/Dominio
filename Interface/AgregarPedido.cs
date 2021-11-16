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
        string unTelefono;
        string unCliente = "";
        public agregarPedido(Restaurante unRestaurante ,int posicion)
        {            
            this.restaurante = unRestaurante;
            InitializeComponent();
            btnDisponible.Visible = false;
            btnNoDisponible.Visible = false;
            unaPocision = posicion;
            CargarProductos();
            SeleccionarListasNulo();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = -1;
            posicion = dataPedido.CurrentRow.Index;
            txtCantidad.Text = dataPedido[1, posicion].Value.ToString();
            txtDireccion.Text = dataPedido[2, posicion].Value.ToString();
            txtTelefono.Text = dataPedido[5, posicion].Value.ToString();
        }

        private void agregarPedido_Load(object sender, EventArgs e)
        {
            if (unaPocision == 0)
            {
                lblClientes.Visible = false;
                comboClientes.Visible = false;
                btnEnviar.Visible = false;
                btnAgregar.Visible = false;
                txtCantidad.Visible = false;
                txtDireccion.Visible = false;
                dataPedido.Visible = false;
                lblCantidad.Visible = false;
                lblDireccion.Visible = false;
                lblTelefono.Visible = false;
                txtTelefono.Visible = false;
                btnAgregarCliente.Visible = false;
                lblClientes.Visible = false;
                btnEliminar.Visible = false;
                btnDisponible.Visible = true;
                btnNoDisponible.Visible = true;
                tablaComida.Location = new System.Drawing.Point(271, 192);
                btnDisponible.Location = new System.Drawing.Point(473, 447);
                btnNoDisponible.Location = new System.Drawing.Point(685, 447);

            }
            else { ListasOnlyRead(); }

            comboClientes.AutoCompleteCustomSource = LevantarClientes();
            comboClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboClientes.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPedido();

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
            bool haySeleccion = false;

            if (listaMilanesasDisponible.SelectedIndex != -1)
            {
                comida = listaMilanesasDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaHamburguesasDisponible.SelectedIndex != -1) {
                comida = listaHamburguesasDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaPapasDisponible.SelectedIndex != -1)
            {
                comida = listaPapasDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaBebidasDisponible.SelectedIndex != -1)
            {
                comida = listaBebidasDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaCervezasDisponible.SelectedIndex != -1)
            {
                comida = listaCervezasDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (haySeleccion)
                return comida;
            else return null;
        }
        string ComidaSeleccionadaNoDisponible() 
        {
            bool haySeleccion = false;
            if (listaMilanesasNoDisponible.SelectedIndex != -1)
            {
                comida = listaMilanesasNoDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaHamburguesasNoDisponible.SelectedIndex != -1) { 
                comida = listaHamburguesasNoDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaPapasNoDisponible.SelectedIndex != -1) { 
                comida = listaPapasNoDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaBebidasNoDisponible.SelectedIndex != -1) {
                comida = listaBebidasNoDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (listaCervezaNoDisponible.SelectedIndex != -1) { 
                comida = listaCervezaNoDisponible.SelectedItem.ToString();
                haySeleccion = true;
            }
            if (haySeleccion)
                return comida;
            else return null;
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


        public  AutoCompleteStringCollection LevantarClientes()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (Cliente aux in restaurante.CargarClientes())
            {
                coleccion.Add(Convert.ToString(aux.ci));
            }
            return coleccion;
        }

        void AgregarPedido()
        {
            if (comboClientes.SelectedIndex != -1) unCliente = comboClientes.SelectedItem.ToString();

            try
            {
                if (ComidaSeleccionada() != "")
                {
                    if (txtDireccion.Text != "")
                    {
                        if (txtTelefono.Text != "")
                        {
                            if (txtCantidad.Text !="") 
                            {
                                unaDireccion = txtDireccion.Text;
                                unaCantidad = Convert.ToInt32(txtCantidad.Text);
                                unNumero_orden = unNumero_orden + 1;
                                unCodigo = restaurante.CargarCodigo(ComidaSeleccionada());
                                unTelefono = txtTelefono.Text;
                                unCliente = comboClientes.Text;


                                dataPedido.Rows.Add(ComidaSeleccionada(), unaCantidad, unaDireccion, unNumero_orden, unCodigo, unTelefono, unCliente);
                                txtCantidad.Text = "";
                                txtDireccion.Text = "";
                                txtTelefono.Text = "";
                                unCliente = "";
                                comboClientes.SelectedIndex = -1;
                                SeleccionarListasNulo();
                            }
                        }
                    }
                }else MessageBox.Show("Seleccione una comida");


            }
            catch (Exception) { MessageBox.Show("Datos ingresados incorrectamente"); }
        }

        private void listaMilanesasNoDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListasOnlyRead();
        }

        private void listaHamburguesasNoDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListasOnlyRead();
        }

        private void listaPapasNoDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListasOnlyRead();
        }

        private void listaBebidasNoDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListasOnlyRead();
        }

        private void listaCervezaNoDisponible_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListasOnlyRead();
        }
        void ListasOnlyRead()
        {
            if (unaPocision != 0) {
                listaHamburguesasNoDisponible.SelectedIndex = -1;
                listaPapasNoDisponible.SelectedIndex = -1;
                listaBebidasNoDisponible.SelectedIndex = -1;
                listaBebidasNoDisponible.SelectedIndex = -1;
                listaMilanesasNoDisponible.SelectedIndex = -1;
            }
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            string resp = ComidaSeleccionadaNoDisponible();
            if (resp != null)
            {
                restaurante.ModificarEstadoProductoDisponible(resp);
                LimpiarListas();
                CargarProductos();
            }
            else MessageBox.Show("Debe seleccionar un producto.");
        }

        private void btnNoDisponible_Click(object sender, EventArgs e)
        {
            string resp = ComidaSeleccionada();
            if (resp != null)
            {
                restaurante.ModificarEstadoProducto(resp);
                LimpiarListas();
                CargarProductos();
            }
            else MessageBox.Show("Debe seleccionar un producto.");

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow aux in dataPedido.Rows)
            {
                if (aux.Cells[0].Value != null)
                {
                    int cantidadAux = Convert.ToInt32(aux.Cells[1].Value);
                    int unCodigo_productoAux = Convert.ToInt32(aux.Cells[4].Value);
                    int numeroDeOrdenAux = Convert.ToInt32(aux.Cells[3].Value);
                    string direccionAux = aux.Cells[2].Value.ToString().ToLower().Trim();
                    string telefono = aux.Cells[5].Value.ToString().ToLower().Trim();
                    string cliente = "";
                    if (aux.Cells[6].Value.ToString().ToLower().Trim() != null)
                    {
                        cliente = (aux.Cells[6].Value.ToString().ToLower().Trim());
                    }

                    restaurante.agregarPedido(aux.Cells[0].Value.ToString().ToLower().Trim(), cantidadAux, estado, numeroDeOrdenAux, unCodigo, unCodigo_productoAux, direccionAux, telefono, cliente);
                    dataPedido.Rows.RemoveAt(0);
                }
                else MessageBox.Show("No hay pedidos en cola para enviar");
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int posicion = -1;
            posicion = dataPedido.CurrentRow.Index;
            try
            {
                if (posicion != -1)
                {
                    dataPedido.Rows.RemoveAt(posicion);
                }
            }
            catch (Exception) { MessageBox.Show("Debes seleccionar un pedido valido"); }

        }

        private void botones1_Click(object sender, EventArgs e)
        {
            AgregarCliente cliente = new AgregarCliente(restaurante);
            cliente.Show();
        }

        private void panelModificarProducto_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
