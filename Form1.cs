using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using Microsoft.VisualBasic;*/

namespace AplicaLINQ
{
    public partial class Form1 : Form
    { 
        List<Empresa> listaEmpresas = new List<Empresa>();
        List<Empleado> listaEmpleados = new List<Empleado>();

        Empleado empleado;
        Empresa empresa;
        DatosConsulta consulta;
        public Form1()
        {
            InitializeComponent();
          

           /*dgEmpresas.Columns.Add("ID", "ID");
           dgEmpresas.Columns.Add("NOMBRE", "NOMBRE");


            dgEmpresas.ReadOnly = true;
            dgEmpresas.AllowUserToAddRows = false;
            dgEmpresas.AllowUserToDeleteRows = false;
            dgEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/

            /*dgEmpleados.Columns.Add("ID", "ID");
            dgEmpleados.Columns.Add("NOMBRE", "NOMBRE");
            dgEmpleados.Columns.Add("CARGO", "CARGO");
            dgEmpleados.Columns.Add("SALARIO", "SALARIO");
            dgEmpleados.Columns.Add("ID_EMPRESA", "ID_EMPRESA");


            dgEmpleados.ReadOnly = true;
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.AllowUserToDeleteRows = false;
            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
        }

        private void btnIngresarEmpresa_Click(object sender, EventArgs e)
        {
            guardarEmpresa();
        }

        public void guardarEmpresa()
        {
            empresa = new Empresa(int.Parse(txtIDEmpresa.Text), txtNombreEmpresa.Text);

            listaEmpresas.Add(empresa);

            dgEmpresas.DataSource = null;
            dgEmpresas.DataSource = listaEmpresas;
        }

        private void btnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            guardarEmpleado();
        }

        public void guardarEmpleado()
        {
            empleado = new Empleado(int.Parse(txtIDEmpleado.Text), txtNombrEmpleado.Text, txtCargo.Text, double.Parse(txtSalario.Text), int.Parse(txtIDempresEmpleado.Text));


            listaEmpleados.Add(empleado);

            dgEmpleados.DataSource = null;
            dgEmpleados.DataSource = listaEmpleados;
        }

        /*public void getEmpleadoOredenado()
        {
            IEnumerable<Empleado> nomEmp = from nEmp in listaEmpleados orderby nEmp.Nombre descending select nEmp;

            foreach (Empleado em in nomEmp)
            {
                em.getDatosEmpleado();
            }
        }*/

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getEmpleado();
        }

        public void getEmpleado()
        {
            IEnumerable<Empleado> nomEmp = from nEmp in listaEmpleados select nEmp;

            foreach (Empleado em in nomEmp)
            {
                txtCONSULTA.AppendText(em.getDatosEmpleado());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getEmpleadoCargo("ANALISTA");
        }

        public void getEmpleadoCargo(string cargo)
        {
            /*IEnumerable<Empleado> nomEmp = from nEmp in listaEmpleados
                                           join empresa in listaEmpresas on nEmp.EmpresaId1 equals empresa.IdEmpresa1
                                           where empleado.Cargo1 == cargo
                                           select nEmp;*/

            IEnumerable<Empleado> nomEmp = from nEmp in listaEmpleados where empleado.Cargo1 == cargo select nEmp;

            foreach (Empleado em in nomEmp)
            {
                txtCONSULTA.AppendText(em.getDatosEmpleado());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getEmpleadoOredenado();
        }

        public void getEmpleadoOredenado()
        {
            IEnumerable<Empleado> nomEmp = from nEmp in listaEmpleados orderby nEmp.Nombre1 descending select nEmp;

            foreach (Empleado em in nomEmp)
            {
                txtCONSULTA.AppendText(em.getDatosEmpleado());
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            string CAD = Microsoft.VisualBasic.Interaction.InputBox(" DIGITA LA EMPRESA DONDE TRABAJAS ","CONSULTA DONDE TRABAJAS");
            getEmpleadosUNI(CAD);
            radioButton3.Checked = false;



        }

        public void getEmpleadosUNI(string cadena)
        {
            /*IEnumerable<Empleado> nomEmp = from nEmp in listaEmpleados
                                           join empresa in listaEmpresas on nEmp.EmpresaId1 equals empresa.IdEmpresa1
                                           where empresa.NombreEmpresa1 == "UNI"
                                           select nEmp;*/





            /* IEnumerable<Empleado> nomEmp1 = from nEmpleado in listaEmpleados
                                             from nEmpresa in listaEmpresas
                                             where nEmpresa.NombreEmpresa1 == "UNI"
                                             where nEmpleado.EmpresaId1 == nEmpresa.IdEmpresa1                       
                                             select nEmpleado ;*/


            /*foreach (Empleado em in nomEmp)
            {
                txtCONSULTA.AppendText(em.getDatosEmpleado());
            }*/

            IEnumerable<DatosConsulta> nomEmp = from nEmp in listaEmpleados
                                           join empresa in listaEmpresas on nEmp.EmpresaId1 equals empresa.IdEmpresa1
                                           where empresa.NombreEmpresa1 == cadena
                                           select new DatosConsulta(nEmp.Nombre1, empresa.NombreEmpresa1);


           foreach (DatosConsulta em in nomEmp)
           {
               txtCONSULTA.AppendText(em.getDatosCosulta());
           }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtCONSULTA.Clear();
            getEmpresa();
        }

        public void getEmpresa()
        {
            IEnumerable<Empresa> nomEmpresa = from nEmpresa in listaEmpresas select nEmpresa;

            foreach (Empresa em in nomEmpresa)
            {
                txtCONSULTA.AppendText(em.getDatosEmpresa());
            }
        }
    }
}
