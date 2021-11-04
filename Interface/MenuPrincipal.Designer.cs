
namespace Interface
{
    partial class MenuPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListaEmpleados = new System.Windows.Forms.Button();
            this.btnCocina = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tomar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(100, 181);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(142, 29);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar Empleado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListaEmpleados
            // 
            this.btnListaEmpleados.Location = new System.Drawing.Point(100, 270);
            this.btnListaEmpleados.Name = "btnListaEmpleados";
            this.btnListaEmpleados.Size = new System.Drawing.Size(142, 29);
            this.btnListaEmpleados.TabIndex = 3;
            this.btnListaEmpleados.Text = "Lista Empleados";
            this.btnListaEmpleados.UseVisualStyleBackColor = true;
            this.btnListaEmpleados.Click += new System.EventHandler(this.btnListaEmpleados_Click);
            // 
            // btnCocina
            // 
            this.btnCocina.Location = new System.Drawing.Point(424, 270);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(142, 29);
            this.btnCocina.TabIndex = 4;
            this.btnCocina.Text = "Cocina";
            this.btnCocina.UseVisualStyleBackColor = true;
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(424, 121);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(142, 29);
            this.btnPedidos.TabIndex = 5;
            this.btnPedidos.Text = "Lista de pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 496);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnCocina);
            this.Controls.Add(this.btnListaEmpleados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.button1);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnListaEmpleados;
        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.Button btnPedidos;
    }
}