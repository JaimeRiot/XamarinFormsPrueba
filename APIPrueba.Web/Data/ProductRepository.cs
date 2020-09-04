
namespace APIPrueba.Web.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {

        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}