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
                        cmd.SelectCommand.Parameters.Add("@nit", SqlDbType.VarChar).Value = dto.nit;
                        cmd.SelectCommand.Parameters.Add("@numfac", SqlDbType.Int).Value = dto.numfac;
                        cmd.SelectCommand.Parameters.Add("@detalle", SqlDbType.VarChar).Value = dto.detalle;
                        cmd.SelectCommand.Parameters.Add("@caja", SqlDbType.VarChar).Value = dto.cajero;
                        cmd.SelectCommand.Parameters.Add("@tipodoc", SqlDbType.VarChar).Value = dto.tipo_doc;
                        cmd.SelectCommand.Parameters.Add("@docclie", SqlDbType.VarChar).Value = dto.numero_doc;
                        cmd.SelectCommand.Parameters.Add("@nomcli", SqlDbType.VarChar).Value = dto.nom_client;
                        cmd.SelectCommand.Parameters.Add("@placa", SqlDbType.VarChar).Value = dto.placa;
                        cmd.SelectCommand.Parameters.Add("@marca", SqlDbType.VarChar).Value = dto.marca;
                        cmd.SelectCommand.Parameters.Add("@modelo", SqlDbType.Int).Value = dto.modelo;
                        cmd.SelectCommand.Parameters.Add("@tipo", SqlDbType.VarChar).Value = dto.tipo;
                        cmd.SelectCommand.Parameters.Add("@mecanica", SqlDbType.VarChar).Value = dto.mecanica;
                        cmd.SelectCommand.Parameters.Add("@latoneria", SqlDbType.VarChar).Value = dto.latoneria;
                        cmd.SelectCommand.Parameters.Add("@pintura", SqlDbType.VarChar).Value = dto.pintura;
                        cmd.SelectCommand.Parameters.Add("@total", SqlDbType.Int).Value = dto.total;
                        cmd.SelectCommand.Parameters.Add("@valrecibido", SqlDbType.Int).Value = dto.valorrecibido;
                        cmd.SelectCommand.Parameters.Add("@cambio", SqlDbType.Int).Value = dto.cambio;
                        cmd.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dto.fecha;
                        cmd.SelectCommand.Parameters.Add("@fechaentrega", SqlDbType.DateTime).Value = dto.fechaentrega;

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
