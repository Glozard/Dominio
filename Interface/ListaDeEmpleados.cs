using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DominioElChivito;

namespace Interface
{
    public partial class ListaDeEmpleados : Form
    {
        Restaurante restaurante;


        public ListaDeEmpleados(Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
            InitializeComponent();
            cargarListaEmpleados();
        }

        private void ListaDeEmpleados_Load(object sender, EventArgs e)
        {
           
        }
        public void cargarListaEmpleados()
        {
            foreach (Empleado aux in restaurante.CargarEmpleados())
            {
                string rol = " ";
                int indice = dataEmpleados.Rows.Add();
                if (aux.Rol == 0) rol = "Administrador";
                if (aux.Rol == 1) rol = "Recepcionista";
                if (aux.Rol == 2) rol = "Cocinero";
                dataEmpleados.Rows[indice].Cells[0].Value = aux.Ci;
                dataEmpleados.Rows[indice].Cells[1].Value = rol;
                dataEmpleados.Rows[indice].Cells[2].Value = aux.telefono;
                dataEmpleados.Rows[indice].Cells[3].Value = aux.Nombre;
                dataEmpleados.Rows[indice].Cells[4].Value = aux.Apellido;
                dataEmpleados.Rows[indice].Cells[5].Value = aux.Direccion;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int unRol = comboRol.SelectedIndex;
            string unaDireccion = txtDireccion.Text;
            string unNombre = txtNombre.Text;
            string unApellido = txtApellido.Text;
            int unaCi = Convert.ToInt32(txtCi.Text);
            int unTelefono = Convert.ToInt32(txtTelefono.Text);

            restaurante.ModificarEmpleado(unaCi , unRol , unTelefono , unNombre , unApellido , unaDireccion);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
