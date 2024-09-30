using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace CN_Medicos
{
    public class CN_Pacientes
    {
        private CD_Pacientes DatosPacientes = new CD_Pacientes();
        private CD_Medicos DatosMedicos = new CD_Medicos();
        public class Pacientes
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; }
            public string Eps { get; set; }
        }

        public CD_Pacientes.Pacientes BuscarPaciente(int codigoPaciente)
        {
            CD_Pacientes.Pacientes paciente = DatosPacientes.BuscarPacientePorCodigo(codigoPaciente);
            return paciente;
        }
        public CD_Pacientes.Pacientes IngresarPaciente(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            DatosPacientes.IngresarPaciente(codigo, nombre, apellido, edad, genero, eps);
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

        public void ActualizarPaciente(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            try
            {
                DatosPacientes.ActualizarPacientes(codigo, nombre, apellido, edad, genero, eps);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar paciente: " + ex.Message);
            }
        }
        public void EliminarPaciente(int codigoPaciente)
        {
            CD_Pacientes datosPacientes = new CD_Pacientes();
            datosPacientes.EliminarPacientes(codigoPaciente);
        }

        public List<CD_Pacientes.Pacientes> ListarPacientes()
        {
            return DatosPacientes.ListarPacientes();
        }
    }
}
