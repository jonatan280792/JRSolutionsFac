using JRSolutionsFac.Repository.Helpers;
using JRSolutionsFac.Repository.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace JRSolutionsFac.Repository.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        DataTable tblResult;
        SqlConnection con;
        // Seguridad Dll
        public DataTable Find(string UserName, string PassWord)
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
                        SqlDataAdapter cmd = new SqlDataAdapter(STORE_PROCEDURES.PRC_GET_USERS, con);
                        cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                        cmd.SelectCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;
                        cmd.SelectCommand.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = PassWord;                        
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
                    con.Close();
                    throw new Exception();
                }
                return tblResult;
            }
        }
    }
}
