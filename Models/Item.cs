namespace OnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [Key]
        public int book_id { get; set; }

        [StringLength(50)]
        public string book_name { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(50)]
        public string publisher { get; set; }

        [Required]
        [StringLength(50)]
        public string p_year { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string edition { get; set; }

        [StringLength(50)]
        public string category { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        public int? available_copies { get; set; }

        public int? copy_no { get; set; }

        [StringLength(50)]
        public string isbn_no { get; set; }

        public double? item_price { get; set; }

        [StringLength(50)]
        public string is_borrowed { get; set; }
    }
}
