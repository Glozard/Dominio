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
        public Cocina(Restaurante unRestaurante )

        {
            this.restaurante = unRestaurante;
            InitializeComponent();
            btnTerminado.Enabled = false;
          
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

        private void btnComenzar_Click(object sender, EventArgs e)
        {

            btnTerminado.Enabled = true;
            reloj.Start();
            timer.Enabled = true;
            btnComenzar.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0 , 0 , (int)reloj.ElapsedMilliseconds);
            txtSegundos.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMinutos.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtHoras.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            posicion = dataListaPedidos.CurrentRow.Index;
            

            reloj.Reset();
            txtSegundos.Text = "00";
            txtMinutos.Text = "00";
            txtHoras.Text = "00";
            timer.Enabled = false;
            btnTerminado.Enabled = false;
            btnComenzar.Enabled = true;

           // dataListaPedidos.Rows.RemoveAt(posicion);

        }

        private void btnListaDeProductos_Click(object sender, EventArgs e)
        {
            agregarPedido agregar = new agregarPedido(posicion);
            agregar.Show();
        }
    }
}
