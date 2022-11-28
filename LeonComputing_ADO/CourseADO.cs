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
    public class CourseADO
    {
        Connection con = new Connection();
        private string table = "courses";

        public List<CourseBE> getAll()
        {
            List<CourseBE> courses = new List<CourseBE>();
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
                    CourseBE course = new CourseBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Hours_practice = reader.GetInt32(reader.GetOrdinal("hours_practice")),
                        Hours_theory = reader.GetInt32(reader.GetOrdinal("hours_theory")),
                        Level = reader.GetString(reader.GetOrdinal("level"))[0],
                        Description = reader["description"].ToString(),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                    courses.Add(course);
                }
                return courses;
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

        public List<CourseBE> Search(string search)
        {
            List<CourseBE> courses = new List<CourseBE>();
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand command = new SqlCommand();
                command.CommandText = ($"SELECT * FROM {table} WHERE name like CONCAT('%', @search, '%') OR description like CONCAT('%', @search, '%')");
                command.Parameters.AddWithValue("@search", search);

                command.Connection = Connection.connMaster;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CourseBE course = new CourseBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Hours_practice = reader.GetInt32(reader.GetOrdinal("hours_practice")),
                        Hours_theory = reader.GetInt32(reader.GetOrdinal("hours_theory")),
                        Level = reader.GetString(reader.GetOrdinal("level"))[0],
                        Description = reader["description"].ToString(),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                    courses.Add(course);
                }
                return courses;
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

        public CourseBE FindById(int id)
        {
            CourseBE course = null;
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
                    course = new CourseBE
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Hours_practice = reader.GetInt32(reader.GetOrdinal("hours_practice")),
                        Hours_theory = reader.GetInt32(reader.GetOrdinal("hours_theory")),
                        Level = reader.GetString(reader.GetOrdinal("level"))[0],
                        Description = reader["description"].ToString(),
                        Created_at = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Created_by = reader.GetInt32(reader.GetOrdinal("created_by")),
                        Updated_at = reader.GetDateTime(reader.GetOrdinal("updated_at")),
                        Updated_by = reader.GetInt32(reader.GetOrdinal("updated_by")),
                    };
                }

                return course;
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return course;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return course;
            }
            finally
            {
                con.connClose();
            }
        }

        public CourseBE Create(CourseBE course)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"INSERT {table} (name, hours_practice, hours_theory, level, description, created_by, updated_by) VALUES (@name, @hours_practice, @hours_theory, @level, @description, @created_by, @updated_by)";

                cmd.Parameters.AddWithValue("@name", course.Name);
                cmd.Parameters.AddWithValue("@hours_practice", course.Hours_practice);
                cmd.Parameters.AddWithValue("@hours_theory", course.Hours_theory);
                cmd.Parameters.AddWithValue("@level", course.Level);
                cmd.Parameters.AddWithValue("@description", course.Description);
                cmd.Parameters.AddWithValue("@created_by", course.Created_by);
                cmd.Parameters.AddWithValue("@updated_by", course.Updated_by);

                Console.WriteLine(course.ToString());
                int new_id = Convert.ToInt32(cmd.ExecuteScalar());

                course.Id = new_id;
                
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

            return course;
        }

        public CourseBE Update(CourseBE course)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"UPDATE {table} SET name = @name, hours_practice = @hours_practice, hours_theory = @hours_theory, level = @level, description = @description WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", course.Id);
                cmd.Parameters.AddWithValue("@name", course.Name);
                cmd.Parameters.AddWithValue("@hours_practice", course.Hours_practice);
                cmd.Parameters.AddWithValue("@hours_theory", course.Hours_theory);
                cmd.Parameters.AddWithValue("@level", course.Level);
                cmd.Parameters.AddWithValue("@description", course.Description);
                cmd.Parameters.AddWithValue("@updated_at", course.Updated_at.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                cmd.Parameters.AddWithValue("@updated_by", course.Updated_by);

                cmd.ExecuteNonQuery();

                course = FindById(course.Id);
                return course;
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex.Message);
                return course;
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
