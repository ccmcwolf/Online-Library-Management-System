namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book_borrow
    {
        [Key]
        public int borrow_id { get; set; }

        public int? member_id { get; set; }

        public int? book_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? borrow_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? return_date { get; set; }

        public bool? is_returned { get; set; }
    }
}
