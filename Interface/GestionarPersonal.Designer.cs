
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPersonal));
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
            this.dataEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Interface.Botones();
            this.btnModificar = new Interface.Botones();
            this.btnAgregar = new Interface.Botones();
            this.btnRefresh = new Interface.Botones();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CiRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCi.Location = new System.Drawing.Point(339, 116);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(28, 20);
            this.lblCi.TabIndex = 5;
            this.lblCi.Text = "Ci*";
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(381, 116);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(134, 27);
            this.txtCi.TabIndex = 0;
            this.txtCi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(672, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(572, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre*";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(816, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 20);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido*";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(916, 116);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(816, 158);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 20);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Dirección*";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(916, 158);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 27);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefono.Location = new System.Drawing.Point(572, 112);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 20);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(672, 112);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Location = new System.Drawing.Point(330, 158);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(37, 20);
            this.lblRol.TabIndex = 13;
            this.lblRol.Text = "Rol*";
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
            this.comboRol.Location = new System.Drawing.Point(381, 158);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(134, 28);
            this.comboRol.TabIndex = 1;
            // 
            // dataEmpleados
            // 
            this.dataEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CiRow,
            this.RolRow,
            this.TelefonoRows,
            this.NombreRow,
            this.ApellidoRow,
            this.DireccionRow});
            this.dataEmpleados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataEmpleados.Location = new System.Drawing.Point(294, 240);
            this.dataEmpleados.Name = "dataEmpleados";
            this.dataEmpleados.RowHeadersWidth = 51;
            this.dataEmpleados.RowTemplate.Height = 29;
            this.dataEmpleados.Size = new System.Drawing.Size(804, 245);
            this.dataEmpleados.TabIndex = 9;
            this.dataEmpleados.TabStop = false;
            this.dataEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmpleados_CellContentClick);
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
            this.btnEliminar.Location = new System.Drawing.Point(817, 539);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 50);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnEliminar, "Elimina el empleado seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnModificar.BorderColor = System.Drawing.Color.White;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.BorderSize = 1;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(604, 539);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(188, 50);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnModificar, "Modificas el empleado seleccionado");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.BorderRadius = 1;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(391, 539);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 50);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agrega un empleado nuevo a la base de datos");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.BorderSize = 1;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(232, 135);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 30);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresca y limpia todos los campos selccionados");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1106, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Gestión de persoanl";
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
            this.TelefonoRows.HeaderText = "Teléfono";
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
            this.DireccionRow.HeaderText = "Dirección";
            this.DireccionRow.MinimumWidth = 6;
            this.DireccionRow.Name = "DireccionRow";
            this.DireccionRow.Width = 125;
            // 
            // GestionarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
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
            this.Controls.Add(this.dataEmpleados);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox comboRol;
        private Botones btnEliminar;
        private Botones btnModificar;
        private Botones btnAgregar;
        private Botones btnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionRow;
    }
}