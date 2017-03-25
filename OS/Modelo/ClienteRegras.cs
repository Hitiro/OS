using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Modelo
{
    class ClienteRegras
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Documento { get; set; }
        [Required]
        public string Telefone1 { get; set; }
    }
}
