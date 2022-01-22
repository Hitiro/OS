using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Modelo
{
    class MercadoriaRegras
    {
        [Required, MaxLength(50)]
        public string Nome { get; set; }

        [Range(0.01, Double.MaxValue)]
        public double Preco { get; set; }

    }
}
