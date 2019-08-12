using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Entity.Dtos
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool Status { get; set; }
    }
}
