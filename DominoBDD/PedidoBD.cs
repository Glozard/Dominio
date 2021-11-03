using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Elevador;
using MySql.Data.MySqlClient;

namespace DominoBDD
{
   public class PedidoBD
    {
        public bool GuardarPedido(PedidoElevador e)
        {

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Insert into pedido(codigo , direccion , numero_orden , codigo_producto , cantidad , fecha , telefono_cliente)values(?codigo , ?direccion , ?numero_orden , ?codigo_producto , ?cantidad ,?fecha, ?telefono_cliente)";
                cmd.Parameters.Add("?codigo", MySqlDbType.Int32).Value = e.Codigo;
                cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = e.Direccion;
                cmd.Parameters.Add("?numero_orden", MySqlDbType.Int32).Value = e.Numero_orden;
                cmd.Parameters.Add("?codigo_producto", MySqlDbType.Int32).Value = e.Codigo_producto;
                cmd.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = e.Cantidad;
                cmd.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("?telefono_cliente", MySqlDbType.Int32).Value = e.Telefono;
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;

            }

        }

        public List<PedidoElevador> CargarPedidos()
        {
            List<PedidoElevador> lista = new List<PedidoElevador>();
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT * From pedido";
               
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Connection = conexion;
                MySqlDataReader reader = cmd.ExecuteReader();
                PedidoElevador pedido = new PedidoElevador();


                while (reader.Read()== true)
                {
                    pedido.Codigo = reader.GetInt32(0);
                    pedido.Direccion = reader.GetString(1);
                    pedido.Numero_orden = reader.GetInt32(2);
                    pedido.Codigo_producto = reader.GetInt32(3);
                    pedido.Cantidad = reader.GetInt32(4);
                    pedido.Telefono = reader.GetInt32(6);

                    lista.Add(pedido);
                }
                
            }
            return lista;

        }
       

    }
}
