using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DominioElChivito;

namespace Interface
{
    public partial class ListaDePedidos : Form
    {
        List<Pedido> pedidos = new List<Pedido>();

        Restaurante restaurante;
        int indice = 0;
        public ListaDePedidos(Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
            InitializeComponent();         

        }
        
        private void ListaDePedidos_Load(object sender, EventArgs e)
        {
            btnExportar.Visible = false;
            CheckForIllegalCrossThreadCalls = false;

            if (backWorkerCargarData.IsBusy != true)
            {
                backWorkerCargarData.RunWorkerAsync();
            }else { btnExportar.Visible = true; }
        }

        private void backWorkerCargarData_DoWork(object sender, DoWorkEventArgs e)
        {           
            DataTable dt = new DataTable();
            dt = restaurante.CargarPedidos();
            
                for (int i = 1; i < restaurante.CargarPedidos().Rows.Count; i++) 
                {                 
                        Pedido p = new Pedido();
                        p.Codigo = (int)dt.Rows[i][0];
                        p.Estado = ((string)dt.Rows[i][8]);
                        p.Comida = (string)dt.Rows[i][7];
                        p.Cantidad = (int)dt.Rows[i][4];
                        p.Codigo_producto = (int)dt.Rows[i][3];
                        p.Numero_orden = (int)dt.Rows[i][2];
                        p.Fecha = (DateTime)dt.Rows[i][5];
                        p.Cliente = (string)dt.Rows[i][9];
                        p.Telefono = (string)dt.Rows[i][7];
                        p.Direccion = (string)dt.Rows[i][1];
                        pedidos.Add(p);
                        
                }
                int cantidad = pedidos.Count;
                int periodo = 100 / cantidad;
                int progreso = 0;
                foreach (Pedido aux in pedidos)
            {
                try
                {
                    indice = dataPedidos.Rows.Add();            
                    dataPedidos.Rows[indice].Cells[0].Value = aux.Codigo;
                    dataPedidos.Rows[indice].Cells[1].Value = aux.Estado;
                    dataPedidos.Rows[indice].Cells[2].Value = aux.Comida;
                    dataPedidos.Rows[indice].Cells[3].Value = aux.Cantidad;
                    dataPedidos.Rows[indice].Cells[4].Value = aux.Codigo_producto;
                    dataPedidos.Rows[indice].Cells[5].Value = aux.Numero_orden;
                    dataPedidos.Rows[indice].Cells[6].Value = aux.Fecha.ToString();
                    dataPedidos.Rows[indice].Cells[7].Value = aux.Cliente;
                    dataPedidos.Rows[indice].Cells[8].Value = aux.Telefono;
                    dataPedidos.Rows[indice].Cells[9].Value = aux.Direccion;
                    progreso = progreso + periodo;
                    backWorkerCargarData.ReportProgress(progreso);
                    Thread.Sleep(100);
                }
                catch (Exception) { }
                
            }
            
                  backWorkerCargarData.ReportProgress(100);
        }

        private void backWorkerCargarData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DialogResult dr = savePedidos.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string nombreArchivo = savePedidos.FileName;
                exportCSV(nombreArchivo);
                MessageBox.Show("Archivo exportado correctamente en:" + nombreArchivo);
            }
        }
        void exportCSV(string nombreArchivo)
        {
            StreamWriter file = new StreamWriter(nombreArchivo);
            file.WriteLine("Codigo ; Estado ; Comida ; Cantidad ; Codigo de Producto ; Numero de orden ; Fecha ; Cliente ; Telefono ; Direccion");

            foreach (Pedido aux in pedidos)
            {
                file.WriteLine(aux.Codigo + ";" + aux.Estado + ";" + aux.Comida + ";" + aux.Cantidad + ";" + aux.Codigo_producto + ";" + aux.Numero_orden + ";" + aux.Fecha + ";" + aux.Cliente + ";" + aux.Telefono + ";" + aux.Direccion);
            }
            file.Close();
        }

        private void tipMensaje_Popup(object sender, PopupEventArgs e)
        {

        }

        private void backWorkerCargarData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnExportar.Visible = true;
            progressBar.Visible = false;
            lblCargando.Visible = false;
        }

        private void dataPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDePedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
