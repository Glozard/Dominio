
using System;

namespace Interface
{
    partial class ListaDePedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch (Exception) { }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDePedidos));
            this.dataPedidos = new System.Windows.Forms.DataGridView();
            this.CodigoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComidaRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Producto_Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Orden_Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backWorkerCargarData = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnExportar = new Interface.Botones();
            this.savePedidos = new System.Windows.Forms.SaveFileDialog();
            this.tipMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPedidos
            // 
            this.dataPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoRow,
            this.EstadoRow,
            this.ComidaRow,
            this.CantidadRow,
            this.Codigo_Producto_Row,
            this.Numero_Orden_Row,
            this.FechaRow,
            this.ClienteRow,
            this.TelefonoRow,
            this.DireccionRow});
            this.dataPedidos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataPedidos.Location = new System.Drawing.Point(-12, 125);
            this.dataPedidos.Name = "dataPedidos";
            this.dataPedidos.ReadOnly = true;
            this.dataPedidos.RowHeadersWidth = 51;
            this.dataPedidos.RowTemplate.Height = 29;
            this.dataPedidos.Size = new System.Drawing.Size(1395, 500);
            this.dataPedidos.TabIndex = 0;
            this.dataPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPedidos_CellContentClick);
            // 
            // CodigoRow
            // 
            this.CodigoRow.HeaderText = "Codigo";
            this.CodigoRow.MinimumWidth = 6;
            this.CodigoRow.Name = "CodigoRow";
            this.CodigoRow.ReadOnly = true;
            // 
            // EstadoRow
            // 
            this.EstadoRow.HeaderText = "Estado";
            this.EstadoRow.MinimumWidth = 6;
            this.EstadoRow.Name = "EstadoRow";
            this.EstadoRow.ReadOnly = true;
            // 
            // ComidaRow
            // 
            this.ComidaRow.HeaderText = "Comida";
            this.ComidaRow.MinimumWidth = 6;
            this.ComidaRow.Name = "ComidaRow";
            this.ComidaRow.ReadOnly = true;
            // 
            // CantidadRow
            // 
            this.CantidadRow.HeaderText = "Cantidad";
            this.CantidadRow.MinimumWidth = 6;
            this.CantidadRow.Name = "CantidadRow";
            this.CantidadRow.ReadOnly = true;
            // 
            // Codigo_Producto_Row
            // 
            this.Codigo_Producto_Row.HeaderText = "Codigo producto";
            this.Codigo_Producto_Row.MinimumWidth = 6;
            this.Codigo_Producto_Row.Name = "Codigo_Producto_Row";
            this.Codigo_Producto_Row.ReadOnly = true;
            // 
            // Numero_Orden_Row
            // 
            this.Numero_Orden_Row.HeaderText = "Numero de orden";
            this.Numero_Orden_Row.MinimumWidth = 6;
            this.Numero_Orden_Row.Name = "Numero_Orden_Row";
            this.Numero_Orden_Row.ReadOnly = true;
            // 
            // FechaRow
            // 
            this.FechaRow.HeaderText = "Fecha";
            this.FechaRow.MinimumWidth = 6;
            this.FechaRow.Name = "FechaRow";
            this.FechaRow.ReadOnly = true;
            // 
            // ClienteRow
            // 
            this.ClienteRow.HeaderText = "Cliente";
            this.ClienteRow.MinimumWidth = 6;
            this.ClienteRow.Name = "ClienteRow";
            this.ClienteRow.ReadOnly = true;
            // 
            // TelefonoRow
            // 
            this.TelefonoRow.HeaderText = "Telefono";
            this.TelefonoRow.MinimumWidth = 6;
            this.TelefonoRow.Name = "TelefonoRow";
            this.TelefonoRow.ReadOnly = true;
            // 
            // DireccionRow
            // 
            this.DireccionRow.HeaderText = "Direccion";
            this.DireccionRow.MinimumWidth = 6;
            this.DireccionRow.Name = "DireccionRow";
            this.DireccionRow.ReadOnly = true;
            // 
            // backWorkerCargarData
            // 
            this.backWorkerCargarData.WorkerReportsProgress = true;
            this.backWorkerCargarData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorkerCargarData_DoWork);
            this.backWorkerCargarData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backWorkerCargarData_ProgressChanged);
            this.backWorkerCargarData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWorkerCargarData_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-2, 648);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1398, 12);
            this.progressBar.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnExportar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnExportar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExportar.BorderRadius = 0;
            this.btnExportar.BorderSize = 0;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(1182, 69);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(188, 50);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.tipMensaje.SetToolTip(this.btnExportar, "Exporta la tabla de pedidos");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // savePedidos
            // 
            this.savePedidos.DefaultExt = "csv";
            this.savePedidos.Filter = "Archivos CSV|*.csv";
            // 
            // tipMensaje
            // 
            this.tipMensaje.IsBalloon = true;
            this.tipMensaje.Popup += new System.Windows.Forms.PopupEventHandler(this.tipMensaje_Popup);
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(12, 628);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(83, 20);
            this.lblCargando.TabIndex = 3;
            this.lblCargando.Text = "Cargando...";
            // 
            // ListaDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataPedidos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ListaDePedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaDePedidos_FormClosing);
            this.Load += new System.EventHandler(this.ListaDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPedidos;
        private System.ComponentModel.BackgroundWorker backWorkerCargarData;
        private System.Windows.Forms.ProgressBar progressBar;
        private Botones btnExportar;
        private System.Windows.Forms.SaveFileDialog savePedidos;
        private System.Windows.Forms.ToolTip tipMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComidaRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto_Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Orden_Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionRow;
        private System.Windows.Forms.Label lblCargando;
    }
}