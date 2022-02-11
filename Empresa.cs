using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaLINQ
{
    internal class Empresa
    {
        int IdEmpresa;
        string NombreEmpresa;

        public Empresa()
        {
            IdEmpresa1 = 0;
            NombreEmpresa1 = string.Empty;
        }

        public Empresa(int id, string nombre)
        {
            IdEmpresa1 = id;
            NombreEmpresa1 = nombre;
        }

        public int IdEmpresa1 { get => IdEmpresa; set => IdEmpresa = value; }
        public string NombreEmpresa1 { get => NombreEmpresa; set => NombreEmpresa = value; }

        public string getDatosEmpresa()
        {
            return "Empresa " + NombreEmpresa + " con " + IdEmpresa + "\r\n";
        }
    }
}
