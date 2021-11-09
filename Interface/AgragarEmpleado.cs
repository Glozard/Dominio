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
    public partial class AgragarEmpleado : Form
    {
        Restaurante restaurante;

     
        public AgragarEmpleado(Restaurante unRestaurante)
        {

            this.restaurante = unRestaurante;
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            byte unRol = (byte)comboRol.SelectedIndex;
            string unaDireccion = txtDireccion.Text.ToLower().Trim();
            string unNombre = txtNombre.Text.ToLower().Trim();
            string unApellido = txtApellido.Text.ToLower().Trim();
            int unaCi = Convert.ToInt32(txtCi.Text);
            int unTelefono = Convert.ToInt32(txtTelefono.Text);
            restaurante.agregarEmpleado(unRol, unNombre, unApellido, unaCi, unTelefono , unaDireccion);
            
            listaEmpleado.Items.Add(txtNombre.Text);
            listaEmpleado.Items.Add(txtApellido.Text);
            listaEmpleado.Items.Add(txtCi.Text);
            listaEmpleado.Items.Add(txtDireccion.Text);
            listaEmpleado.Items.Add(txtTelefono.Text);
            listaEmpleado.Items.Add(restaurante.devolverRol(unRol)) ;
        }
    }
}
