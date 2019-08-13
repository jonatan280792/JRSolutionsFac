using JRSolutionsFac.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Repository.Repositories
{
    public class ListadoMarcasRepository
    {
        DataTable tblResult;
        SqlConnection con;
        // Seguridad Dll
        public DataTable GetAll()
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
                        SqlDataAdapter cmd = new SqlDataAdapter(STORE_PROCEDURES.PRC_GET_MARCAS, con);
                        cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                        cmd.SelectCommand.Parameters.Add("@marca", SqlDbType.VarChar).Value = "";
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
