
namespace Interface
{
    partial class ListaDeEmpleados
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
            this.dataEmpleados = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCi = new System.Windows.Forms.Label();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.CiRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRol = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).BeginInit();
            this.SuspendLayout();
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
            this.dataEmpleados.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(406, 420);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(474, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 2;
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
            this.txtCi.TabIndex = 4;
            this.txtCi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.txtApellido.TabIndex = 6;
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
            this.txtDireccion.TabIndex = 10;
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
            this.txtTelefono.TabIndex = 8;
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
            this.comboRol.TabIndex = 25;
            // 
            // ListaDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 461);
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
            this.Name = "ListaDeEmpleados";
            this.Text = "ListaDeEmpleados";
            this.Load += new System.EventHandler(this.ListaDeEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmpleados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.TextBox txtCi;
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
    }
}