﻿using DominioElChivito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class MenuPrincipal : Form
    {
        Restaurante restaurante;
       
        public MenuPrincipal(Restaurante unRestaurante)
        {
            this.restaurante = unRestaurante;
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRelevarPedidos_Click(object sender, EventArgs e)
        {
            agregarPedido pedido = new agregarPedido(restaurante, 1);
            pedido.Show();
        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            AgregarCliente cliente = new AgregarCliente(restaurante);
            cliente.Show();
        }

        private void botones1_Click(object sender, EventArgs e)
        {
            GestionarPersonal empleados = new GestionarPersonal(restaurante);
            empleados.Show();
        }

        private void btnHistorialPedidos_Click(object sender, EventArgs e)
        {
            ListaDePedidos pedidos = new ListaDePedidos(restaurante);
            pedidos.Show();
        }

        private void btnCocina_Click_1(object sender, EventArgs e)
        {
            Cocina cocina = new Cocina(restaurante);
            cocina.Show();
        }
    }
}
