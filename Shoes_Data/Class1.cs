using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
                listaProductos.Add(new Products
                {
                    Id = item.Id,
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
                    DateUpdate = item.DateUpdate
                });
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
                    obj.IdCatalog,
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
            catch (System.Exception E)
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
        public List<CatColors> GetColors()
        {
            List<CatColors> colores = new List<CatColors>();
            var colors = BDShoes.JRCV1_GetColors();
            foreach (var item in colors)
            {
                colores.Add(new CatColors
                {
                    IdColor = item.IdColor,
                    Name = item.Name,
                    Description = item.Description,
                    HexaDecimal = item.HexaDecimal,
                    IsEnable = item.IsEnable
                });
            }
            return colores;
        }
        public List<CatSizes> GetSizes()
        {
            List<CatSizes> sizes = new List<CatSizes>();
            var tallas = BDShoes.JRCV1_GetSizes();
            foreach (var item in tallas)
            {
                sizes.Add(new CatSizes
                {
                    IdSize = item.IdSize,
                    IdType = item.IdType,
                    Code = item.Code,
                    Unity = item.Unity,
                    Description = item.Description,
                    Value = item.Value
                });
            }
            return sizes;
        }
        public bool InsertUpdateOfProduct(Products obj)
        {
            try
            {
                BDShoes.JRCV1_UpdateProduct(obj.Id,
                    obj.IdColor,
                    obj.IdCatalog,
                    obj.Nombre,
                    obj.Description);
                return true;
            }
            catch (System.Exception e)
            {

                return false;
            }
        }
        public List<ImagesProduct> GetImagesOfProduct(int id)
        {
            var images = BDShoes.JRCV1_GetImages(id);
            List<ImagesProduct> Limages = new List<ImagesProduct>();
            foreach (var item in images)
            {
                Limages.Add(new ImagesProduct {IdImage = item.IdImage,
                IdProduct = item.IdProduct,
                Decription = item.Decription,
                Image = item.Image,
                DateUpdate = item.DateUpdate,
                IsEnabled = item.IsEnabled});
            }
            return Limages;
        }
        public bool InsertImages(ImagesProduct obj)
        {
            try
            {
                BDShoes.JRCV1_InsertImages(obj.IdProduct,
                    obj.Decription,
                    obj.Image,
                    obj.DateUpdate,
                    obj.IsEnabled);
                return true;
            }
            catch(System.Exception e)
            {
                return false;
            }
        }
    }
}
