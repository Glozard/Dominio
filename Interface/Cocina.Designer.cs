
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
            this.dataListaPedidos = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaPedidos
            // 
            this.dataListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comida,
            this.Cantidad});
            this.dataListaPedidos.Location = new System.Drawing.Point(55, 121);
            this.dataListaPedidos.Name = "dataListaPedidos";
            this.dataListaPedidos.RowHeadersWidth = 51;
            this.dataListaPedidos.RowTemplate.Height = 29;
            this.dataListaPedidos.Size = new System.Drawing.Size(412, 188);
            this.dataListaPedidos.TabIndex = 0;
            this.dataListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPedidos_CellContentClick);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Comida
            // 
            this.Comida.HeaderText = "Comida";
            this.Comida.MinimumWidth = 6;
            this.Comida.Name = "Comida";
            this.Comida.ReadOnly = true;
            this.Comida.Width = 125;
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataListaPedidos);
            this.Name = "Cocina";
            this.Text = "Cocina";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}