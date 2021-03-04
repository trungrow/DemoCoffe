namespace DemoCoffe.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoffeTable
    {
        [Key]
        public int TableId { get; set; }

        [StringLength(30)]
        public string TableName { get; set; }

        public int? TableSize { get; set; }

        public bool? TableDisplay { get; set; }
    }
}
