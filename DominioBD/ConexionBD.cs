using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioBD
{
    public class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server=localhost; Port=3306; Uid=root; Password=Arierom123; Database=chivitobd;");

            conectar.Open();

            return conectar;
        }

    }
}
