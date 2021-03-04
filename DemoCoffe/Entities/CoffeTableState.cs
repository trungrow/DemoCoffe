namespace DemoCoffe.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CoffeTableState
    {
        [Key]
        public int StateId { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        [StringLength(20)]
        public string StateColor { get; set; }
    }
}
