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
    public class EventADO
    {
        Connection con = new Connection();
        private string table = "events";

        public List<EventBE> getAll()
        {
            List<EventBE> events = new List<EventBE>();
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ($"SELECT * FROM {table}");

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EventBE evt = new EventBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Started_time = reader.GetDateTime(reader.GetOrdinal("started_time")),
                        Ended_time = reader.GetDateTime(reader.GetOrdinal("ended_time")),
                        Frecuency = reader.GetString(reader.GetOrdinal("frecuency")),
                        Part_day = reader["part_day"].ToString()[0],
                        Budget = reader.GetDecimal(reader.GetOrdinal("budget")),
                        Address = reader.GetString(reader.GetOrdinal("address")),
                        Postal_code = reader.GetString(reader.GetOrdinal("postal_code")),
                        Capacity = reader.GetInt32(reader.GetOrdinal("capacity")),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                    events.Add(evt);
                }
                return events;
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

        public List<EventBE> Search(string search)
        {
            List<EventBE> events = new List<EventBE>();
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ($"SELECT * FROM {table} WHERE name like CONCAT('%', @search, '%') OR address like CONCAT('%', @search, '%')");
                command.Parameters.AddWithValue("@search", search);

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EventBE evt = new EventBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Started_time = reader.GetDateTime(reader.GetOrdinal("started_time")),
                        Ended_time = reader.GetDateTime(reader.GetOrdinal("ended_time")),
                        Frecuency = reader.GetString(reader.GetOrdinal("frecuency")),
                        Part_day = reader["part_day"].ToString()[0],
                        Budget = reader.GetDecimal(reader.GetOrdinal("budget")),
                        Address = reader.GetString(reader.GetOrdinal("address")),
                        Postal_code = reader.GetString(reader.GetOrdinal("postal_code")),
                        Capacity = reader.GetInt32(reader.GetOrdinal("capacity")),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                    events.Add(evt);
                }
                return events;
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

        public EventBE FindById(int id)
        {
            EventBE evt = null;
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

                while (reader.Read())
                {
                    evt = new EventBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Started_time = reader.GetDateTime(reader.GetOrdinal("started_time")),
                        Ended_time = reader.GetDateTime(reader.GetOrdinal("ended_time")),
                        Frecuency = reader.GetString(reader.GetOrdinal("frecuency")),
                        Part_day = reader["part_day"].ToString()[0],
                        Budget = reader.GetDecimal(reader.GetOrdinal("budget")),
                        Address = reader.GetString(reader.GetOrdinal("address")),
                        Postal_code = reader.GetString(reader.GetOrdinal("postal_code")),
                        Capacity = reader.GetInt32(reader.GetOrdinal("capacity")),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                }

                return evt;
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return evt;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return evt;
            }
            finally
            {
                con.connClose();
            }
        }

        public EventBE Create(EventBE evt)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT {table} (name, started_time, ended_time, frecuency, part_day, budget, address, postal_code, capacity, created_by, updated_by) VALUES (@name, @started_time, @ended_time, @frecuency, @part_day, @budget, @address, @postal_code, @capacity, @created_by, @updated_by)";

                cmd.Parameters.AddWithValue("@name", evt.Name.ToString());
                cmd.Parameters.AddWithValue("@started_time", evt.Started_time.ToString());
                cmd.Parameters.AddWithValue("@ended_time", evt.Ended_time.ToString());
                cmd.Parameters.AddWithValue("@frecuency", evt.Frecuency.ToString());
                cmd.Parameters.AddWithValue("@budget", evt.Budget);
                cmd.Parameters.AddWithValue("@address", evt.Address);
                cmd.Parameters.AddWithValue("@postal_code", evt.Postal_code);
                cmd.Parameters.AddWithValue("@capacity", evt.Capacity);
                cmd.Parameters.AddWithValue("@part_day", evt.Part_day);
                cmd.Parameters.AddWithValue("@created_by", evt.Created_by);
                cmd.Parameters.AddWithValue("@updated_by", evt.Updated_by);

                Console.WriteLine(evt.ToString());
                int new_id = Convert.ToInt32(cmd.ExecuteScalar());

                evt.Id = new_id;
                
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

            return evt;
        }

        public EventBE Update(EventBE evt)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"UPDATE {table} SET name = @name, started_time = @started_time,ended_time = @ended_time, frecuency = @frecuency, part_day = @part_day, budget = @budget, address = @address, postal_code = @postal_code, capacity = @capacity WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", evt.Id.ToString());
                cmd.Parameters.AddWithValue("@name", evt.Name.ToString());
                cmd.Parameters.AddWithValue("@started_time", (evt.Started_time ?? DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss.fff"));
                cmd.Parameters.AddWithValue("@ended_time", (evt.Ended_time ?? DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss.fff"));
                cmd.Parameters.AddWithValue("@frecuency", evt.Frecuency.ToString());
                cmd.Parameters.AddWithValue("@part_day", evt.Part_day);
                cmd.Parameters.AddWithValue("@budget", evt.Budget);
                cmd.Parameters.AddWithValue("@address", evt.Address);
                cmd.Parameters.AddWithValue("@postal_code", evt.Postal_code);
                cmd.Parameters.AddWithValue("@capacity", evt.Capacity);
                cmd.Parameters.AddWithValue("@updated_at", evt.Updated_at.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                cmd.Parameters.AddWithValue("@updated_by", evt.Updated_by);

                cmd.ExecuteNonQuery();

                evt = FindById(evt.Id);
                return evt;
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return evt;
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

        public List<EventBE> getTenBestCapacity()
        {
            List<EventBE> events = new List<EventBE>();
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ($"SELECT TOP 10 * FROM {table} order by capacity desc");

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EventBE evt = new EventBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Started_time = reader.GetDateTime(reader.GetOrdinal("started_time")),
                        Ended_time = reader.GetDateTime(reader.GetOrdinal("ended_time")),
                        Frecuency = reader.GetString(reader.GetOrdinal("frecuency")),
                        Part_day = reader["part_day"].ToString()[0],
                        Budget = reader.GetDecimal(reader.GetOrdinal("budget")),
                        Address = reader.GetString(reader.GetOrdinal("address")),
                        Postal_code = reader.GetString(reader.GetOrdinal("postal_code")),
                        Capacity = reader.GetInt32(reader.GetOrdinal("capacity")),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                    events.Add(evt);
                }
                return events;
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
