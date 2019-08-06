namespace ReReView.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        [StringLength(50)]
        public string menuName { get; set; }

        public int menuRestaurantID { get; set; }

        public double price { get; set; }

        [Required]
        [StringLength(50)]
        public string menuType { get; set; }

        public virtual Restuarant Restuarant { get; set; }
    }
}
