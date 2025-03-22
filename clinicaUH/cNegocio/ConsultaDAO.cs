using clinicaUH.cLogica;
using clinicaUH.cVista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace clinicaUH.cNegocio
{
    public class ConsultaDAO
    {
        public static List<clsConsulta> ObtenerConsultas()
        {
            List<clsConsulta> lista = new List<clsConsulta>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Consultas", conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new clsConsulta
                    {
                        IdConsulta = reader.GetInt32(0),
                        IdPaciente = reader.GetInt32(1),
                        IdMedico = reader.GetInt32(2),
                        FechaAtencion = reader.GetDateTime(3),
                        HoraAtencion = reader.GetTimeSpan(4),
                        Consultorio = reader.GetInt32(5)
                    });
                }
            }
            return lista;
        }
    }
}