
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
            this.dataListaPedidos = new System.Windows.Forms.DataGridView();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnListaDeProductos = new System.Windows.Forms.Button();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNumeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaPedidos
            // 
            this.dataListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.ColumCantidad,
            this.ColumCodigo,
            this.EstadoRow,
            this.ColumNumeroOrden});
            this.dataListaPedidos.Location = new System.Drawing.Point(11, 203);
            this.dataListaPedidos.Name = "dataListaPedidos";
            this.dataListaPedidos.RowHeadersWidth = 51;
            this.dataListaPedidos.RowTemplate.Height = 29;
            this.dataListaPedidos.Size = new System.Drawing.Size(680, 188);
            this.dataListaPedidos.TabIndex = 0;
            this.dataListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPedidos_CellContentClick);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(33, 157);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(94, 29);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(150, 157);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(94, 29);
            this.btnTerminado.TabIndex = 2;
            this.btnTerminado.Text = "Terminado";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundos.Location = new System.Drawing.Point(462, 71);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.ReadOnly = true;
            this.txtSegundos.Size = new System.Drawing.Size(77, 39);
            this.txtSegundos.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinutos.Location = new System.Drawing.Point(378, 71);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.ReadOnly = true;
            this.txtMinutos.Size = new System.Drawing.Size(77, 39);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.Location = new System.Drawing.Point(295, 71);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(77, 39);
            this.txtHoras.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnListaDeProductos
            // 
            this.btnListaDeProductos.Location = new System.Drawing.Point(21, 12);
            this.btnListaDeProductos.Name = "btnListaDeProductos";
            this.btnListaDeProductos.Size = new System.Drawing.Size(223, 39);
            this.btnListaDeProductos.TabIndex = 6;
            this.btnListaDeProductos.Text = "Modificar lista de productos";
            this.btnListaDeProductos.UseVisualStyleBackColor = true;
            this.btnListaDeProductos.Click += new System.EventHandler(this.btnListaDeProductos_Click);
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
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 451);
            this.Controls.Add(this.btnListaDeProductos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.dataListaPedidos);
            this.Name = "Cocina";
            this.Text = "Cocina";
            this.Load += new System.EventHandler(this.Cocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaPedidos;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnTerminado;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnListaDeProductos;
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
    }
}