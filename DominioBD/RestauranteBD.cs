using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevador;


namespace DominioBD
{
   
    public class RestauranteBD
    {
        PedidoBD pedidobd;

        public RestauranteBD()
        {
            pedidobd = new PedidoBD();
        }

        public bool GuardarPedido(PedidoElevador p)
        {
            return pedidobd.AgregarPedido(p);

        }
    }
}
