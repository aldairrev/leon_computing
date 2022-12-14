using LeonComputing_BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_ADO
{
    public class UbigeoADO
    {
        Connection con = new Connection();
        Boolean blnexito = false;

        public DataTable Ubigeo_Departamentos()
        {
            DataSet dts = new DataSet();
            try
            {
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_Departamentos";
                cmd.Parameters.Clear();
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Departamentos");
                return dts.Tables["Departamentos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            DataSet dts = new DataSet();
            try
            {
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_ProvinciasDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            DataSet dts = new DataSet();
            try
            {
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_DistritosProvinciaDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                cmd.Parameters.AddWithValue("@IdProvincia", strIdProvincia);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distritos");
                return dts.Tables["Distritos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable getUbigeoById(string id)
        {
            DataSet dts = new DataSet();
            try
            {
                con.connOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection.connMaster;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ($"SELECT * FROM {"ubigeo"} WHERE id = @id");
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Connection = Connection.connMaster;
                SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ubigeo");
                return dts.Tables["ubigeo"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
