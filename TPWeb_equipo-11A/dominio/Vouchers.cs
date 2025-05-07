using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Vouchers
    {
        public string CodigoVoucher {  get; set; }
        public DateTime FechaCanje { get; set; }
        public Articulos ID_Articulo { get; set; }
        public Clientes ID_Cliente { get; set; }

    }
}
