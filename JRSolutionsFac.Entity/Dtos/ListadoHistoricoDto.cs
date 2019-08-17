using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Entity.Dtos
{
    public class ListadoHistoricoDto
    {
        public int NumFac { get; set; }
        public string Tipo_Documento { get; set; }
        public string Numero_Documento { get; set; }
        public string Cliente { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public int Total { get; set; }
        public DateTime Fecha_Creacion { get; set; }
    }
}
