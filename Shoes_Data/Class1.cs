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
            foreach (var item in lista.ToList())
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
                //if(item.DateUpdate == null)
               // {
                    item.DateUpdate = DateTime.Now;
               // }
            }
            return listaProductos;
        }
        public bool InsertData(Products obj) 
        {
            try
            {
                BDShoes.JRCV1_InserNewProduct(obj.IdType,
                    obj.IdColor,
                    obj.IdBrand,
                    obj.IdProvider,
                    obj.Title,
                    obj.Nombre,
                    obj.Description,
                    obj.Observations,
                    obj.PriceDistributor,
                    obj.PriceClient,
                    obj.PriceMember,
                    obj.IsEnabled,
                    obj.Keywords,
                    obj.DateUpdate);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool DeleteInFormLogic(int id, string name)
        {
            try
            {
                BDShoes.JRCV1_DeleteLogicIsEnabled(name, id);
                return true;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
