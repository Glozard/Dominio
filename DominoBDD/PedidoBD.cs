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
            MySqlCommand cmd = new MySqlCommand();
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                
                cmd.Connection = conexion;
                cmd.CommandText = "Insert into pedido(codigo , direccion , numero_orden , codigo_producto , cantidad , fecha , telefono_cliente , comida , cliente)values(null , ?direccion , ?numero_orden , ?codigo_producto , ?cantidad ,?fecha, ?telefono_cliente , ?comida , ?cliente)";
                //codigo toma el valor desde el last
                cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = e.Direccion;
                cmd.Parameters.Add("?numero_orden", MySqlDbType.Int32).Value = e.Numero_orden;
                cmd.Parameters.Add("?codigo_producto", MySqlDbType.Int32).Value = e.Codigo_producto;
                cmd.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = e.Cantidad;
                cmd.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("?telefono_cliente", MySqlDbType.Int32).Value = e.Telefono;
                cmd.Parameters.Add("?comida", MySqlDbType.VarChar).Value = e.Comida;
                cmd.Parameters.Add("?cliente", MySqlDbType.VarChar).Value = e.Cliente;
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else
                {
                    int last = Convert.ToInt32(cmd.LastInsertedId);
                    e.Codigo = last;
                    return true;
                }
            }
        }
        public DataTable CargarPedidos()
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * From pedido", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
