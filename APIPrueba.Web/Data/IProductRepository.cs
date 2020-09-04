namespace APIPrueba.Web.Data
{
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.Linq;

    public interface IProductRepository : IGenericRepository<Products>
    {

    }
}
