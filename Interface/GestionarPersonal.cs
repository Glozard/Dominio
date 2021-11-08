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
    public partial class GestionarPersonal : Form
    {
        Restaurante restaurante;
        
        public GestionarPersonal(Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
            InitializeComponent();
            cargarListaEmpleados();
        }

        public void ListaDeEmpleados_Load(object sender, EventArgs e)
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

        public void limpiar()
        {
            comboRol.SelectedItem = null;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCi.Text = "";
        }
        public void btnModificar_Click(object sender, EventArgs e)
        {
            int unRol = comboRol.SelectedIndex;
            string unaDireccion = txtDireccion.Text;
            string unNombre = txtNombre.Text;
            string unApellido = txtApellido.Text;
            int unaCi = Convert.ToInt32(txtCi.Text);
            int unTelefono = Convert.ToInt32(txtTelefono.Text);

            restaurante.ModificarEmpleado(unaCi , unRol , unTelefono , unNombre , unApellido , unaDireccion);
            limpiar();
            dataEmpleados.Rows.Clear();
            cargarListaEmpleados();
            MessageBox.Show("Empleado modificado correctamente");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void dataEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = -1;
            txtCi.Text = "";
            posicion = dataEmpleados.CurrentRow.Index;
            txtCi.Text = dataEmpleados[0 , posicion].Value.ToString();
            comboRol.SelectedItem = dataEmpleados[1, posicion].Value.ToString();
            txtTelefono.Text = dataEmpleados[2, posicion].Value.ToString();
            txtNombre.Text = dataEmpleados[3, posicion].Value.ToString();
            txtApellido.Text = dataEmpleados[4, posicion].Value.ToString();
            txtDireccion.Text = dataEmpleados[5, posicion].Value.ToString();
        }
        public void btnEliminar_Click(object sender, EventArgs e)
        {
            int ci = Convert.ToInt32(txtCi.Text);
            restaurante.EliminarEmpleado(ci);
            limpiar();
            dataEmpleados.Rows.Clear();
            cargarListaEmpleados();
            
        }
        public void btnAgregar_Click(object sender, EventArgs e)
        {
            byte unRol = (byte)comboRol.SelectedIndex;
            string unaDireccion = txtDireccion.Text;
            string unNombre = txtNombre.Text;
            string unApellido = txtApellido.Text;
            int unaCi = Convert.ToInt32(txtCi.Text);
            int unTelefono = Convert.ToInt32(txtTelefono.Text);
            restaurante.agregarEmpleado(unRol, unNombre, unApellido, unaCi, unTelefono, unaDireccion);
            dataEmpleados.Rows.Clear();
            cargarListaEmpleados();
            limpiar();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
