
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarPedido));
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
            this.listaMilanesasNoDisponible = new System.Windows.Forms.ListBox();
            this.listaMilanesasDisponible = new System.Windows.Forms.ListBox();
            this.lblNoDisponible = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.Hamburguesa = new System.Windows.Forms.TabPage();
            this.listaHamburguesasNoDisponible = new System.Windows.Forms.ListBox();
            this.listaHamburguesasDisponible = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PapasFritas = new System.Windows.Forms.TabPage();
            this.listaPapasNoDisponible = new System.Windows.Forms.ListBox();
            this.listaPapasDisponible = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bebida = new System.Windows.Forms.TabPage();
            this.listaBebidasNoDisponible = new System.Windows.Forms.ListBox();
            this.listaBebidasDisponible = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cervezas = new System.Windows.Forms.TabPage();
            this.listaCervezaNoDisponible = new System.Windows.Forms.ListBox();
            this.listaCervezasDisponible = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnDisponible = new Interface.Botones();
            this.btnNoDisponible = new Interface.Botones();
            this.btnAgregar = new Interface.Botones();
            this.btnEnviar = new Interface.Botones();
            this.btnEliminar = new Interface.Botones();
            this.btnAgregarCliente = new Interface.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).BeginInit();
            this.tablaComida.SuspendLayout();
            this.Pizza.SuspendLayout();
            this.Hamburguesa.SuspendLayout();
            this.PapasFritas.SuspendLayout();
            this.Bebida.SuspendLayout();
            this.Cervezas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPedido
            // 
            this.dataPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComidaRow,
            this.CantidadRow,
            this.DireccionRow,
            this.NumeroOrdenRow,
            this.CodigoRow,
            this.TelefonoRow,
            this.ClienteRow});
            this.dataPedido.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataPedido.Location = new System.Drawing.Point(35, 369);
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.RowHeadersWidth = 51;
            this.dataPedido.RowTemplate.Height = 29;
            this.dataPedido.Size = new System.Drawing.Size(934, 200);
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
            this.tablaComida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablaComida.Controls.Add(this.Pizza);
            this.tablaComida.Controls.Add(this.Hamburguesa);
            this.tablaComida.Controls.Add(this.PapasFritas);
            this.tablaComida.Controls.Add(this.Bebida);
            this.tablaComida.Controls.Add(this.Cervezas);
            this.tablaComida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tablaComida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tablaComida.Location = new System.Drawing.Point(31, 61);
            this.tablaComida.Name = "tablaComida";
            this.tablaComida.SelectedIndex = 0;
            this.tablaComida.Size = new System.Drawing.Size(807, 243);
            this.tablaComida.TabIndex = 27;
            this.tablaComida.SelectedIndexChanged += new System.EventHandler(this.tablaComida_SelectedIndexChanged);
            // 
            // Pizza
            // 
            this.Pizza.Controls.Add(this.listaMilanesasNoDisponible);
            this.Pizza.Controls.Add(this.listaMilanesasDisponible);
            this.Pizza.Controls.Add(this.lblNoDisponible);
            this.Pizza.Controls.Add(this.lblDisponible);
            this.Pizza.Location = new System.Drawing.Point(4, 29);
            this.Pizza.Name = "Pizza";
            this.Pizza.Padding = new System.Windows.Forms.Padding(3);
            this.Pizza.Size = new System.Drawing.Size(799, 210);
            this.Pizza.TabIndex = 1;
            this.Pizza.Text = "Milanesa";
            this.Pizza.UseVisualStyleBackColor = true;
            // 
            // listaMilanesasNoDisponible
            // 
            this.listaMilanesasNoDisponible.FormattingEnabled = true;
            this.listaMilanesasNoDisponible.ItemHeight = 20;
            this.listaMilanesasNoDisponible.Location = new System.Drawing.Point(407, 32);
            this.listaMilanesasNoDisponible.Name = "listaMilanesasNoDisponible";
            this.listaMilanesasNoDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaMilanesasNoDisponible.TabIndex = 39;
            this.listaMilanesasNoDisponible.SelectedIndexChanged += new System.EventHandler(this.listaMilanesasNoDisponible_SelectedIndexChanged);
            // 
            // listaMilanesasDisponible
            // 
            this.listaMilanesasDisponible.FormattingEnabled = true;
            this.listaMilanesasDisponible.ItemHeight = 20;
            this.listaMilanesasDisponible.Location = new System.Drawing.Point(10, 32);
            this.listaMilanesasDisponible.Name = "listaMilanesasDisponible";
            this.listaMilanesasDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaMilanesasDisponible.TabIndex = 38;
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
            // Hamburguesa
            // 
            this.Hamburguesa.Controls.Add(this.listaHamburguesasNoDisponible);
            this.Hamburguesa.Controls.Add(this.listaHamburguesasDisponible);
            this.Hamburguesa.Controls.Add(this.label1);
            this.Hamburguesa.Controls.Add(this.label2);
            this.Hamburguesa.Location = new System.Drawing.Point(4, 29);
            this.Hamburguesa.Name = "Hamburguesa";
            this.Hamburguesa.Padding = new System.Windows.Forms.Padding(3);
            this.Hamburguesa.Size = new System.Drawing.Size(799, 210);
            this.Hamburguesa.TabIndex = 2;
            this.Hamburguesa.Text = "Hamburguesa";
            this.Hamburguesa.UseVisualStyleBackColor = true;
            // 
            // listaHamburguesasNoDisponible
            // 
            this.listaHamburguesasNoDisponible.FormattingEnabled = true;
            this.listaHamburguesasNoDisponible.ItemHeight = 20;
            this.listaHamburguesasNoDisponible.Location = new System.Drawing.Point(410, 35);
            this.listaHamburguesasNoDisponible.Name = "listaHamburguesasNoDisponible";
            this.listaHamburguesasNoDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaHamburguesasNoDisponible.TabIndex = 43;
            this.listaHamburguesasNoDisponible.SelectedIndexChanged += new System.EventHandler(this.listaHamburguesasNoDisponible_SelectedIndexChanged);
            // 
            // listaHamburguesasDisponible
            // 
            this.listaHamburguesasDisponible.FormattingEnabled = true;
            this.listaHamburguesasDisponible.ItemHeight = 20;
            this.listaHamburguesasDisponible.Location = new System.Drawing.Point(13, 35);
            this.listaHamburguesasDisponible.Name = "listaHamburguesasDisponible";
            this.listaHamburguesasDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaHamburguesasDisponible.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "No disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Disponible";
            // 
            // PapasFritas
            // 
            this.PapasFritas.Controls.Add(this.listaPapasNoDisponible);
            this.PapasFritas.Controls.Add(this.listaPapasDisponible);
            this.PapasFritas.Controls.Add(this.label3);
            this.PapasFritas.Controls.Add(this.label4);
            this.PapasFritas.Location = new System.Drawing.Point(4, 29);
            this.PapasFritas.Name = "PapasFritas";
            this.PapasFritas.Size = new System.Drawing.Size(799, 210);
            this.PapasFritas.TabIndex = 3;
            this.PapasFritas.Text = "Papas Fritas";
            this.PapasFritas.UseVisualStyleBackColor = true;
            // 
            // listaPapasNoDisponible
            // 
            this.listaPapasNoDisponible.FormattingEnabled = true;
            this.listaPapasNoDisponible.ItemHeight = 20;
            this.listaPapasNoDisponible.Location = new System.Drawing.Point(410, 35);
            this.listaPapasNoDisponible.Name = "listaPapasNoDisponible";
            this.listaPapasNoDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaPapasNoDisponible.TabIndex = 43;
            this.listaPapasNoDisponible.SelectedIndexChanged += new System.EventHandler(this.listaPapasNoDisponible_SelectedIndexChanged);
            // 
            // listaPapasDisponible
            // 
            this.listaPapasDisponible.FormattingEnabled = true;
            this.listaPapasDisponible.ItemHeight = 20;
            this.listaPapasDisponible.Location = new System.Drawing.Point(13, 35);
            this.listaPapasDisponible.Name = "listaPapasDisponible";
            this.listaPapasDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaPapasDisponible.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "No disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Disponible";
            // 
            // Bebida
            // 
            this.Bebida.Controls.Add(this.listaBebidasNoDisponible);
            this.Bebida.Controls.Add(this.listaBebidasDisponible);
            this.Bebida.Controls.Add(this.label5);
            this.Bebida.Controls.Add(this.label6);
            this.Bebida.Location = new System.Drawing.Point(4, 29);
            this.Bebida.Name = "Bebida";
            this.Bebida.Size = new System.Drawing.Size(799, 210);
            this.Bebida.TabIndex = 4;
            this.Bebida.Text = "Bebidas";
            this.Bebida.UseVisualStyleBackColor = true;
            // 
            // listaBebidasNoDisponible
            // 
            this.listaBebidasNoDisponible.FormattingEnabled = true;
            this.listaBebidasNoDisponible.ItemHeight = 20;
            this.listaBebidasNoDisponible.Location = new System.Drawing.Point(410, 35);
            this.listaBebidasNoDisponible.Name = "listaBebidasNoDisponible";
            this.listaBebidasNoDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaBebidasNoDisponible.TabIndex = 47;
            this.listaBebidasNoDisponible.SelectedIndexChanged += new System.EventHandler(this.listaBebidasNoDisponible_SelectedIndexChanged);
            // 
            // listaBebidasDisponible
            // 
            this.listaBebidasDisponible.FormattingEnabled = true;
            this.listaBebidasDisponible.ItemHeight = 20;
            this.listaBebidasDisponible.Location = new System.Drawing.Point(13, 35);
            this.listaBebidasDisponible.Name = "listaBebidasDisponible";
            this.listaBebidasDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaBebidasDisponible.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "No disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Disponible";
            // 
            // Cervezas
            // 
            this.Cervezas.Controls.Add(this.listaCervezaNoDisponible);
            this.Cervezas.Controls.Add(this.listaCervezasDisponible);
            this.Cervezas.Controls.Add(this.label7);
            this.Cervezas.Controls.Add(this.label8);
            this.Cervezas.Location = new System.Drawing.Point(4, 29);
            this.Cervezas.Name = "Cervezas";
            this.Cervezas.Size = new System.Drawing.Size(799, 210);
            this.Cervezas.TabIndex = 5;
            this.Cervezas.Text = "Cervezas";
            this.Cervezas.UseVisualStyleBackColor = true;
            // 
            // listaCervezaNoDisponible
            // 
            this.listaCervezaNoDisponible.FormattingEnabled = true;
            this.listaCervezaNoDisponible.ItemHeight = 20;
            this.listaCervezaNoDisponible.Location = new System.Drawing.Point(410, 35);
            this.listaCervezaNoDisponible.Name = "listaCervezaNoDisponible";
            this.listaCervezaNoDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaCervezaNoDisponible.TabIndex = 51;
            this.listaCervezaNoDisponible.SelectedIndexChanged += new System.EventHandler(this.listaCervezaNoDisponible_SelectedIndexChanged);
            // 
            // listaCervezasDisponible
            // 
            this.listaCervezasDisponible.FormattingEnabled = true;
            this.listaCervezasDisponible.ItemHeight = 20;
            this.listaCervezasDisponible.Location = new System.Drawing.Point(13, 35);
            this.listaCervezasDisponible.Name = "listaCervezasDisponible";
            this.listaCervezasDisponible.Size = new System.Drawing.Size(375, 164);
            this.listaCervezasDisponible.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "No disponible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Disponible";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(1134, 109);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad*";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(975, 106);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 27);
            this.txtCantidad.TabIndex = 29;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Location = new System.Drawing.Point(974, 165);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 27);
            this.txtDireccion.TabIndex = 31;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(1134, 168);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 20);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Direccion*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Location = new System.Drawing.Point(974, 229);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 38;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(1134, 232);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 20);
            this.lblTelefono.TabIndex = 37;
            this.lblTelefono.Text = "Telefono*";
            // 
            // comboClientes
            // 
            this.comboClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(974, 288);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(151, 28);
            this.comboClientes.TabIndex = 39;
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(1134, 291);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(61, 20);
            this.lblClientes.TabIndex = 40;
            this.lblClientes.Text = "Clientes";
            // 
            // btnDisponible
            // 
            this.btnDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnDisponible.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnDisponible.BorderColor = System.Drawing.Color.White;
            this.btnDisponible.BorderRadius = 0;
            this.btnDisponible.BorderSize = 1;
            this.btnDisponible.FlatAppearance.BorderSize = 0;
            this.btnDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponible.ForeColor = System.Drawing.Color.White;
            this.btnDisponible.Location = new System.Drawing.Point(233, 316);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(188, 50);
            this.btnDisponible.TabIndex = 42;
            this.btnDisponible.Text = "&Disponible";
            this.btnDisponible.TextColor = System.Drawing.Color.White;
            this.btnDisponible.UseVisualStyleBackColor = false;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // btnNoDisponible
            // 
            this.btnNoDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnNoDisponible.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnNoDisponible.BorderColor = System.Drawing.Color.White;
            this.btnNoDisponible.BorderRadius = 0;
            this.btnNoDisponible.BorderSize = 1;
            this.btnNoDisponible.FlatAppearance.BorderSize = 0;
            this.btnNoDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoDisponible.ForeColor = System.Drawing.Color.White;
            this.btnNoDisponible.Location = new System.Drawing.Point(445, 316);
            this.btnNoDisponible.Name = "btnNoDisponible";
            this.btnNoDisponible.Size = new System.Drawing.Size(188, 50);
            this.btnNoDisponible.TabIndex = 43;
            this.btnNoDisponible.Text = "&No disponible";
            this.btnNoDisponible.TextColor = System.Drawing.Color.White;
            this.btnNoDisponible.UseVisualStyleBackColor = false;
            this.btnNoDisponible.Click += new System.EventHandler(this.btnNoDisponible_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(975, 375);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 50);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnEnviar.BorderColor = System.Drawing.Color.White;
            this.btnEnviar.BorderRadius = 0;
            this.btnEnviar.BorderSize = 1;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(1003, 441);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(137, 44);
            this.btnEnviar.TabIndex = 45;
            this.btnEnviar.Text = "&Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.BorderSize = 1;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1187, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 35);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCliente.BorderRadius = 0;
            this.btnAgregarCliente.BorderSize = 1;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(1204, 578);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarCliente.TabIndex = 47;
            this.btnAgregarCliente.Text = "Agregar &Cliente";
            this.btnAgregarCliente.TextColor = System.Drawing.Color.White;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.botones1_Click);
            // 
            // agregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNoDisponible);
            this.Controls.Add(this.btnDisponible);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tablaComida);
            this.Controls.Add(this.dataPedido);
            this.DoubleBuffered = true;
            this.Name = "agregarPedido";
            this.Text = "agregarPedido";
            this.Load += new System.EventHandler(this.agregarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).EndInit();
            this.tablaComida.ResumeLayout(false);
            this.Pizza.ResumeLayout(false);
            this.Pizza.PerformLayout();
            this.Hamburguesa.ResumeLayout(false);
            this.Hamburguesa.PerformLayout();
            this.PapasFritas.ResumeLayout(false);
            this.PapasFritas.PerformLayout();
            this.Bebida.ResumeLayout(false);
            this.Bebida.PerformLayout();
            this.Cervezas.ResumeLayout(false);
            this.Cervezas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataPedido;
        private System.Windows.Forms.TabControl tablaComida;
        private System.Windows.Forms.TabPage Pizza;
        private System.Windows.Forms.TabPage Hamburguesa;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNoDisponible;
        private System.Windows.Forms.Label lblDisponible;
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
        private System.Windows.Forms.ListBox listaMilanesasNoDisponible;
        private System.Windows.Forms.ListBox listaMilanesasDisponible;
        private System.Windows.Forms.ListBox listaHamburguesasNoDisponible;
        private System.Windows.Forms.ListBox listaHamburguesasDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage PapasFritas;
        private System.Windows.Forms.ListBox listaPapasNoDisponible;
        private System.Windows.Forms.ListBox listaPapasDisponible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Bebida;
        private System.Windows.Forms.ListBox listaBebidasNoDisponible;
        private System.Windows.Forms.ListBox listaBebidasDisponible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Cervezas;
        private System.Windows.Forms.ListBox listaCervezaNoDisponible;
        private System.Windows.Forms.ListBox listaCervezasDisponible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Botones btnDisponible;
        private Botones btnNoDisponible;
        private Botones btnAgregar;
        private Botones btnEnviar;
        private Botones btnEliminar;
        private Botones btnAgregarCliente;
    }
}