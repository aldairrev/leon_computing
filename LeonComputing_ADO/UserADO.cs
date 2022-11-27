using System;
using System.Data;
using System.Data.SqlClient;

namespace LeonComputing_ADO
{
    public class UserADO
    {
        Connection con = new Connection();
        public DataTable listUsers()
        {
            DataSet dts = new DataSet();
            Connection.DataSource();
            con.connOpen();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_list_users";
            try
            {
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "users");
                return dts.Tables["users"];
            } catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                con.connClose();
            }
        }
    }
}
