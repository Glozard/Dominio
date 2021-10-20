
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
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaPedidos
            // 
            this.dataListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPedidos.Location = new System.Drawing.Point(12, 202);
            this.dataListaPedidos.Name = "dataListaPedidos";
            this.dataListaPedidos.RowHeadersWidth = 51;
            this.dataListaPedidos.RowTemplate.Height = 29;
            this.dataListaPedidos.Size = new System.Drawing.Size(940, 188);
            this.dataListaPedidos.TabIndex = 0;
            this.dataListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPedidos_CellContentClick);
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 451);
            this.Controls.Add(this.dataListaPedidos);
            this.Name = "Cocina";
            this.Text = "Cocina";
            this.Load += new System.EventHandler(this.Cocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaPedidos;
    }
}