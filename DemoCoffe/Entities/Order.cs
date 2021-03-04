namespace DemoCoffe.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderId { get; set; }

        [StringLength(20)]
        public string OrderCode { get; set; }

        public DateTime? OrderStart { get; set; }

        public DateTime? OrderEnd { get; set; }

        public int? OrderPeoPleQuantity { get; set; }

        [StringLength(20)]
        public string OrderCodeDiscount { get; set; }

        public decimal? OrderTotalDiscount { get; set; }

        public decimal? OrderTotalTax { get; set; }

        public decimal? OrderTotal { get; set; }

        public bool? OrderCheckout { get; set; }

        public int? TableId { get; set; }
    }
}
