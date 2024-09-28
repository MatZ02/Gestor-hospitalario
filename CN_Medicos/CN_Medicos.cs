using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace CN_Medicos
{
    public class CN_Medicos
    {   
        private CD_Pacientes DatosMedicos = new CD_Pacientes();
        public class Pacientes
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; }
            public string Eps { get; set; }
        }

        public CD_Pacientes.Pacientes BuscarPacientePorCodigo(int codigoPaciente)
        {
            CD_Pacientes.Pacientes paciente = DatosMedicos.BuscarPacientes(codigoPaciente);
            return paciente;
        }
        public CD_Pacientes.Pacientes IngresarPaciente(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            DatosMedicos.IngresarPacientes(codigo, nombre, apellido, edad, genero, eps);
            CD_Pacientes.Pacientes paciente = new CD_Pacientes.Pacientes
            {
                Codigo = codigo,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Genero = genero,
                Eps = eps
            };
            return paciente;
        }

        public CD_Pacientes.Pacientes ModificarPaciente(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            DatosMedicos.ActualizarPacientes(codigo, nombre, apellido, edad, genero, eps);
            CD_Pacientes.Pacientes paciente = new CD_Pacientes.Pacientes
            {
                Codigo = codigo,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Genero = genero,
                Eps = eps
            };
            return paciente;
        }
        public CD_Pacientes.Pacientes EliminarPaciente(int codigo)
        {
            DatosMedicos.EliminarPacientes(codigo);
            CD_Pacientes.Pacientes paciente = new CD_Pacientes.Pacientes
            {
                Codigo = codigo
            };
            return paciente;
        }

    }
}
