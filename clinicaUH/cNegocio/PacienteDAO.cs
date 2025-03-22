using clinicaUH.cLogica;
using clinicaUH.cVista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace clinicaUH.cNegocio
{
    public class PacienteDAO
    {
        public static List<clsPaciente> ObtenerPacientes()
        {
            List<clsPaciente> lista = new List<clsPaciente>();

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT *, DATEDIFF(YEAR, fecha_nacimiento, GETDATE()) AS edad FROM Pacientes", conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new clsPaciente
                    {
                        IdPaciente = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        FechaNacimiento = reader.GetDateTime(3),
                        Edad = reader.GetInt32(4),
                        Telefono = reader.GetString(5)
                    });
                }
            }
            return lista;
        }
    }
}