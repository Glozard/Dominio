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
        byte unRol;

        Restaurante restaurante;
        public Login(Restaurante unRestaurante)
        {

            this.restaurante = unRestaurante;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            unNombre = txtNombre.Text;
            unaContraseña = Convert.ToInt32(txtContraseña.Text);
            unRol = (byte)comboRol.SelectedIndex;
            

            bool resp = restaurante.Login(unNombre , unaContraseña , unRol);
            if (resp)
            { 
               if(unRol == 0)
                {
                    MenuPrincipal menu = new MenuPrincipal(restaurante);
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
