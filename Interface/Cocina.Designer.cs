
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
            this.components = new System.ComponentModel.Container();
            this.dataListaPedidos = new System.Windows.Forms.DataGridView();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnListaDeProductos = new System.Windows.Forms.Button();
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
            this.dataListaPedidos.Size = new System.Drawing.Size(930, 188);
            this.dataListaPedidos.TabIndex = 0;
            this.dataListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaPedidos_CellContentClick);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(33, 158);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(94, 29);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(150, 158);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(94, 29);
            this.btnTerminado.TabIndex = 2;
            this.btnTerminado.Text = "Terminado";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundos.Location = new System.Drawing.Point(571, 69);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.ReadOnly = true;
            this.txtSegundos.Size = new System.Drawing.Size(77, 39);
            this.txtSegundos.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinutos.Location = new System.Drawing.Point(488, 69);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.ReadOnly = true;
            this.txtMinutos.Size = new System.Drawing.Size(77, 39);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.Location = new System.Drawing.Point(405, 69);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.ReadOnly = true;
            this.txtHoras.Size = new System.Drawing.Size(77, 39);
            this.txtHoras.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnListaDeProductos
            // 
            this.btnListaDeProductos.Location = new System.Drawing.Point(21, 12);
            this.btnListaDeProductos.Name = "btnListaDeProductos";
            this.btnListaDeProductos.Size = new System.Drawing.Size(223, 39);
            this.btnListaDeProductos.TabIndex = 6;
            this.btnListaDeProductos.Text = "Modificar lista de productos";
            this.btnListaDeProductos.UseVisualStyleBackColor = true;
            this.btnListaDeProductos.Click += new System.EventHandler(this.btnListaDeProductos_Click);
            // 
            // Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 451);
            this.Controls.Add(this.btnListaDeProductos);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.btnTerminado);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.dataListaPedidos);
            this.Name = "Cocina";
            this.Text = "Cocina";
            this.Load += new System.EventHandler(this.Cocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaPedidos;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnTerminado;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnListaDeProductos;
    }
}