namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Return_books
    {
        [Key]
        public int return_item_id { get; set; }

        [StringLength(50)]
        public string actual_return_date { get; set; }

        public int? due_days { get; set; }

        public double? fine { get; set; }

        public double? fine_per_day { get; set; }
    }
}
