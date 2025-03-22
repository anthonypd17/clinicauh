using clinicaUH.cLogica;
using clinicaUH.cVista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace clinicaUH.cNegocio
{
    public class MedicoDAO
    {
        public static List<clsMedico> ObtenerMedicos()
        {
            List<clsMedico> lista = new List<clsMedico>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Medicos", conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new clsMedico
                    {
                        IdMedico = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Especialidad = reader.GetString(2)
                    });
                }
            }
            return lista;
        }
    }
}