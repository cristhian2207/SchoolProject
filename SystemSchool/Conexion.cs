using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSchool
{
    class Conexion
    {
        public static SqlConnection Conexiones()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-0K1HBTK;DATABASE=SchoolDB;Integrated Security = True");
            cn.Open();
            return cn;
        }

        public static SqlConnection cerrarConexion()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-0K1HBTK;DATABASE=SchoolDB;Integrated Security = True");
            cn.Close();
            return cn;
        }
    }
}
