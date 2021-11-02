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
            

            bool resp = restaurante.Login(unNombre , unaContraseña );
            if (resp)
            {
                if (AccessibleRole == 0) { } //coso
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
