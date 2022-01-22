using Bibliotecas.Validacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Modelo
{
    public class OrdemServicoItemRegras
    {
        [ChaveEstrangeira]
        public int MercadoriaID { get; set; }
        [Range(0.01, 1000000)]
        public decimal Qtde { get; set; }
    }
}
