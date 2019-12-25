using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomSystems.Class
{
    class ClassConnection
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConStr);
            conn.Open();
            return conn;
        }
    }
}
