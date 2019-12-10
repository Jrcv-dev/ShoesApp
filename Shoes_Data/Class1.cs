using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shoes_Data
{
    public class CapaData
    {
        DataProductsEntities BDShoes = new DataProductsEntities();
        public List<Products> Search(int id, string name)
        {
            List<Products> listaProductos = new List<Products>();
            var lista = BDShoes.JRCV1_SearchShoesProduct(id, name);
            foreach (var item in lista)
            {
                listaProductos.Add(new Products { Id = item.Id,
                    IdType = item.IdType,
                    IdColor = item.IdColor,
                    IdBrand = item.IdBrand,
                    IdProvider = item.IdBrand,
                    Title = item.Title,
                    Nombre = item.Nombre,
                    Description = item.Description,
                    Observations = item.Observations,
                    PriceDistributor = item.PriceDistributor,
                    PriceClient = item.PriceClient,
                    PriceMember = item.PriceMember,
                    IsEnabled = item.IsEnabled,
                    Keywords = item.Keywords,
                    DateUpdate = item.DateUpdate});
            }
            return listaProductos;
        }
    }
}
