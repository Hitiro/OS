using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Modelo
{
    class FuncionarioComissaoRegras
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required, Range(0.01, 99.99)]
        public double Porcentagem { get; set; }
    }
}
