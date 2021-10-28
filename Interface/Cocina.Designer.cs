
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
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNumeroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColumCodigoProducto,
            this.ColumNumeroOrden});
            this.dataListaPedidos.Location = new System.Drawing.Point(10, 152);
            this.dataListaPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListaPedidos.Name = "dataListaPedidos";
            this.dataListaPedidos.RowHeadersWidth = 51;
            this.dataListaPedidos.RowTemplate.Height = 29;
            this.dataListaPedidos.Size = new System.Drawing.Size(558, 141);
            this.dataListaPedidos.TabIndex = 0;
            this.dataListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPedidos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Comida";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.Name = "ColumCantidad";
            // 
            // ColumCodigo
            // 
            this.ColumCodigo.HeaderText = "Codigo";
            this.ColumCodigo.Name = "ColumCodigo";
            // 
            // ColumCodigoProducto
            // 
            this.ColumCodigoProducto.HeaderText = "Codigo Producto";
            this.ColumCodigoProducto.Name = "ColumCodigoProducto";
            // 
            // ColumNumeroOrden
            // 
            this.ColumNumeroOrden.HeaderText = "Numero de Orden";
            this.ColumNumeroOrden.Name = "ColumNumeroOrden";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(29, 118);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(82, 22);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(131, 118);
            this.btnTerminado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(82, 22);
            this.btnTerminado.TabIndex = 2;
            this.btnTerminado.Text = "Terminado";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundos.Location = new System.Drawing.Point(404, 53);
            this.txtSegundos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.ReadOnly = true;
            this.txtSegundos.Size = new System.Drawing.Size(68, 32);
            this.txtSegundos.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinutos.Location = new System.Drawing.Point(331, 53);
            this.txtMinutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.ReadOnly = true;
            this.txtMinutos.Size = new System.Drawing.Size(68, 32);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.Location = new System.Drawing.Point(258, 53);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(68, 32);
            this.txtHoras.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnListaDeProductos
            // 
            this.btnListaDeProductos.Location = new System.Drawing.Point(18, 9);
            this.btnListaDeProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaDeProductos.Name = "btnListaDeProductos";
            this.btnListaDeProductos.Size = new System.Drawing.Size(195, 29);
            this.btnListaDeProductos.TabIndex = 6;
            this.btnListaDeProductos.Text = "Modificar lista de productos";
            this.btnListaDeProductos.UseVisualStyleBackColor = true;
            this.btnListaDeProductos.Click += new System.EventHandler(this.btnListaDeProductos_Click);
            // 
            // Comida
            // 
            this.Comida.HeaderText = "Comida";
            this.Comida.Name = "Comida";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Comida";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 338);
            this.Controls.Add(this.btnListaDeProductos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.dataListaPedidos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNumeroOrden;
    }
}