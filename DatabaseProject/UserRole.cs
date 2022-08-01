using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    internal class UserRole
    {
        public static string StaticConnectionString = "Data Source=DESKTOP-BQ2IPJO;Initial Catalog=temp;Integrated Security=True";
        public static int GetUserRole(int userId)
        {

            string ConnectionString = StaticConnectionString;
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new
                SqlCommand("select  role_id  FROM users where id =" + userId + "", cn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int roleID = Convert.ToInt32(dt.Rows[0][0]);
            return roleID;
        }
       
    }
}
