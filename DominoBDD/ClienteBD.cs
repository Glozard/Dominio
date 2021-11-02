using System;
using System.Collections.Generic;
using System.Text;
using Elevador;
using MySql.Data.MySqlClient;

namespace DominoBDD
{
    public class ClienteBD
    {

        public bool GuardarCliente(PedidoElevador e)
        {

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Insert into cliente(ci , nombre , apellido , direccion , telefono)values(?ci , ?nombre , ?direccion , ?telefono )";
                cmd.Parameters.Add("?ci", MySqlDbType.Int32).Value = e.Codigo;
                cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = e.Direccion;
                cmd.Parameters.Add("?apellido", MySqlDbType.Int32).Value = e.Numero_orden;
                cmd.Parameters.Add("?direccion", MySqlDbType.Int32).Value = e.Codigo_producto;
                cmd.Parameters.Add("?telefono", MySqlDbType.Int32).Value = e.Cantidad;
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;

            }
        }


    }
}
