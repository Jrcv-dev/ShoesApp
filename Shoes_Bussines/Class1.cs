using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Shoes_Bussines
{
    public class CapaNegocio
    {
        public List<Productos> GetProduct(int id, string name)
        {
            var capaData = new Shoes_Data.CapaData();
            List<Productos> Producto = new List<Productos>();
            var listaProducts = capaData.Search(id, name);
            foreach (var item in listaProducts)
            {
                Producto.Add(new Productos {
                    id = item.Id,
                    idType = item.IdType,
                    idColor = item.IdColor,
                    idBrand = item.IdBrand,
                    idProvider = item.IdProvider,
                    Tittle = item.Title,
                    Nombre = item.Nombre,
                    Descripcion = item.Description,
                    Observaciones = item.Observations,
                    PrecioDistribuidor = item.PriceDistributor,
                    PrecioCliente = item.PriceClient,
                    PrecioMiembro = item.PriceMember,
                    IsEnabled = item.IsEnabled,
                    Keywords = item.Keywords,
                    DateUpdate = item.DateUpdate
                });
            }
            return Producto;
        }
    }
}
