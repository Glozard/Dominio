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
    public partial class Login : Form
    {
        string unNombre = "";
        int unaContraseña;
        int unRol;

        Restaurante restaurante;
        public Login(Restaurante unRestaurante)
        {

            this.restaurante = unRestaurante;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
        }

     
        private void checkVerContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVerContrasenia.Checked == true)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
        private void botones2_Click(object sender, EventArgs e)
        {
            int rol = -1;
            try
            {
                unNombre = txtNombre.Text.ToLower().Trim();
                unaContraseña = Convert.ToInt32(txtContraseña.Text);
                unRol = (byte)comboRol.SelectedIndex;
                Empleado emp = restaurante.Login(unNombre, unaContraseña, unRol);
                if (emp != null)
                    rol = emp.Rol;
                else throw new Exception();
                if (rol == 0)
                {
                    MenuPrincipal menu = new MenuPrincipal(restaurante);
                    menu.Show();
                }
                if (rol == 1)
                {
                    agregarPedido pedido = new agregarPedido(restaurante, 1);
                    pedido.Show();
                }
                if (rol == 2)
                {
                    Cocina cocina = new Cocina(restaurante);
                    cocina.Show();
                }
            }
            catch (Exception) { MessageBox.Show("Usuario incorrecto"); } 
 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
