namespace ReReView.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restuarant")]
    public partial class Restuarant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restuarant()
        {
            Menus = new HashSet<Menu>();
            Reviews = new HashSet<Review>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int restaurantID { get; set; }

        [Required]
        [StringLength(50)]
        public string restaurantName { get; set; }

        [Column("class")]
        [Required]
        [StringLength(50)]
        public string _class { get; set; }

        public double? star { get; set; }

        [Required]
        [StringLength(50)]
        public string openTime { get; set; }

        [Required]
        [StringLength(50)]
        public string closeTIme { get; set; }

        public double? priceRange { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
