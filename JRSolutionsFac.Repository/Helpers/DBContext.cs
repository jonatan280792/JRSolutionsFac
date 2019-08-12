﻿using System.Configuration;
using System.Data;

namespace JRSolutionsFac.Repository.Helpers
{
    public class DBContext
    {
        public static string ObtenerCadenaDbConexSQL()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(ConfigurationManager.AppSettings["ArchivoDbConex"]);
            DataRow dr = dst.Tables[0].Rows[0];
            return dr["AUTOLIFE"].ToString();
        }
    }
}
