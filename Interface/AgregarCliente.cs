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
           
            string unaDireccion = txtDireccion.Text;
            string unNombre = txtNombre.Text;
            string unApellido = txtApellido.Text;
            int unaCi = Convert.ToInt32(txtCi.Text);
            int unTelefono = Convert.ToInt32(txtTelefono.Text);
            restaurante.agregarCliente(unaDireccion, unNombre , unApellido , unaCi , unTelefono);

            listaClientes.Items.Add(txtNombre.Text);
            listaClientes.Items.Add(txtApellido.Text);
            listaClientes.Items.Add(txtCi.Text);
            listaClientes.Items.Add(txtDireccion.Text);
            listaClientes.Items.Add(txtTelefono.Text);
            
        }
    }
}
