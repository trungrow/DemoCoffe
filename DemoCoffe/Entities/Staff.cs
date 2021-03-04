namespace DemoCoffe.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Staff
    {
        public int StaffId { get; set; }

        [StringLength(20)]
        public string StaffCode { get; set; }

        [StringLength(100)]
        public string StaffPassword { get; set; }

        [StringLength(50)]
        public string StaffFullName { get; set; }

        [StringLength(50)]
        public string StaffMail { get; set; }

        [StringLength(20)]
        public string StaffPhone { get; set; }

        [StringLength(200)]
        public string StaffAddress { get; set; }

        public byte[] StaffAvatar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StaffBrithDay { get; set; }

        public bool? StaffGender { get; set; }
    }
}
