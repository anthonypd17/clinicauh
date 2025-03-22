using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clinicaUH.cLogica
{
    public class clsConsulta
    {
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaAtencion { get; set; }
        public TimeSpan HoraAtencion { get; set; }
        public int Consultorio { get; set; }
    }
}