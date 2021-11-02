using System;
using System.Collections.Generic;
using System.Text;
using Elevador;
namespace DominoBDD
{
    public class RestauranteBD
    {

        PedidoBD pedidobd;
        ClienteBD clientebd;
        public RestauranteBD()
        {

            pedidobd = new PedidoBD();

        }

        public bool GuardarPedido(PedidoElevador e)
        {

            return pedidobd.GuardarPedido(e);

        }

        public bool GuardarCliente(ClienteElevador c)
        {
            return clientebd.GuardarCliente(c);
        }
    }
}
