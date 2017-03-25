using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    partial class OrdemServicoItem
    {
        public decimal SubTotal
        {
            get { return Qtde * Preco; }
        }
    }
}
