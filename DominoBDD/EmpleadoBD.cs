using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Elevador;
using MySql.Data.MySqlClient;


namespace DominoBDD
{
    public class EmpleadoBD
    {
        public bool GuardarEmpleado(EmpleadoElevador e)
        {

            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Insert into empleado(ci , rol , telefono , nombre , apellido , direccion)values(?ci , ?rol , ?telefono , ?nombre , ?apellido , ?direccion)";
                cmd.Parameters.Add("?ci", MySqlDbType.Int32).Value = e.Ci;
                cmd.Parameters.Add("?rol", MySqlDbType.Int32).Value = e.Rol;
                cmd.Parameters.Add("?telefono", MySqlDbType.Int32).Value = e.Telefono;
                cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = e.Nombre;
                cmd.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = e.Apellido;
                cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = e.Direccion;
                int resp;
                try
                {
                     resp = cmd.ExecuteNonQuery();
                }
                catch (Exception) { return false; }
                if (resp != 1) return false;
                else return true;
            }

        }

        public EmpleadoElevador Login(string nombre, int ci , int rol)
        {
            EmpleadoElevador e = null;
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT ci , rol , telefono , nombre , apellido , direccion FROM empleado WHERE nombre=@nombre and ci=@ci and rol=@rol" , ConexionBD.ObtenerConexion());
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("ci", ci);
                cmd.Parameters.AddWithValue("rol", rol);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (dt.Rows.Count == 1)
                {
                    e = new EmpleadoElevador();
                    while (reader.Read())
                    {
                        e.Ci = reader.GetInt32(0);
                        e.Rol = reader.GetInt32(1);
                        e.Telefono = reader.GetString(2);
                        e.Nombre = reader.GetString(3);
                        e.Apellido = reader.GetString(4);
                        e.Direccion = reader.GetString(5);
                    }
                }
                return e;
            }
        }
         public List<EmpleadoElevador> CargarEmpleado()
        {
            List<DataTable> lista = new List<DataTable>();
            List<EmpleadoElevador> listaEmpleados = new List<EmpleadoElevador>();
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * From empleado", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EmpleadoElevador e = new EmpleadoElevador();
                    e.Ci = Convert.ToInt32(dt.Rows[i]["ci"]);
                    e.Rol = Convert.ToInt32(dt.Rows[i]["rol"]);
                    e.Telefono = dt.Rows[i]["telefono"].ToString();
                    e.Nombre = dt.Rows[i]["nombre"].ToString();
                    e.Apellido = dt.Rows[i]["apellido"].ToString();
                    e.Direccion = dt.Rows[i]["direccion"].ToString();  
                    listaEmpleados.Add(e);
                }
            }
            return listaEmpleados;
        }

        public bool ModificarEmpleado(EmpleadoElevador e)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "Update empleado set rol=?rol, telefono=?telefono, nombre=?nombre , apellido=?apellido, direccion=?direccion where ci=?ci ;";
                cmd.Parameters.Add("?ci", MySqlDbType.Int32).Value = e.Ci;
                cmd.Parameters.Add("?rol", MySqlDbType.Int32).Value = e.Rol;
                cmd.Parameters.Add("?telefono", MySqlDbType.Int32).Value = e.Telefono;
                cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = e.Nombre;
                cmd.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = e.Apellido;
                cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = e.Direccion;
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;
                
            }
        }
        public bool EliminarEmpleado(int ci)
        {
            using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "DELETE FROM empleado where ci=?ci";
                cmd.Parameters.Add("?ci", MySqlDbType.Int32).Value = ci;
                int resp = cmd.ExecuteNonQuery();
                if (resp != 1) return false;
                else return true;
            }
        }
    }
}
