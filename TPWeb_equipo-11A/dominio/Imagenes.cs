using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Imagenes
    {
        public int Id {  get; set; }
        public Articulos ID_Articulo { get; set; }
        public string ImagenURL { get; set; }

    }
}
