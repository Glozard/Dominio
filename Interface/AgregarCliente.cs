using DominioElChivito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interface
{
    public partial class AgregarCliente :Form
    {
        Restaurante restaurante;
       
        public AgregarCliente (Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
            InitializeComponent();
        }


      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string unaDireccion = txtDireccion.Text.ToLower().Trim();
                string unNombre = txtNombre.Text.ToLower().Trim();
                string unApellido = txtApellido.Text.ToLower().Trim();
                int unaCi = Convert.ToInt32(txtCi.Text.ToLower().Trim());
                int unTelefono = Convert.ToInt32(txtTelefono.Text.ToLower().Trim());
                restaurante.agregarCliente(unaDireccion, unNombre, unApellido, unaCi, unTelefono);

                listaClientes.Items.Add(txtNombre.Text);
                listaClientes.Items.Add(txtApellido.Text);
                listaClientes.Items.Add(txtCi.Text);
                listaClientes.Items.Add(txtDireccion.Text);
                listaClientes.Items.Add(txtTelefono.Text);

                txtDireccion.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCi.Text = "";
                txtTelefono.Text = "";
            }
            catch (Exception) { MessageBox.Show("Error : datos incorrectos"); }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            listaClientes.Items.Clear();
        }
    }
}
