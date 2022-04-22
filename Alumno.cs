using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Archivos_Json
{
    public class Alumno : Persona
    {
        public string NoCarne { get; set; }
        public List<int> Notas { get; set; }
    }
}