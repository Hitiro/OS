using Bibliotecas.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Modelo
{
    public class OrdemServicoRegras
    {
        [ChaveEstrangeira]
        public int ClienteID { get; set; }
    }
}
