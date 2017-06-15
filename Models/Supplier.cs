namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [Key]
        public int Supplier_ID { get; set; }

        [StringLength(50)]
        public string Supplier_Name { get; set; }

        [StringLength(50)]
        public string Supplier_Contact { get; set; }

        [StringLength(50)]
        public string Supplier_Address { get; set; }
    }
}
