using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shoes_Data;

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
                Producto.Add(new Productos
                {
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
        public bool InsertIntoTable(Productos obj)
        {
            var capData = new Shoes_Data.CapaData();
            Products p = new Products();
            p.IdType = obj.idType;
            p.IdColor = obj.idColor;
            p.IdBrand = obj.idBrand;
            p.IdProvider = obj.idProvider;
            p.IdCatalog = obj.idCatalog;
            p.Title = obj.Tittle;
            p.Nombre = obj.Nombre;
            p.Description = obj.Descripcion;
            p.Observations = obj.Observaciones;
            p.PriceDistributor = obj.PrecioDistribuidor;
            p.PriceClient = obj.PrecioCliente;
            p.PriceMember = obj.PrecioMiembro;
            p.IsEnabled = obj.IsEnabled;
            p.Keywords = obj.Keywords;
            p.DateUpdate = obj.DateUpdate;
            var estado = capData.InsertData(p);
            if (estado == true)
                return true;
            else
                return false;
        }
        public bool DisabledProduct(int id, string name)
        {
            var capData = new Shoes_Data.CapaData();
            var estado = capData.DeleteInFormLogic(id, name);
            return estado;
        }
        public List<Colores> ObtenerColores()
        {
            var capData = new Shoes_Data.CapaData();
            List<Colores> colores = new List<Colores>();
            var listaC = capData.GetColors();
            foreach (var item in listaC)
            {
                colores.Add(new Colores
                {
                    idColor = item.IdColor,
                    Name = item.Name,
                    Description = item.Description,
                    HexaDecimal = item.HexaDecimal,
                    isEnable = item.IsEnable
                });
            }
            return colores;
        }
        public List<Sizes> ObtenerTallas()
        {
            var capData = new Shoes_Data.CapaData();
            List<Sizes> sizes = new List<Sizes>();
            var listSize = capData.GetSizes();
            foreach (var item in listSize)
            {
                sizes.Add(new Sizes
                {
                    idSize = item.IdSize,
                    idType = item.IdType,
                    Code = item.Code,
                    Unity = item.Unity,
                    Description = item.Description,
                    Value = item.Value
                });
            }
            return sizes;
        }
        public bool UpdateProduct(Productos obj)
        {
            var capData = new Shoes_Data.CapaData();
            Products p = new Products();
            try
            {
                p.Id = obj.id;
                p.IdColor = obj.idColor;
                p.IdCatalog = obj.idCatalog;
                p.Nombre = obj.Nombre;
                p.Description = obj.Descripcion;
                var a = capData.InsertUpdateOfProduct(p);
                return a;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
