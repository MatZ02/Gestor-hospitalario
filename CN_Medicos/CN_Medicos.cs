using ClassLibrary1;
using System.Collections.Generic;

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
        
        public List<CD_Medicos.Medicos> MostrarMedicos()
        {
            return DatosMedicos.ObtenerMedicos();
        }

    }
}
