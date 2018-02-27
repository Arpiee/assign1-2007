namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Helicopter
    {
        [Required]
        [StringLength(50)]
        public string Helicopters { get; set; }

        [Column("Model Name")]
        [Required]
        [StringLength(50)]
        public string Model_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Purpose { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Price { get; set; }
    }
}
