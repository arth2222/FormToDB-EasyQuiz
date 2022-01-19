using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FormToDB
{
    public class DBLayer
    {
        public void InsertValuesToDB(string un,string q1,string a1,string q2, string a2, string q3, string a3)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["quizConn"].ConnectionString;
            SqlParameter param;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into QA values(@un,@q1,@a1,@q2,@a2,@q3,@a3)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@un", SqlDbType.NVarChar);
                param.Value = un;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@q1", SqlDbType.NVarChar);
                param.Value = q1;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@a1", SqlDbType.NVarChar);
                param.Value = a1;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@q2", SqlDbType.NVarChar);
                param.Value = q2;//(object)wpd.Temp ?? DBNull.Value;//wpd.Temp;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@a2", SqlDbType.NVarChar);
                param.Value = a2;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@q3", SqlDbType.NVarChar);
                param.Value = q3;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@a3", SqlDbType.NVarChar);
                param.Value = a3;
                cmd.Parameters.Add(param);


                int rows = cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

    }
}