using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Images
    {
        public int idImage { get; set; }
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public byte[] Image { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool isEnabled { get; set; }
    }
}
