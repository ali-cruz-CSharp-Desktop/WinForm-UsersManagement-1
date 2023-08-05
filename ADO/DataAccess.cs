using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace UsersManagement.ADO
{
    public class DataAccess
    {
        public static string defaultConn = ConfigurationManager.ConnectionStrings["sql1"].ConnectionString;

        public static Response InsertaToDB(
                            string nombreProcedimiento,
                            List<SqlParametro> parametros,
                            string connString = "")
        {
            Response response = new Response();
            response.Message = "";

            using (SqlConnection conn = new SqlConnection(string.IsNullOrEmpty(connString) ? defaultConn : connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(nombreProcedimiento, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (parametros != null)
                        {
                            foreach (var param in parametros)
                            {
                                if (param.Salida)
                                {
                                    cmd.Parameters.AddWithValue(param.Nombre, param.Valor);
                                } else
                                {
                                    cmd.Parameters.Add(param.Nombre, System.Data.SqlDbType.NVarChar, 100).Direction = 
                                        System.Data.ParameterDirection.Output;
                                }
                            }
                        }

                        int e = cmd.ExecuteNonQuery();

                        for (int i = 0; i < parametros.Count; i++)
                        {
                            if (cmd.Parameters[i].Direction == System.Data.ParameterDirection.Output)
                            {
                                string mensaje = cmd.Parameters[i].Value.ToString();

                                if (string.IsNullOrEmpty(mensaje))
                                {
                                    response.Message = mensaje;
                                }
                            }
                        }

                        response.Exito = e > 0 ? true : false;
                        response.Message = e > 0 ? "Found Data" : "Not Found Data";
                    }
                } catch (Exception ex)
                {
                    response.Exito = false;
                    response.Message = ex.Message;
                }

                return response;
            }
        }



    }
}
