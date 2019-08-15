using System;

namespace JRSolutionsFac.Entity.Dtos
{
    public class ReportFacturaEncabezadoDto
    {
        public int Id { get; set; }
        public int NumFac { get; set; }
        public string Nit { get; set; }
        public string Detalle { get; set; }
        public string Cajero { get; set; }
        public string Tipo_doc { get; set; }
        public string Numero_doc { get; set; }
        public string Nom_client { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Mecanica { get; set; }
        public string Latoneria { get; set; }
        public string Pintura { get; set; }
        public int Total { get; set; }
        public int Recibido { get; set; }
        public int Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fechaentrega { get; set; }
    }
}
