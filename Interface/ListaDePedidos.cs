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
    public partial class ListaDePedidos : Form
    {
        Restaurante restaurante;
        public ListaDePedidos(Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
            InitializeComponent();
        }

        private void ListaDePedidos_Load(object sender, EventArgs e)
        {
            dataPedidos.AutoGenerateColumns = true;
            dataPedidos.DataSource = restaurante.CargarPedidos();
        }
    }
}
