﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shoes_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DataProductsEntities : DbContext
    {
        public DataProductsEntities()
            : base("name=DataProductsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatBrands> CatBrands { get; set; }
        public virtual DbSet<CatCatalogs> CatCatalogs { get; set; }
        public virtual DbSet<CatColors> CatColors { get; set; }
        public virtual DbSet<CatProviders> CatProviders { get; set; }
        public virtual DbSet<CatRatings> CatRatings { get; set; }
        public virtual DbSet<CatSizes> CatSizes { get; set; }
        public virtual DbSet<CatTypeDetails> CatTypeDetails { get; set; }
        public virtual DbSet<CatTypeProduct> CatTypeProduct { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<database_firewall_rules1> database_firewall_rules1 { get; set; }
        public virtual DbSet<DetailProduct> DetailProduct { get; set; }
        public virtual DbSet<ImagesProduct> ImagesProduct { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<SimilarProduct> SimilarProduct { get; set; }
        public virtual DbSet<SizeForProduct> SizeForProduct { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<database_firewall_rules2> database_firewall_rules2 { get; set; }
    
        public virtual int JRCV1_DeleteLogicIsEnabled(string nombre, Nullable<int> id)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JRCV1_DeleteLogicIsEnabled", nombreParameter, idParameter);
        }
    
        public virtual ObjectResult<JRCV1_GetColors_Result> JRCV1_GetColors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JRCV1_GetColors_Result>("JRCV1_GetColors");
        }
    
        public virtual ObjectResult<JRCV1_GetImages_Result> JRCV1_GetImages(Nullable<int> idProduct)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("IdProduct", idProduct) :
                new ObjectParameter("IdProduct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JRCV1_GetImages_Result>("JRCV1_GetImages", idProductParameter);
        }
    
        public virtual ObjectResult<JRCV1_GetSizes_Result> JRCV1_GetSizes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JRCV1_GetSizes_Result>("JRCV1_GetSizes");
        }
    
        public virtual int JRCV1_InserNewProduct(Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string tittle, string nombre, string descripcion, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dateUpdate)
        {
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("IdType", idType) :
                new ObjectParameter("IdType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("IdColor", idColor) :
                new ObjectParameter("IdColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("IdBrand", idBrand) :
                new ObjectParameter("IdBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("IdProvider", idProvider) :
                new ObjectParameter("IdProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("IdCatalog", idCatalog) :
                new ObjectParameter("IdCatalog", typeof(int));
    
            var tittleParameter = tittle != null ?
                new ObjectParameter("Tittle", tittle) :
                new ObjectParameter("Tittle", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dateUpdateParameter = dateUpdate.HasValue ?
                new ObjectParameter("DateUpdate", dateUpdate) :
                new ObjectParameter("DateUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JRCV1_InserNewProduct", idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, tittleParameter, nombreParameter, descripcionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dateUpdateParameter);
        }
    
        public virtual ObjectResult<JRCV1_SearchShoesProduct_Result> JRCV1_SearchShoesProduct(Nullable<int> id, string nombre)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JRCV1_SearchShoesProduct_Result>("JRCV1_SearchShoesProduct", idParameter, nombreParameter);
        }
    
        public virtual int JRCV1_UpdateProduct(Nullable<int> id, Nullable<int> idColor, Nullable<int> idCatalog, string nombre, string description)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("IdColor", idColor) :
                new ObjectParameter("IdColor", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("IdCatalog", idCatalog) :
                new ObjectParameter("IdCatalog", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JRCV1_UpdateProduct", idParameter, idColorParameter, idCatalogParameter, nombreParameter, descriptionParameter);
        }
    
        public virtual int JRCV1_InsertImages(Nullable<int> idProduct, string descripcion, byte[] image, Nullable<System.DateTime> dateUpdate, Nullable<bool> isEnable)
        {
            var idProductParameter = idProduct.HasValue ?
                new ObjectParameter("idProduct", idProduct) :
                new ObjectParameter("idProduct", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(byte[]));
    
            var dateUpdateParameter = dateUpdate.HasValue ?
                new ObjectParameter("DateUpdate", dateUpdate) :
                new ObjectParameter("DateUpdate", typeof(System.DateTime));
    
            var isEnableParameter = isEnable.HasValue ?
                new ObjectParameter("IsEnable", isEnable) :
                new ObjectParameter("IsEnable", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("JRCV1_InsertImages", idProductParameter, descripcionParameter, imageParameter, dateUpdateParameter, isEnableParameter);
        }
    }
}
