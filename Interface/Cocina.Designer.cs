
namespace Interface
{
    partial class Cocina
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cocina));
            this.dataListaPedidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNumeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComenzar = new Interface.Botones();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTerminado = new Interface.Botones();
            this.btnListaDeProductos = new Interface.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaPedidos
            // 
            this.dataListaPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.ColumCantidad,
            this.ColumCodigo,
            this.EstadoRow,
            this.ColumNumeroOrden});
            this.dataListaPedidos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataListaPedidos.Location = new System.Drawing.Point(321, 268);
            this.dataListaPedidos.Name = "dataListaPedidos";
            this.dataListaPedidos.RowHeadersWidth = 51;
            this.dataListaPedidos.RowTemplate.Height = 29;
            this.dataListaPedidos.Size = new System.Drawing.Size(680, 188);
            this.dataListaPedidos.TabIndex = 0;
            this.dataListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPedidos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Comida";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.Width = 125;
            // 
            // ColumCodigo
            // 
            this.ColumCodigo.HeaderText = "Codigo";
            this.ColumCodigo.MinimumWidth = 6;
            this.ColumCodigo.Name = "ColumCodigo";
            this.ColumCodigo.Width = 125;
            // 
            // EstadoRow
            // 
            this.EstadoRow.HeaderText = "Estado";
            this.EstadoRow.MinimumWidth = 6;
            this.EstadoRow.Name = "EstadoRow";
            this.EstadoRow.Width = 125;
            // 
            // ColumNumeroOrden
            // 
            this.ColumNumeroOrden.HeaderText = "Numero de Orden";
            this.ColumNumeroOrden.MinimumWidth = 6;
            this.ColumNumeroOrden.Name = "ColumNumeroOrden";
            this.ColumNumeroOrden.Width = 125;
            // 
            // txtSegundos
            // 
            this.txtSegundos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSegundos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundos.Location = new System.Drawing.Point(727, 185);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.ReadOnly = true;
            this.txtSegundos.Size = new System.Drawing.Size(77, 52);
            this.txtSegundos.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMinutos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinutos.Location = new System.Drawing.Point(643, 185);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.ReadOnly = true;
            this.txtMinutos.Size = new System.Drawing.Size(77, 52);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHoras.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.Location = new System.Drawing.Point(560, 185);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(77, 52);
            this.txtHoras.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Comida
            // 
            this.Comida.HeaderText = "Comida";
            this.Comida.MinimumWidth = 6;
            this.Comida.Name = "Comida";
            this.Comida.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Comida";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnComenzar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnComenzar.BorderColor = System.Drawing.Color.White;
            this.btnComenzar.BorderRadius = 0;
            this.btnComenzar.BorderSize = 1;
            this.btnComenzar.FlatAppearance.BorderSize = 0;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(490, 490);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(188, 50);
            this.btnComenzar.TabIndex = 45;
            this.btnComenzar.Text = "&Comenzar";
            this.btnComenzar.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnComenzar, "Comienza el contador para realizar el pedido que esta primero");
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click_1);
            // 
            // btnTerminado
            // 
            this.btnTerminado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnTerminado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnTerminado.BorderColor = System.Drawing.Color.White;
            this.btnTerminado.BorderRadius = 0;
            this.btnTerminado.BorderSize = 1;
            this.btnTerminado.FlatAppearance.BorderSize = 0;
            this.btnTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminado.ForeColor = System.Drawing.Color.White;
            this.btnTerminado.Location = new System.Drawing.Point(718, 490);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(188, 50);
            this.btnTerminado.TabIndex = 46;
            this.btnTerminado.Text = "&Terminado";
            this.btnTerminado.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnTerminado, "Termina el contador y se borra de la lista el primer pedido de la lista");
            this.btnTerminado.UseVisualStyleBackColor = false;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click_1);
            // 
            // btnListaDeProductos
            // 
            this.btnListaDeProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnListaDeProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnListaDeProductos.BorderColor = System.Drawing.Color.White;
            this.btnListaDeProductos.BorderRadius = 0;
            this.btnListaDeProductos.BorderSize = 1;
            this.btnListaDeProductos.FlatAppearance.BorderSize = 0;
            this.btnListaDeProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDeProductos.ForeColor = System.Drawing.Color.White;
            this.btnListaDeProductos.Location = new System.Drawing.Point(24, 23);
            this.btnListaDeProductos.Name = "btnListaDeProductos";
            this.btnListaDeProductos.Size = new System.Drawing.Size(223, 50);
            this.btnListaDeProductos.TabIndex = 47;
            this.btnListaDeProductos.Text = "&Modificar lista de productos";
            this.btnListaDeProductos.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnListaDeProductos, "Desplega el apartado para modificar la disponibilidad de un producto");
            this.btnListaDeProductos.UseVisualStyleBackColor = false;
            this.btnListaDeProductos.Click += new System.EventHandler(this.btnListaDeProductos_Click_1);
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.btnListaDeProductos);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.dataListaPedidos);
            this.DoubleBuffered = true;
            this.Name = "Cocina";
            this.Text = "Cocina";
            this.Load += new System.EventHandler(this.Cocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaPedidos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNumeroOrden;
        private Botones btnComenzar;
        private System.Windows.Forms.ToolTip toolTip1;
        private Botones btnTerminado;
        private Botones btnListaDeProductos;
    }
}