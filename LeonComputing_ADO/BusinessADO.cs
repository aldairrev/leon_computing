using LeonComputing_BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_ADO
{
    public class BusinessADO
    {
        Connection con = new Connection();
        private string table = "businesses";

        public List<BusinessBE> getAll()
        {
            List<BusinessBE> businesses = new List<BusinessBE>();
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ("SELECT * FROM " + table);

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BusinessBE business = new BusinessBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader["name"].ToString() ?? "",
                        Url = reader["url"].ToString() ?? "",
                        Type_id = reader["type_id"].ToString() ?? "",
                        Code_id = reader["code_id"].ToString() ?? "",
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                        Ubigeo_code = reader["ubigeo_code"].ToString() ?? "",
                        Address = reader["address"].ToString() ?? "",
                        Phone = reader["phone"].ToString() ?? "",
                        Email = reader["email"].ToString() ?? "",
                    };
                    businesses.Add(business);
                }
                return businesses;
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

        public List<BusinessBE> Search(string search)
        {
            List<BusinessBE> businesses = new List<BusinessBE>();
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ($"SELECT * FROM {table} WHERE name like CONCAT('%', @search, '%') OR url like CONCAT('%', @search, '%') OR type_id like CONCAT('%', @search, '%') OR address like CONCAT('%', @search, '%') OR phone like CONCAT('%', @search, '%') OR email like CONCAT('%', @search, '%')");
                command.Parameters.AddWithValue("@search", search);

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BusinessBE business = new BusinessBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader["name"].ToString() ?? "",
                        Url = reader["url"].ToString() ?? "",
                        Type_id = reader["type_id"].ToString() ?? "",
                        Code_id = reader["code_id"].ToString() ?? "",
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                        Ubigeo_code = reader["ubigeo_code"].ToString() ?? "",
                        Address = reader["address"].ToString() ?? "",
                        Phone = reader["phone"].ToString() ?? "",
                        Email = reader["email"].ToString() ?? "",
                    };
                    businesses.Add(business);
                }
                return businesses;
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

        public BusinessBE FindById(int id)
        {
            BusinessBE business = null;
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM " + table + " WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                // int ordId = reader.GetOrdinal("id");
                // int ordName = reader.GetOrdinal("name");
                // int ordUrl = reader.GetOrdinal("url");
                // int ordType_id = reader.GetOrdinal("type_id");
                // int ordCode_id = reader.GetOrdinal("code_id");
                // int ordCreated_at = reader.GetOrdinal("created_at");
                // int ordCreated_by = reader.GetOrdinal("created_by");
                // int ordUpdated_at = reader.GetOrdinal("updated_at");
                // int ordUpdated_by = reader.GetOrdinal("updated_by");
                // int ordUbigeo_code = reader.GetOrdinal("ubigeo_code");
                // int ordAddress = reader.GetOrdinal("address");
                // int ordPhone = reader.GetOrdinal("phone");
                // int ordEmail = reader.GetOrdinal("email");

                while (reader.Read())
                {
                    business = new BusinessBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader["name"].ToString() ?? "",
                        Url = reader["url"].ToString() ?? "",
                        Type_id = reader["type_id"].ToString() ?? "",
                        Code_id = reader["code_id"].ToString() ?? "",
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                        Ubigeo_code = reader["ubigeo_code"].ToString() ?? "",
                        Address = reader["address"].ToString() ?? "",
                        Phone = reader["phone"].ToString() ?? "",
                        Email = reader["email"].ToString() ?? "",
                    };
                }

                reader.Close();

                return business;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return business;
            }
            finally
            {
                con.connClose();
            }
        }

        public BusinessBE Create(BusinessBE business)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT " + table + " (name, url, type_id, code_id, created_by, updated_by, ubigeo_code, address, phone, email) VALUES (@name, @url, @type_id, @code_id, @created_by, @updated_by, @ubigeo_code, @address, @phone, @email)";
                cmd.Parameters.AddWithValue("@name", business.Name ?? "");
                cmd.Parameters.AddWithValue("@url", business.Url ?? "");
                cmd.Parameters.AddWithValue("@type_id", business.Type_id);
                cmd.Parameters.AddWithValue("@code_id", business.Code_id);
                cmd.Parameters.AddWithValue("@created_by", business.Created_by);
                cmd.Parameters.AddWithValue("@updated_by", business.Updated_by);
                cmd.Parameters.AddWithValue("@ubigeo_code", business.Ubigeo_code);
                cmd.Parameters.AddWithValue("@address", business.Address);
                cmd.Parameters.AddWithValue("@phone", business.Phone);
                cmd.Parameters.AddWithValue("@email", business.Email);
                Console.WriteLine(business.ToString());
                int new_id = Convert.ToInt32(cmd.ExecuteScalar());

                business.Id = new_id;
                
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

            return business;
        }

        public BusinessBE Update(BusinessBE business)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"UPDATE {table} SET name = @name, url = @url, type_id = @type_id, code_id = @code_id, updated_by = @updated_by, updated_at = @updated_at, ubigeo_code = @ubigeo_code, address = @address, phone = @phone, email = @email WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", business.Id);
                cmd.Parameters.AddWithValue("@name", business.Name);
                cmd.Parameters.AddWithValue("@url", business.Url);
                cmd.Parameters.AddWithValue("@type_id", business.Type_id);
                cmd.Parameters.AddWithValue("@code_id", business.Code_id);
                cmd.Parameters.AddWithValue("@updated_by", business.Updated_by);
                cmd.Parameters.AddWithValue("@updated_at", business.Updated_at.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                cmd.Parameters.AddWithValue("@ubigeo_code", business.Ubigeo_code);
                cmd.Parameters.AddWithValue("@address", business.Address);
                cmd.Parameters.AddWithValue("@phone", business.Phone);
                cmd.Parameters.AddWithValue("@email", business.Email);

                cmd.ExecuteNonQuery();

                business = FindById(business.Id);
                return business;
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

        public bool Delete(int id)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM {table} WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                con.connClose();
            }
        }
    }
}
