using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Productos
    {
        public int id { get; set; }
        public int? idType { get; set; }
        public int? idColor { get; set; }
        public int? idBrand { get; set; }
        public int? idProvider { get; set; }
        public string Tittle { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public decimal? PrecioDistribuidor { get; set; }
        public decimal PrecioCliente { get; set; }
        public decimal PrecioMiembro { get; set; }
        public bool IsEnabled { get; set; }
        public string Keywords { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
