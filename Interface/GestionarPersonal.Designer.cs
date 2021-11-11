
namespace Interface
{
    partial class GestionarPersonal
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
            this.lblCi = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataEmpleados = new System.Windows.Forms.DataGridView();
            this.CiRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.botones1 = new Interface.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Location = new System.Drawing.Point(96, 34);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(22, 20);
            this.lblCi.TabIndex = 5;
            this.lblCi.Text = "Ci";
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(138, 34);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(125, 27);
            this.txtCi.TabIndex = 0;
            this.txtCi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(474, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(374, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(618, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(718, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(618, 73);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(718, 73);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 27);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(374, 27);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(474, 27);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(87, 76);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 20);
            this.lblRol.TabIndex = 13;
            this.lblRol.Text = "Rol";
            // 
            // comboRol
            // 
            this.comboRol.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Recepcionista",
            "Cocinero"});
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Administrador",
            "Rececpcionista",
            "Cocinero"});
            this.comboRol.Location = new System.Drawing.Point(138, 76);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(134, 28);
            this.comboRol.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(527, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(285, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 29);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataEmpleados
            // 
            this.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CiRow,
            this.RolRow,
            this.TelefonoRows,
            this.NombreRow,
            this.ApellidoRow,
            this.DireccionRow});
            this.dataEmpleados.Location = new System.Drawing.Point(79, 149);
            this.dataEmpleados.Name = "dataEmpleados";
            this.dataEmpleados.RowHeadersWidth = 51;
            this.dataEmpleados.RowTemplate.Height = 29;
            this.dataEmpleados.Size = new System.Drawing.Size(804, 245);
            this.dataEmpleados.TabIndex = 9;
            this.dataEmpleados.TabStop = false;
            this.dataEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmpleados_CellContentClick);
            // 
            // CiRow
            // 
            this.CiRow.HeaderText = "Ci";
            this.CiRow.MinimumWidth = 6;
            this.CiRow.Name = "CiRow";
            this.CiRow.Width = 125;
            // 
            // RolRow
            // 
            this.RolRow.HeaderText = "Rol";
            this.RolRow.MinimumWidth = 6;
            this.RolRow.Name = "RolRow";
            this.RolRow.Width = 125;
            // 
            // TelefonoRows
            // 
            this.TelefonoRows.HeaderText = "Telefono";
            this.TelefonoRows.MinimumWidth = 6;
            this.TelefonoRows.Name = "TelefonoRows";
            this.TelefonoRows.Width = 125;
            // 
            // NombreRow
            // 
            this.NombreRow.HeaderText = "Nombre";
            this.NombreRow.MinimumWidth = 6;
            this.NombreRow.Name = "NombreRow";
            this.NombreRow.Width = 125;
            // 
            // ApellidoRow
            // 
            this.ApellidoRow.HeaderText = "Apellido";
            this.ApellidoRow.MinimumWidth = 6;
            this.ApellidoRow.Name = "ApellidoRow";
            this.ApellidoRow.Width = 125;
            // 
            // DireccionRow
            // 
            this.DireccionRow.HeaderText = "Direccion";
            this.DireccionRow.MinimumWidth = 6;
            this.DireccionRow.Name = "DireccionRow";
            this.DireccionRow.Width = 125;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(406, 420);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // botones1
            // 
            this.botones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.botones1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.botones1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones1.BorderRadius = 0;
            this.botones1.BorderSize = 0;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.ForeColor = System.Drawing.Color.White;
            this.botones1.Location = new System.Drawing.Point(630, 457);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(188, 50);
            this.botones1.TabIndex = 29;
            this.botones1.Text = "Eliminar";
            this.botones1.TextColor = System.Drawing.Color.White;
            this.botones1.UseVisualStyleBackColor = false;
            // 
            // GestionarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 519);
            this.Controls.Add(this.botones1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblCi);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataEmpleados);
            this.Name = "GestionarPersonal";
            this.Text = "Gestion de personal";
            this.Load += new System.EventHandler(this.ListaDeEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmpleados;      
        
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionRow;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRefresh;
        private Botones botones1;
    }
}