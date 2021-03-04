namespace DemoCoffe.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductId { get; set; }

        public byte[] ProductImage { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(200)]
        public string ProductDescription { get; set; }

        public decimal? ProductPrice { get; set; }

        public decimal? ProductDiscount { get; set; }
    }
}
