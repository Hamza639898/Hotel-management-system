using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Threading.Tasks;

namespace hotel_mangment_systeam
{
    class Connection_Class
    {
        public static SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4F9O2G1; Initial Catalog=hotel_mangement_systeam_c#; Integrated Security=true;");

            conn.Open();
            return conn;
        }
    }
}
