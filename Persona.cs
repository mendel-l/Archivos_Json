using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Archivos_Json
{
    public class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int CalculateDate()
        {
            //codigo para calcular la edad

            return 0;
        }
    }
}