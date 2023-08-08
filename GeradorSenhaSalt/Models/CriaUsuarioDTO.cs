using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSenhaSalt.Models
{
    public class CriaUsuarioDTO
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
