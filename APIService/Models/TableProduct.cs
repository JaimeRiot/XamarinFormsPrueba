using System;
using System.Collections.Generic;

namespace APIService.Models
{
    public partial class TableProduct
    {
        public int Id { get; set; }
        public string Nameproduct { get; set; }
        public int? Codebar { get; set; }
        public string Description { get; set; }
        public int? Stock { get; set; }
        public string Imgitem { get; set; }
    }
}
