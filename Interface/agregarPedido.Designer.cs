
namespace Interface
{
    partial class agregarPedido
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.dataPedido = new System.Windows.Forms.DataGridView();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_de_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaComida = new System.Windows.Forms.TabControl();
            this.Pizza = new System.Windows.Forms.TabPage();
            this.listaPizza = new System.Windows.Forms.ListBox();
            this.Hamburguesa = new System.Windows.Forms.TabPage();
            this.listaHamburguesa = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tablaChivito = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).BeginInit();
            this.tablaComida.SuspendLayout();
            this.Pizza.SuspendLayout();
            this.Hamburguesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(199, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(49, 15);
            this.lblProducto.TabIndex = 24;
            this.lblProducto.Text = "Comida";
            // 
            // dataPedido
            // 
            this.dataPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comida,
            this.Cantidad,
            this.Dirección,
            this.Numero_de_Orden,
            this.Codigo,
            this.Cliente});
            this.dataPedido.Location = new System.Drawing.Point(31, 247);
            this.dataPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.RowHeadersWidth = 51;
            this.dataPedido.RowTemplate.Height = 29;
            this.dataPedido.Size = new System.Drawing.Size(804, 138);
            this.dataPedido.TabIndex = 26;
            this.dataPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.MinimumWidth = 6;
            this.Dirección.Name = "Dirección";
            this.Dirección.Width = 125;
            // 
            // Numero_de_Orden
            // 
            this.Numero_de_Orden.HeaderText = "Numero de Orden";
            this.Numero_de_Orden.MinimumWidth = 6;
            this.Numero_de_Orden.Name = "Numero_de_Orden";
            this.Numero_de_Orden.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // tablaComida
            // 
            this.tablaComida.Controls.Add(this.Pizza);
            this.tablaComida.Controls.Add(this.Hamburguesa);
            this.tablaComida.Controls.Add(this.tablaChivito);
            this.tablaComida.Location = new System.Drawing.Point(27, 46);
            this.tablaComida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaComida.Name = "tablaComida";
            this.tablaComida.SelectedIndex = 0;
            this.tablaComida.Size = new System.Drawing.Size(706, 182);
            this.tablaComida.TabIndex = 27;
            // 
            // Pizza
            // 
            this.Pizza.Controls.Add(this.listaPizza);
            this.Pizza.Location = new System.Drawing.Point(4, 24);
            this.Pizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pizza.Name = "Pizza";
            this.Pizza.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pizza.Size = new System.Drawing.Size(698, 154);
            this.Pizza.TabIndex = 1;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = true;
            // 
            // listaPizza
            // 
            this.listaPizza.FormattingEnabled = true;
            this.listaPizza.ItemHeight = 15;
            this.listaPizza.Items.AddRange(new object[] {
            "Pizza"});
            this.listaPizza.Location = new System.Drawing.Point(14, 9);
            this.listaPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaPizza.Name = "listaPizza";
            this.listaPizza.Size = new System.Drawing.Size(617, 139);
            this.listaPizza.TabIndex = 0;
            // 
            // Hamburguesa
            // 
            this.Hamburguesa.Controls.Add(this.listaHamburguesa);
            this.Hamburguesa.Location = new System.Drawing.Point(4, 24);
            this.Hamburguesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hamburguesa.Name = "Hamburguesa";
            this.Hamburguesa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hamburguesa.Size = new System.Drawing.Size(698, 154);
            this.Hamburguesa.TabIndex = 2;
            this.Hamburguesa.Text = "Hamburguesa";
            this.Hamburguesa.UseVisualStyleBackColor = true;
            // 
            // listaHamburguesa
            // 
            this.listaHamburguesa.FormattingEnabled = true;
            this.listaHamburguesa.ItemHeight = 15;
            this.listaHamburguesa.Items.AddRange(new object[] {
            "Hamburguesa"});
            this.listaHamburguesa.Location = new System.Drawing.Point(17, 9);
            this.listaHamburguesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaHamburguesa.Name = "listaHamburguesa";
            this.listaHamburguesa.Size = new System.Drawing.Size(669, 139);
            this.listaHamburguesa.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(992, 82);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(852, 79);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(110, 23);
            this.txtCantidad.TabIndex = 29;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(852, 124);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(110, 23);
            this.txtDireccion.TabIndex = 31;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(992, 126);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblAgregar
            // 
            this.lblAgregar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgregar.Location = new System.Drawing.Point(852, 190);
            this.lblAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(170, 34);
            this.lblAgregar.TabIndex = 32;
            this.lblAgregar.Text = "Agregar";
            this.lblAgregar.UseVisualStyleBackColor = true;
            this.lblAgregar.Click += new System.EventHandler(this.lblAgregar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(875, 237);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 31);
            this.btnEnviar.TabIndex = 33;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tablaChivito
            // 
            this.tablaChivito.Location = new System.Drawing.Point(4, 24);
            this.tablaChivito.Name = "tablaChivito";
            this.tablaChivito.Padding = new System.Windows.Forms.Padding(3);
            this.tablaChivito.Size = new System.Drawing.Size(698, 154);
            this.tablaChivito.TabIndex = 3;
            this.tablaChivito.Text = "Chivito";
            this.tablaChivito.UseVisualStyleBackColor = true;
            // 
            // agregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 464);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tablaComida);
            this.Controls.Add(this.dataPedido);
            this.Controls.Add(this.lblProducto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "agregarPedido";
            this.Text = "agregarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).EndInit();
            this.tablaComida.ResumeLayout(false);
            this.Pizza.ResumeLayout(false);
            this.Hamburguesa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dataPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.TabControl tablaComida;
        private System.Windows.Forms.TabPage Pizza;
        private System.Windows.Forms.ListBox listaPizza;
        private System.Windows.Forms.TabPage Hamburguesa;
        private System.Windows.Forms.ListBox listaHamburguesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button lblAgregar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TabPage tablaChivito;
    }
}