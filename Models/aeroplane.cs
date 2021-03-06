namespace assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aeroplane
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string planes { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string company { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int price { get; set; }
    }
}
