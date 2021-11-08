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
            
                unNombre = txtNombre.Text;
                unaContraseña = Convert.ToInt32(txtContraseña.Text);
                unRol = (byte)comboRol.SelectedIndex;
            int rol = rol = restaurante.Login(unNombre, unaContraseña, unRol).Rol;

               if(rol == 0)
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
    }
}
