using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Product.Class
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
        
        [StringLength(255)]
        public string UrlSlug { get; set; }

        [ForeignKey("Parent")]
        public int ? ParentId { get; set; }

        public virtual Product Parent { get; set; }
    }
}
