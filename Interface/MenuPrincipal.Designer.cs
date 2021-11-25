
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnRelevarPedidos = new Interface.Botones();
            this.btnAgregarCliente = new Interface.Botones();
            this.btnGestionarPersonal = new Interface.Botones();
            this.btnHistorialPedidos = new Interface.Botones();
            this.btnCocina = new Interface.Botones();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnListaDeClientes = new Interface.Botones();
            this.saveClientes = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRelevarPedidos
            // 
            this.btnRelevarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnRelevarPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnRelevarPedidos.BorderColor = System.Drawing.Color.White;
            this.btnRelevarPedidos.BorderRadius = 0;
            this.btnRelevarPedidos.BorderSize = 0;
            this.btnRelevarPedidos.FlatAppearance.BorderSize = 0;
            this.btnRelevarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelevarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnRelevarPedidos.Location = new System.Drawing.Point(387, 210);
            this.btnRelevarPedidos.Name = "btnRelevarPedidos";
            this.btnRelevarPedidos.Size = new System.Drawing.Size(188, 50);
            this.btnRelevarPedidos.TabIndex = 6;
            this.btnRelevarPedidos.Text = "&Relevar pedido";
            this.btnRelevarPedidos.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnRelevarPedidos, "Despliega el apartado de relevar pedido");
            this.btnRelevarPedidos.UseVisualStyleBackColor = false;
            this.btnRelevarPedidos.Click += new System.EventHandler(this.btnRelevarPedidos_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCliente.BorderRadius = 0;
            this.btnAgregarCliente.BorderSize = 0;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(387, 332);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(188, 50);
            this.btnAgregarCliente.TabIndex = 7;
            this.btnAgregarCliente.Text = "&Agregar Cliente";
            this.btnAgregarCliente.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnAgregarCliente, "Despliega el apartado de agregar un cliente");
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click_1);
            // 
            // btnGestionarPersonal
            // 
            this.btnGestionarPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnGestionarPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnGestionarPersonal.BorderColor = System.Drawing.Color.White;
            this.btnGestionarPersonal.BorderRadius = 0;
            this.btnGestionarPersonal.BorderSize = 0;
            this.btnGestionarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGestionarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGestionarPersonal.Location = new System.Drawing.Point(387, 447);
            this.btnGestionarPersonal.Name = "btnGestionarPersonal";
            this.btnGestionarPersonal.Size = new System.Drawing.Size(188, 50);
            this.btnGestionarPersonal.TabIndex = 8;
            this.btnGestionarPersonal.Text = "&Gestionar personal";
            this.btnGestionarPersonal.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnGestionarPersonal, "Despliega el apartado para el gestionamiento del personal");
            this.btnGestionarPersonal.UseVisualStyleBackColor = false;
            this.btnGestionarPersonal.Click += new System.EventHandler(this.botones1_Click);
            // 
            // btnHistorialPedidos
            // 
            this.btnHistorialPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnHistorialPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnHistorialPedidos.BorderColor = System.Drawing.Color.White;
            this.btnHistorialPedidos.BorderRadius = 0;
            this.btnHistorialPedidos.BorderSize = 0;
            this.btnHistorialPedidos.FlatAppearance.BorderSize = 0;
            this.btnHistorialPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPedidos.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPedidos.Location = new System.Drawing.Point(765, 332);
            this.btnHistorialPedidos.Name = "btnHistorialPedidos";
            this.btnHistorialPedidos.Size = new System.Drawing.Size(188, 50);
            this.btnHistorialPedidos.TabIndex = 9;
            this.btnHistorialPedidos.Text = "&Historial de pedidos";
            this.btnHistorialPedidos.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnHistorialPedidos, "Despliega el apartado que contiene el listado de todos los pedidos realizados");
            this.btnHistorialPedidos.UseVisualStyleBackColor = false;
            this.btnHistorialPedidos.Click += new System.EventHandler(this.btnHistorialPedidos_Click);
            // 
            // btnCocina
            // 
            this.btnCocina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnCocina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnCocina.BorderColor = System.Drawing.Color.White;
            this.btnCocina.BorderRadius = 0;
            this.btnCocina.BorderSize = 0;
            this.btnCocina.FlatAppearance.BorderSize = 0;
            this.btnCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocina.ForeColor = System.Drawing.Color.White;
            this.btnCocina.Location = new System.Drawing.Point(765, 210);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(188, 50);
            this.btnCocina.TabIndex = 10;
            this.btnCocina.Text = "&Cocina";
            this.btnCocina.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnCocina, "Despliega el apartado de realizar el pedido");
            this.btnCocina.UseVisualStyleBackColor = false;
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click_1);
            // 
            // btnListaDeClientes
            // 
            this.btnListaDeClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnListaDeClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(255)))));
            this.btnListaDeClientes.BorderColor = System.Drawing.Color.White;
            this.btnListaDeClientes.BorderRadius = 0;
            this.btnListaDeClientes.BorderSize = 0;
            this.btnListaDeClientes.FlatAppearance.BorderSize = 0;
            this.btnListaDeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDeClientes.ForeColor = System.Drawing.Color.White;
            this.btnListaDeClientes.Location = new System.Drawing.Point(765, 447);
            this.btnListaDeClientes.Name = "btnListaDeClientes";
            this.btnListaDeClientes.Size = new System.Drawing.Size(188, 50);
            this.btnListaDeClientes.TabIndex = 11;
            this.btnListaDeClientes.Text = "&Exportar lista de clientes";
            this.btnListaDeClientes.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnListaDeClientes, "Exporta en una hoja de calculo la lista de clientes");
            this.btnListaDeClientes.UseVisualStyleBackColor = false;
            this.btnListaDeClientes.Click += new System.EventHandler(this.btnListaDeClientes_Click);
            // 
            // saveClientes
            // 
            this.saveClientes.DefaultExt = "csv";
            this.saveClientes.Filter = "Archivos CSV|*.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 48;
            this.label1.Text = "Menú de administración";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaDeClientes);
            this.Controls.Add(this.btnCocina);
            this.Controls.Add(this.btnHistorialPedidos);
            this.Controls.Add(this.btnGestionarPersonal);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnRelevarPedidos);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Botones btnRelevarPedidos;
        private Botones btnAgregarCliente;
        private Botones btnHistorialPedidos;
        private Botones btnGestionarPersonal;
        private Botones btnCocina;
        private System.Windows.Forms.ToolTip toolTip1;
        private Botones btnListaDeClientes;
        private System.Windows.Forms.SaveFileDialog saveClientes;
        private System.Windows.Forms.Label label1;
    }
}