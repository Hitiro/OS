using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Modelo
{
    class FuncionarioAdmRegras
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required, Range(1, 1000000)]
        public double Salario { get; set; }
    }
}
