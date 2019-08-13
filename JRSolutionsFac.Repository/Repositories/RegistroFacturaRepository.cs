using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Repository.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JRSolutionsFac.Repository.Repositories
{
    public class RegistroFacturaRepository
    {
        DataTable tblResult;
        SqlConnection con;
        // Seguridad Dll
        public DataTable Add(RegistroFacturaDto dto)
        {
            //using (con = new SqlConnection(sg.Desencriptar(DBContext.ObtenerCadenaDbConexSGL())))
            using (con = new SqlConnection(DBContext.ObtenerCadenaDbConexSQL()))
            {
                try
                {
                    tblResult = new DataTable();
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter(STORE_PROCEDURES.PRC_SET_FACTURA, con);
                        cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                        cmd.SelectCommand.Parameters.Add("@NumFac", SqlDbType.Int).Value = dto.NumFac;
                        cmd.SelectCommand.Parameters.Add("@Producto", SqlDbType.VarChar).Value = dto.Producto;
                        cmd.SelectCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = dto.Cantidad;
                        cmd.SelectCommand.Parameters.Add("@Valor", SqlDbType.Int).Value = dto.Valor;
                        cmd.Fill(tblResult);

                        cmd.Dispose();
                    }
                }
                catch (SqlException ex)
                {
                    con.Close();
                    throw new InvalidOperationException("TAG: " + ex.Message + ex.ErrorCode + ex.Data, ex.InnerException);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
                con.Close();
                return tblResult;
            }
        }
    }
}
