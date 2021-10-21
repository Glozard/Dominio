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
        Restaurante restaurante;
        public Login(Restaurante unRestaurante)
        {

            this.restaurante = unRestaurante;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
