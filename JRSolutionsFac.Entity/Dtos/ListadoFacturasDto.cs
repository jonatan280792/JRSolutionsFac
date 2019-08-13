using System;

namespace JRSolutionsFac.Entity.Dtos
{
    public class ListadoFacturasDto
    {
        public int NumFac { get; set; }
        public string Detalle { get; set; }
        public string Placa { get; set; }
        public string Cliente { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}
