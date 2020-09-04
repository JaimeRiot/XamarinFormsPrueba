using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPrueba.Web.Data.Entities
{
    public class Products: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CodeBar { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
    }
}
