using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;

namespace CN_Medicos
{
    public class CN_Medicos
    {
        private CD_Medicos DatosMedicos = new CD_Medicos();

        // Cambia el nombre de la clase Medicos a MedicoInfo
        public class MedicoInfo
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


        public CD_Medicos.Medicos BuscarMedicoPorCodigo(int codigo)
        {
            List<CD_Medicos.Medicos> listaMedicos = DatosMedicos.ObtenerMedicos();
            return listaMedicos.FirstOrDefault(m => m.Codigo == codigo);
        }
    }
}
