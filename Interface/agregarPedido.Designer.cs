
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
            this.ComidaRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroOrdenRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaComida = new System.Windows.Forms.TabControl();
            this.Pizza = new System.Windows.Forms.TabPage();
            this.lblNoDisponible = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.listaPizzaNoDisponible = new System.Windows.Forms.ListBox();
            this.listaPizza = new System.Windows.Forms.ListBox();
            this.Hamburguesa = new System.Windows.Forms.TabPage();
            this.listaHamburguesa = new System.Windows.Forms.ListBox();
            this.tablaChivito = new System.Windows.Forms.TabPage();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnNoDisponble = new System.Windows.Forms.Button();
            this.btnDisponible = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).BeginInit();
            this.tablaComida.SuspendLayout();
            this.Pizza.SuspendLayout();
            this.Hamburguesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(227, 27);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 20);
            this.lblProducto.TabIndex = 24;
            this.lblProducto.Text = "Comida";
            // 
            // dataPedido
            // 
            this.dataPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComidaRow,
            this.CantidadRow,
            this.DireccionRow,
            this.NumeroOrdenRow,
            this.CodigoRow,
            this.TelefonoRow,
            this.ClienteRow});
            this.dataPedido.Location = new System.Drawing.Point(35, 369);
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.RowHeadersWidth = 51;
            this.dataPedido.RowTemplate.Height = 29;
            this.dataPedido.Size = new System.Drawing.Size(934, 184);
            this.dataPedido.TabIndex = 26;
            this.dataPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ComidaRow
            // 
            this.ComidaRow.HeaderText = "Comida";
            this.ComidaRow.MinimumWidth = 6;
            this.ComidaRow.Name = "ComidaRow";
            this.ComidaRow.Width = 125;
            // 
            // CantidadRow
            // 
            this.CantidadRow.HeaderText = "Cantidad";
            this.CantidadRow.MinimumWidth = 6;
            this.CantidadRow.Name = "CantidadRow";
            this.CantidadRow.Width = 125;
            // 
            // DireccionRow
            // 
            this.DireccionRow.HeaderText = "Direccion";
            this.DireccionRow.MinimumWidth = 6;
            this.DireccionRow.Name = "DireccionRow";
            this.DireccionRow.Width = 125;
            // 
            // NumeroOrdenRow
            // 
            this.NumeroOrdenRow.HeaderText = "Numero de oreden";
            this.NumeroOrdenRow.MinimumWidth = 6;
            this.NumeroOrdenRow.Name = "NumeroOrdenRow";
            this.NumeroOrdenRow.Width = 125;
            // 
            // CodigoRow
            // 
            this.CodigoRow.HeaderText = "Codigo";
            this.CodigoRow.MinimumWidth = 6;
            this.CodigoRow.Name = "CodigoRow";
            this.CodigoRow.Width = 125;
            // 
            // TelefonoRow
            // 
            this.TelefonoRow.HeaderText = "Telefono";
            this.TelefonoRow.MinimumWidth = 6;
            this.TelefonoRow.Name = "TelefonoRow";
            this.TelefonoRow.Width = 125;
            // 
            // ClienteRow
            // 
            this.ClienteRow.HeaderText = "Cliente";
            this.ClienteRow.MinimumWidth = 6;
            this.ClienteRow.Name = "ClienteRow";
            this.ClienteRow.Width = 125;
            // 
            // tablaComida
            // 
            this.tablaComida.Controls.Add(this.Pizza);
            this.tablaComida.Controls.Add(this.Hamburguesa);
            this.tablaComida.Controls.Add(this.tablaChivito);
            this.tablaComida.Location = new System.Drawing.Point(31, 61);
            this.tablaComida.Name = "tablaComida";
            this.tablaComida.SelectedIndex = 0;
            this.tablaComida.Size = new System.Drawing.Size(807, 243);
            this.tablaComida.TabIndex = 27;
            // 
            // Pizza
            // 
            this.Pizza.Controls.Add(this.lblNoDisponible);
            this.Pizza.Controls.Add(this.lblDisponible);
            this.Pizza.Controls.Add(this.listaPizzaNoDisponible);
            this.Pizza.Controls.Add(this.listaPizza);
            this.Pizza.Location = new System.Drawing.Point(4, 29);
            this.Pizza.Name = "Pizza";
            this.Pizza.Padding = new System.Windows.Forms.Padding(3);
            this.Pizza.Size = new System.Drawing.Size(799, 210);
            this.Pizza.TabIndex = 1;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = true;
            // 
            // lblNoDisponible
            // 
            this.lblNoDisponible.AutoSize = true;
            this.lblNoDisponible.Location = new System.Drawing.Point(558, 9);
            this.lblNoDisponible.Name = "lblNoDisponible";
            this.lblNoDisponible.Size = new System.Drawing.Size(103, 20);
            this.lblNoDisponible.TabIndex = 37;
            this.lblNoDisponible.Text = "No disponible";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(137, 9);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(81, 20);
            this.lblDisponible.TabIndex = 36;
            this.lblDisponible.Text = "Disponible";
            // 
            // listaPizzaNoDisponible
            // 
            this.listaPizzaNoDisponible.FormattingEnabled = true;
            this.listaPizzaNoDisponible.ItemHeight = 20;
            this.listaPizzaNoDisponible.Location = new System.Drawing.Point(411, 32);
            this.listaPizzaNoDisponible.Name = "listaPizzaNoDisponible";
            this.listaPizzaNoDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaPizzaNoDisponible.TabIndex = 1;
            // 
            // listaPizza
            // 
            this.listaPizza.FormattingEnabled = true;
            this.listaPizza.ItemHeight = 20;
            this.listaPizza.Items.AddRange(new object[] {
            "Pizza"});
            this.listaPizza.Location = new System.Drawing.Point(16, 32);
            this.listaPizza.Name = "listaPizza";
            this.listaPizza.Size = new System.Drawing.Size(375, 164);
            this.listaPizza.TabIndex = 0;
            // 
            // Hamburguesa
            // 
            this.Hamburguesa.Controls.Add(this.listaHamburguesa);
            this.Hamburguesa.Location = new System.Drawing.Point(4, 29);
            this.Hamburguesa.Name = "Hamburguesa";
            this.Hamburguesa.Padding = new System.Windows.Forms.Padding(3);
            this.Hamburguesa.Size = new System.Drawing.Size(799, 210);
            this.Hamburguesa.TabIndex = 2;
            this.Hamburguesa.Text = "Hamburguesa";
            this.Hamburguesa.UseVisualStyleBackColor = true;
            // 
            // listaHamburguesa
            // 
            this.listaHamburguesa.FormattingEnabled = true;
            this.listaHamburguesa.ItemHeight = 20;
            this.listaHamburguesa.Items.AddRange(new object[] {
            "Hamburguesa"});
            this.listaHamburguesa.Location = new System.Drawing.Point(19, 12);
            this.listaHamburguesa.Name = "listaHamburguesa";
            this.listaHamburguesa.Size = new System.Drawing.Size(764, 184);
            this.listaHamburguesa.TabIndex = 0;
            // 
            // tablaChivito
            // 
            this.tablaChivito.Location = new System.Drawing.Point(4, 29);
            this.tablaChivito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablaChivito.Name = "tablaChivito";
            this.tablaChivito.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablaChivito.Size = new System.Drawing.Size(799, 210);
            this.tablaChivito.TabIndex = 3;
            this.tablaChivito.Text = "Chivito";
            this.tablaChivito.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(1134, 109);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 20);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(974, 105);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 27);
            this.txtCantidad.TabIndex = 29;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(974, 165);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 27);
            this.txtDireccion.TabIndex = 31;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(1134, 168);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblAgregar
            // 
            this.lblAgregar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgregar.Location = new System.Drawing.Point(975, 369);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(194, 45);
            this.lblAgregar.TabIndex = 32;
            this.lblAgregar.Text = "Agregar";
            this.lblAgregar.UseVisualStyleBackColor = true;
            this.lblAgregar.Click += new System.EventHandler(this.lblAgregar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(1001, 432);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(137, 41);
            this.btnEnviar.TabIndex = 33;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnNoDisponble
            // 
            this.btnNoDisponble.Location = new System.Drawing.Point(427, 316);
            this.btnNoDisponble.Name = "btnNoDisponble";
            this.btnNoDisponble.Size = new System.Drawing.Size(169, 48);
            this.btnNoDisponble.TabIndex = 34;
            this.btnNoDisponble.Text = "No disponible";
            this.btnNoDisponble.UseVisualStyleBackColor = true;
            this.btnNoDisponble.Click += new System.EventHandler(this.btnNoDisponble_Click);
            // 
            // btnDisponible
            // 
            this.btnDisponible.Location = new System.Drawing.Point(251, 316);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(169, 48);
            this.btnDisponible.TabIndex = 35;
            this.btnDisponible.Text = "Disponible";
            this.btnDisponible.UseVisualStyleBackColor = true;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(1152, 575);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(142, 29);
            this.btnAgregarCliente.TabIndex = 36;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(974, 229);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 38;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(1134, 232);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 37;
            this.lblTelefono.Text = "Telefono";
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(974, 288);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(151, 28);
            this.comboClientes.TabIndex = 39;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(1134, 291);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(61, 20);
            this.lblClientes.TabIndex = 40;
            this.lblClientes.Text = "Clientes";
            // 
            // agregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 619);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnDisponible);
            this.Controls.Add(this.btnNoDisponble);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tablaComida);
            this.Controls.Add(this.dataPedido);
            this.Controls.Add(this.lblProducto);
            this.Name = "agregarPedido";
            this.Text = "agregarPedido";
            this.Load += new System.EventHandler(this.agregarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).EndInit();
            this.tablaComida.ResumeLayout(false);
            this.Pizza.ResumeLayout(false);
            this.Pizza.PerformLayout();
            this.Hamburguesa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dataPedido;
        private System.Windows.Forms.TabControl tablaComida;
        private System.Windows.Forms.TabPage Pizza;
        private System.Windows.Forms.ListBox listaPizza;
        private System.Windows.Forms.TabPage Hamburguesa;
        private System.Windows.Forms.ListBox listaHamburguesa;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button lblAgregar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TabPage tablaChivito;
        private System.Windows.Forms.Button btnNoDisponble;
        private System.Windows.Forms.Button btnDisponible;
        private System.Windows.Forms.Label lblNoDisponible;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.ListBox listaPizzaNoDisponible;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComidaRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroOrdenRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteRow;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label lblClientes;
    }
}