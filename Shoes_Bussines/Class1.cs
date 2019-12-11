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
        public bool InsertIntoTable(Productos obj)
        {
            var capData = new Shoes_Data.CapaData();
            Products p = new Products();
            p.IdType = obj.idType;
            p.IdColor = obj.idColor;
            p.IdBrand = obj.idBrand;
            p.IdProvider = obj.idProvider;
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
    }
}
