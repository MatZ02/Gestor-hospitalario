using ClassLibrary1;

namespace CN_Medicos
{
    public class CN_Medicos
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
        public class Medicos
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Especialidad { get; set; }
            public string Consultorio { get; set; }
        }

        public CD_Pacientes.Pacientes BuscarPacientePorCodigo(int codigoPaciente)
        {
            CD_Pacientes.Pacientes paciente = DatosPacientes.BuscarPacientes(codigoPaciente);
            return paciente;
        }
        public CD_Pacientes.Pacientes IngresarPaciente(int codigo, string nombre, string apellido, int edad, string genero, string eps)
        {
            DatosPacientes.IngresarPacientes(codigo, nombre, apellido, edad, genero, eps);
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
            DatosPacientes.ActualizarPacientes(codigo, nombre, apellido, edad, genero, eps);
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
            DatosPacientes.EliminarPacientes(codigo);
            CD_Pacientes.Pacientes paciente = new CD_Pacientes.Pacientes
            {
                Codigo = codigo
            };
            return paciente;
        }
        public CD_Medicos.Medicos IngresarMedico(int codigo, string nombre, string apellido, string especialidad, string consultorio)
        {
            DatosMedicos.IngresarMedicos(codigo, nombre, apellido, especialidad, consultorio);
            CD_Medicos.Medicos medico = new CD_Medicos.Medicos
            {
                Codigo = codigo,
                Nombre = nombre,
                Apellido = apellido,
                Especialidad = especialidad,
                Consultorio = consultorio
            };
            return medico;
        }
        public CD_Medicos.Medicos BuscarMedicoPorCodigo(int codigoMedico)
        {
            CD_Medicos.Medicos medico = DatosMedicos.BuscarMedicos(codigoMedico);
            return medico;
        }

        public CD_Medicos.Medicos ModificarMedico(int codigo, string nombre, string apellido, string especialidad, string consultorio)
        {
            DatosMedicos.ActualizarMedicos(codigo, nombre, apellido, especialidad, consultorio);
            CD_Medicos.Medicos medico = new CD_Medicos.Medicos
            {
                Codigo = codigo,
                Nombre = nombre,
                Apellido = apellido,
                Especialidad = especialidad,
                Consultorio = consultorio
            };
            return medico;
        }
        public CD_Medicos.Medicos EliminarMedico(int codigo)
        {
            DatosMedicos.EliminarMedicos(codigo);
            CD_Medicos.Medicos medico = new CD_Medicos.Medicos
            {
                Codigo = codigo
            };
            return medico;
        }









    }
}
