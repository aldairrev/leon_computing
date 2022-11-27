
using System;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using LeonComputing_BE;

namespace LeonComputing_ADO
{
    public class AuthADO
    {
        Connection con = new Connection();

        public UserBE attempt(string username, string password)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ("SELECT * FROM users WHERE username = @name AND CONVERT(NVARCHAR(MAX), password) = @password");
                command.Parameters.AddWithValue("@name", username);
                string pass_encrypt = Encrypt.HashString(password);
                Console.WriteLine(pass_encrypt);
                command.Parameters.AddWithValue("@password", pass_encrypt);

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int user_id = int.Parse(reader["id"].ToString() ?? "0");
                    string user_username = reader["username"].ToString() ?? "";
                    string user_firstname = reader["firstname"].ToString() ?? "";
                    string user_middle_name = reader["middle_name"].ToString() ?? "";
                    string user_lastname = reader["lastname"].ToString() ?? "";
                    string user_lastname_second = reader["lastname_second"].ToString() ?? "";
                    string user_birthday = reader["birthday"].ToString() ?? "";
                    string user_email = reader["email"].ToString() ?? "";

                    UserBE user = new UserBE
                    {
                        Id = int.Parse(reader["id"].ToString() ?? "0"),
                        Username = reader["username"].ToString() ?? "",
                        Firstname = reader["email"].ToString() ?? "",
                        Middle_name = reader["middle_name"].ToString() ?? "",
                        Lastname = reader["lastname"].ToString() ?? "",
                        Lastname_second = reader["lastname_second"].ToString() ?? "",
                        Birthday = DateTime.Parse(reader["birthday"].ToString() ?? ""),
                        Email = reader["lastname_second"].ToString() ?? "",
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.connClose();
            }
        }
    }
}
