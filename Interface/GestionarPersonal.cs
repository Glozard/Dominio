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
            txtCi.ReadOnly = false;
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
            txtCi.ReadOnly = true;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtCi.Text != "")
            {
                int ci = Convert.ToInt32(txtCi.Text); //preguntar al profe
                DialogResult dr = MessageBox.Show("¿Estás seguro que deseas eliminar?", "", MessageBoxButtons.YesNo);
                restaurante.EliminarEmpleado(ci);
                if (dr == DialogResult.Yes)
                {
                    limpiar();
                    dataEmpleados.Rows.Clear();
                    cargarListaEmpleados();
                }
            }
            else { MessageBox.Show("Error : Debes seleccionar un usuario valido"); }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte unRol = (byte)comboRol.SelectedIndex;
                string unaDireccion = txtDireccion.Text;
                string unNombre = txtNombre.Text.ToLower().Trim();
                string unApellido = txtApellido.Text.ToLower().Trim();
                int unaCi = Convert.ToInt32(txtCi.Text.ToLower().Trim());
                string unTelefono = (txtTelefono.Text.ToLower().Trim());
                restaurante.agregarEmpleado(unRol, unNombre, unApellido, unaCi, unTelefono, unaDireccion);
                dataEmpleados.Rows.Clear();
                cargarListaEmpleados();
                limpiar();
            }
            catch (Exception) { MessageBox.Show("Error : Debes seleccionar agregar correctamente los datos"); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int unRol = comboRol.SelectedIndex;
            string unaDireccion = txtDireccion.Text.ToLower().Trim();
            string unNombre = txtNombre.Text.ToLower().Trim();
            string unApellido = txtApellido.Text.ToLower().Trim();
            int unaCi = Convert.ToInt32(txtCi.Text);
            string unTelefono =(txtTelefono.Text.ToLower().Trim());

            restaurante.ModificarEmpleado(unaCi, unRol, unTelefono, unNombre, unApellido, unaDireccion);
            limpiar();
            dataEmpleados.Rows.Clear();
            cargarListaEmpleados();
            MessageBox.Show("Empleado modificado correctamente");
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            limpiar();
            txtCi.ReadOnly = false;
        }
    }
}
