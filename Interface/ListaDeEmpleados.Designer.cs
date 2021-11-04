
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
            this.CiRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataEmpleados.Location = new System.Drawing.Point(79, 131);
            this.dataEmpleados.Name = "dataEmpleados";
            this.dataEmpleados.RowHeadersWidth = 51;
            this.dataEmpleados.RowTemplate.Height = 29;
            this.dataEmpleados.Size = new System.Drawing.Size(804, 245);
            this.dataEmpleados.TabIndex = 0;
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
            this.DireccionRow.HeaderText = "Doreccion";
            this.DireccionRow.MinimumWidth = 6;
            this.DireccionRow.Name = "DireccionRow";
            this.DireccionRow.Width = 125;
            // 
            // ListaDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 461);
            this.Controls.Add(this.dataEmpleados);
            this.Name = "ListaDeEmpleados";
            this.Text = "ListaDeEmpleados";
            this.Load += new System.EventHandler(this.ListaDeEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionRow;
    }
}