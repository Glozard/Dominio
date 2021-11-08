using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DominoBDD
{
    public class ProductoBD
    {
        public DataTable CargarProductos()
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * From producto", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        
        public int CargarCodigo(string tipo_comida)
        {
            int codigo = -1;
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                
                cmd.CommandText = "Select codigo From producto where tipo_comida=?tipo_comida;";
                cmd.Parameters.Add("?tipo_comida", MySqlDbType.VarChar).Value = tipo_comida;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
                    codigo = reader.GetInt32(0);
                }
                return codigo;
            }
            
        }
        public bool ModificarEstadoProducto(string tipo_comida)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Update producto set estado=?estado where tipo_comida=?tipo_comida ;";
                cmd.Parameters.Add("?tipo_comida", MySqlDbType.VarChar).Value = tipo_comida;
                cmd.Parameters.Add("?estado", MySqlDbType.VarChar).Value = "no hay";
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;
            }
        }
        public bool ModificarEstadoProductoDisponible(string tipo_comida)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Update producto set estado=?estado where tipo_comida=?tipo_comida ;";
                cmd.Parameters.Add("?tipo_comida", MySqlDbType.VarChar).Value = tipo_comida;
                cmd.Parameters.Add("?estado", MySqlDbType.VarChar).Value = "hay";
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;
            }
        }

    }
}
