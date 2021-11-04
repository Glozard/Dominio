
namespace Interface
{
    partial class ListaDePedidos
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
            this.dataPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPedidos
            // 
            this.dataPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedidos.Location = new System.Drawing.Point(36, 94);
            this.dataPedidos.Name = "dataPedidos";
            this.dataPedidos.RowHeadersWidth = 51;
            this.dataPedidos.RowTemplate.Height = 29;
            this.dataPedidos.Size = new System.Drawing.Size(705, 256);
            this.dataPedidos.TabIndex = 0;
            // 
            // ListaDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPedidos);
            this.Name = "ListaDePedidos";
            this.Text = "Lista de Pedidos";
            this.Load += new System.EventHandler(this.ListaDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPedidos;
    }
}