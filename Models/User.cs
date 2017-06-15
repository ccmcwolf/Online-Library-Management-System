namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [StringLength(100)]
        public string User_Name { get; set; }

        [StringLength(500)]
        public string password { get; set; }

        [StringLength(100)]
        public string User_Type { get; set; }
    }
}
