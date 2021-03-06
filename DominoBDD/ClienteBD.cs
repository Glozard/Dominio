using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Elevador;
using MySql.Data.MySqlClient;

namespace DominoBDD
{
    public class ClienteBD
    {
        public bool GuardarCliente(ClienteElevador c)
        {

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Insert into cliente(ci , nombre , apellido , direccion , telefono , puntos)values(?ci , ?nombre , ?apellido, ?direccion , ?telefono ,?puntos)";
                cmd.Parameters.Add("?ci", MySqlDbType.Int32).Value = c.Ci;
                cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = c.Nombre;
                cmd.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = c.Apellido;
                cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = c.Direccion;
                cmd.Parameters.Add("?telefono", MySqlDbType.VarChar).Value = c.Telefono;
                cmd.Parameters.Add("?puntos" , MySqlDbType.VarChar).Value = 0;
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;
            }
        }
        public List<ClienteElevador> CargarClientes()
        {
            List<DataTable> lista = new List<DataTable>();
            List<ClienteElevador> listaClientes = new List<ClienteElevador>();
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * From cliente", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ClienteElevador c = new ClienteElevador();
                    c.Ci = Convert.ToInt32(dt.Rows[i]["ci"]);
                    c.Nombre = dt.Rows[i]["nombre"].ToString();
                    c.Apellido = dt.Rows[i]["apellido"].ToString();
                    c.Direccion = dt.Rows[i]["direccion"].ToString();
                    c.Telefono = dt.Rows[i]["telefono"].ToString();
                    c.Puntos = Convert.ToInt32(dt.Rows[i]["puntos"].ToString());
                    listaClientes.Add(c);
                }
            }
            return listaClientes;
        }
    }
}
