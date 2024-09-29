using ClassLibrary1;

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
    }
}
