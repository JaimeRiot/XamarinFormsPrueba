namespace APIPrueba.Web.Data
{
    
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;
    public interface IRepository
    {
        void AddProduct(Products product);
        Products GetProduct(int id);
        IEnumerable<Products> GetProducts();
        bool ProductExists(int id);
        void RemoveProduct(Products product);
        Task<bool> SaveAllAsync();
        void UpdateProduct(Products product);
    }
}