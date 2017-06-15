namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        public int memberId { get; set; }

        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string last_name { get; set; }

        [StringLength(50)]
        public string nic { get; set; }

        [StringLength(50)]
        public string contact { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dob { get; set; }

        [Column(TypeName = "date")]
        public DateTime? reg_date { get; set; }
    }
}
