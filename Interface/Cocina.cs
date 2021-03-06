using DominioElChivito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;

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
                p.Direccion = (string)dt.Rows[i][1];
                p.Telefono = (string)dt.Rows[i][6];
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
                dataListaPedidos.Rows[indice].Cells[5].Value = aux.Direccion;
                dataListaPedidos.Rows[indice].Cells[6].Value = aux.Telefono;
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
            try
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
                printDocument1 = new System.Drawing.Printing.PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += Imprimir;
                printDocument1.Print();
                dataListaPedidos.Rows.RemoveAt(0);
            }
            catch (Exception) { MessageBox.Show("Imposible realizar esta acción");}
        }
   

        private void btnListaDeProductos_Click_1(object sender, EventArgs e)
        {
            agregarPedido agregar = new agregarPedido(restaurante, 0);
            agregar.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int y = 10;
            string direccion = dataListaPedidos[5, 0].Value.ToString();
            e.Graphics.DrawString("--Pedido--", font, Brushes.Black, new RectangleF(5, y+=15, 300, 20));
            e.Graphics.DrawString("Dirección:", font, Brushes.Black, new RectangleF(5, y += 25, 300, 20));
            e.Graphics.DrawString(direccion, font, Brushes.Black, new RectangleF(5, y += 20, 300, 20));
            e.Graphics.DrawString("Teléfono:", font, Brushes.Black, new RectangleF(5, y += 25, 300, 20));
            e.Graphics.DrawString(dataListaPedidos[6 ,0].Value.ToString(), font, Brushes.Black, new RectangleF(5, y += 20, 300, 20));
            e.Graphics.DrawString("Comida:", font, Brushes.Black, new RectangleF(5, y += 25, 300, 20));
            e.Graphics.DrawString(dataListaPedidos[0, 0].Value.ToString(), font, Brushes.Black, new RectangleF(5, y += 20, 300, 20));
            e.Graphics.DrawString("Cantidad:", font, Brushes.Black, new RectangleF(0, y += 25, 300, 20));
            e.Graphics.DrawString(dataListaPedidos[1, 0].Value.ToString(), font, Brushes.Black, new RectangleF(5, y += 20, 300, 20 ));
        }
    }
}
