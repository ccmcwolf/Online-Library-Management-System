namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Available_Items
    {
        [Key]
        public int Book_id { get; set; }

        public int? Total_no_of_copies { get; set; }

        public int? Available_copies { get; set; }
    }
}
