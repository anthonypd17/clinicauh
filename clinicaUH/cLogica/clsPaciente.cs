﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clinicaUH.cLogica
{
    public class clsPaciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
    }
}