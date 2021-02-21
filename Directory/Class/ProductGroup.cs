using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Class
{
    public class ProductGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; } 
        public int ? ParentId { get; set; }

        public List<ProductGroup> Child { get; set; }
    }
}
