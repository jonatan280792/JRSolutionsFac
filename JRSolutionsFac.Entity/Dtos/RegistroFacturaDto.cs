using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Entity.Dtos
{
    public class RegistroFacturaDto
    {
        public int NumFac { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }
        
    }
}
