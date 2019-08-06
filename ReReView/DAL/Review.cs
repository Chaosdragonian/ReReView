namespace ReReView.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public partial class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reviewID { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        public int? score { get; set; }

        [Required]
        public string reviewExplanation { get; set; }

        public int reviewRestaurantID { get; set; }

        public virtual Restuarant Restuarant { get; set; }
    }
}
