namespace DemoCoffe.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin
    {
        public int AdminId { get; set; }

        [StringLength(20)]
        public string AdminUserName { get; set; }

        [StringLength(100)]
        public string AdminPassword { get; set; }

        [StringLength(50)]
        public string AdminFullName { get; set; }

        [StringLength(50)]
        public string AdminMail { get; set; }

        [StringLength(20)]
        public string AdminPhone { get; set; }

        [StringLength(200)]
        public string AdminAddress { get; set; }

        [StringLength(100)]
        public string AdminAvatar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AdminBrithDay { get; set; }

        public bool? AdminGender { get; set; }
    }
}
