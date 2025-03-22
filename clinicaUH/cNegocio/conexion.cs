using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace clinicaUH.cNegocio
{
    public class conexion
    {
    }
}

public class Conexion
{
    private static string cadenaConexion = ConfigurationManager.ConnectionStrings["ClinicaDB"].ConnectionString;

    public static SqlConnection ObtenerConexion()
    {
        SqlConnection conexion = new SqlConnection(cadenaConexion);
        conexion.Open();
        return conexion;
    }
}
