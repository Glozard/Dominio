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
    public partial class Cocina : Form
    {
        Restaurante restaurante;
        public Cocina(Restaurante unRestaurante )

        {
            this.restaurante = unRestaurante;
            InitializeComponent();
          
            dataListaPedidos.DataSource=(restaurante.levantarPedido());
        }
       



        private void dataListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void Cocina_Load(object sender, EventArgs e)
        {

        }

        private void listaComidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
