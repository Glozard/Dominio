using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominoBDD
{
    public class ConexionBD
    { 
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;port=3306;username=root;password=Arierom123;database=chivitobd;");
            conectar.Open();
            return conectar;
        }

    }
}
