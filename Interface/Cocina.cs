using DominioElChivito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Interface
{
    public partial class Cocina : Form
    {
        Stopwatch reloj = new Stopwatch();
        int posicion = 0;
        Restaurante restaurante;
        bool mostreAlerta;
        public Cocina(Restaurante unRestaurante )
        {
            this.restaurante = unRestaurante;
            InitializeComponent();
            btnTerminado.Enabled = false;
            cargarListaPedidos();
            mostreAlerta = false;
        }
        public void cargarListaPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            DataTable dt = new DataTable();
            dt = restaurante.CargarPedidos();
            for (int i = 0; i < restaurante.CargarPedidos().Rows.Count; i++)
            {
                Pedido p = new Pedido();
                p.Codigo = (int)dt.Rows[i][0];
                p.Comida = ((string)dt.Rows[i][7]);
                p.Cantidad = (int)dt.Rows[i][4];
                p.Numero_orden = (int)dt.Rows[i][2];
                p.Estado = (string)dt.Rows[i][8];
                if (p.Estado == "pendiente")
                {
                pedidos.Add(p);
                }
            }
            foreach (Pedido aux in pedidos)
            {
                int indice = dataListaPedidos.Rows.Add();
                dataListaPedidos.Rows[indice].Cells[0].Value = aux.Comida;
                dataListaPedidos.Rows[indice].Cells[1].Value = aux.Cantidad;
                dataListaPedidos.Rows[indice].Cells[2].Value = aux.Codigo;
                dataListaPedidos.Rows[indice].Cells[3].Value = aux.Estado;
                dataListaPedidos.Rows[indice].Cells[4].Value = aux.Numero_orden;
            }
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


        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0 , 0 , (int)reloj.ElapsedMilliseconds);
            txtSegundos.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMinutos.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtHoras.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            if (Convert.ToInt32(txtMinutos.Text) == 45 && !mostreAlerta)
            {
                mostreAlerta = true;
                DialogResult dr = MessageBox.Show("Debes terminar el pedido ya!");
                if (dr == DialogResult.OK) mostreAlerta = false;                
            }

        }




        private void btnComenzar_Click_1(object sender, EventArgs e)
        {
            btnTerminado.Enabled = true;
            reloj.Start();
            timer.Enabled = true;
            btnComenzar.Enabled = false;
        }

        private void btnTerminado_Click_1(object sender, EventArgs e)
        {
            posicion = dataListaPedidos.CurrentRow.Index;
            reloj.Reset();
            txtSegundos.Text = "00";
            txtMinutos.Text = "00";
            txtHoras.Text = "00";
            timer.Enabled = false;
            btnTerminado.Enabled = false;
            btnComenzar.Enabled = true;
            int codigo = (int)dataListaPedidos[2, 0].Value;
            restaurante.PedidoTerminado(codigo);
            dataListaPedidos.Rows.RemoveAt(0);
        }

        private void btnListaDeProductos_Click_1(object sender, EventArgs e)
        {
            agregarPedido agregar = new agregarPedido(restaurante, 0);
            agregar.Show();
        }
    }
}
