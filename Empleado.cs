using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaLINQ
{
    internal class Empleado
    {
        int IdEmpleado;
        string Nombre;
        string Cargo;
        double Salarios;
        int EmpresaId;

        public Empleado()
        {
            IdEmpleado1 = 0;
            Nombre1 = string.Empty;
            Cargo1 = string.Empty;
            Salarios1 = 0.0;
            EmpresaId1 = 0;
        }
        
        public Empleado(int id, string nombre, string cargo, double salarios, int empresaId)
        {
            IdEmpleado1 = id;
            Nombre1 = nombre;
            Cargo1 = cargo;
            Salarios1 = salarios;
            EmpresaId1 = empresaId;
        }

        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Cargo1 { get => Cargo; set => Cargo = value; }
        public double Salarios1 { get => Salarios; set => Salarios = value; }
        public int EmpresaId1 { get => EmpresaId; set => EmpresaId = value; }




        /*public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, Cargo {2} con Salario {3} y" +
                "Perteneciente a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }*/

        public string getDatosEmpleado()
        {
            return " Empleado " + Nombre + " con " + IdEmpleado + " y cargo de " +  Cargo + " con un salario de " + Salarios + " y ID de empresa de trabajo " + EmpresaId + "\r\n";
        }


    }
}
