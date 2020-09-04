namespace APIPrueba.Web.Data
{

    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    public class Repository : IRepository
    {
        private readonly DataContext context;
        public Repository(DataContext context)
        {
            this.context = context;
        }
        public IEnumerable<Products> GetProducts()
        {
            return this.context.AllProducts.OrderBy(p => p.Name);
        }
        public Products GetProduct(int id)
        {
            return this.context.AllProducts.Find(id);
        }
        public void AddProduct(Products product)
        {
            this.context.AllProducts.Add(product);
        }
        public void UpdateProduct(Products product)
        {
            this.context.AllProducts.Update(product);
        }
        public void RemoveProduct(Products product)
        {
            this.context.AllProducts.Remove(product);
        }
        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }
        public bool ProductExists(int id)
        {
            return this.context.AllProducts.Any(p => p.Id == id);
        }
    }
}
