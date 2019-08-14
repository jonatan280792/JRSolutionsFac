using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Entity.Dtos
{
    public class RegistroFacturaDto
    {
        public int numfac { get; set; }
        public string nit { get; set; }
        public string detalle { get; set; }
        public string cajero { get; set; }
        public string numero_doc { get; set; }
        public string tipo_doc { get; set; }
        public string nom_client { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public string mecanica { get; set; }
        public string latoneria { get; set; }
        public string pintura { get; set; }
        public string tipo { get; set; }
        public int modelo { get; set; }
        public int total { get; set; }
        public int valorrecibido { get; set; }
        public int cambio { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fechaentrega { get; set; }

    }
}
