using Elevador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevador;

namespace DominioBD
{
    public class PedidoBD
    {

        public PedidoBD() { }

        public int AgregarPedido(PedidoElevador pedido)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into pedido ( comida,  cantidad,  estado,  numero_orden,  codigo,  codigo_producto, direccion) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", pedido.Comida, pedido.Cantidad, pedido.Estado, pedido.Numero_orden, pedido.Codigo, pedido.Codigo_producto, pedido.Direccion), ConexionBD.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;

        }



    }
}
