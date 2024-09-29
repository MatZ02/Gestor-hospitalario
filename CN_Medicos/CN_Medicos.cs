using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN_Medicos
{
    public class CN_Medicos
    {
        private CD_Medicos DatosMedicos = new CD_Medicos();
        public class Medicos
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Especialidad { get; set; }
            public string Consultorio { get; set; }
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
        public List<CD_Medicos.Medicos> MostrarMedicos()
        {
            return DatosMedicos.ObtenerMedicos();
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
