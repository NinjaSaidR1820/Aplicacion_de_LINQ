using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaLINQ
{
    internal class DatosConsulta
    {
        string nombrePers;
        string nombreTrab;

        public DatosConsulta(string nombrePers, string nombreTrab)
        {
            this.nombrePers = nombrePers;
            this.nombreTrab = nombreTrab;
        }

        public string NombrePers { get => nombrePers; set => nombrePers = value; }
        public string NombreTrab { get => nombreTrab; set => nombreTrab = value; }

        public string getDatosCosulta()
        {
            return " Empleado " + NombrePers + " que trabaja en " + NombreTrab +  "\r\n";
        }
    }
}
