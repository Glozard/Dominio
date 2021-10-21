using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioBD
{
    public class RestauranteBD
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server=localhost; Uid=root; Password=Arierom123; Database=chivitobd; Port=3306");

            conectar.Open();
           
            return conectar;
        }
    }
}
