namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.allepreise")]
    public partial class allepreise
    {
        [Required]
        [StringLength(10)]
        public string disziplin { get; set; }

        [StringLength(30)]
        public string buland { get; set; }

        [Required]
        [StringLength(30)]
        public string preisgruppe { get; set; }

        [Required]
        [StringLength(10)]
        public string posnr { get; set; }

        [Required]
        [StringLength(250)]
        public string langtext { get; set; }

        public decimal preis { get; set; }

        [Column(TypeName = "date")]
        public DateTime? gueltigab { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string bundesweit { get; set; }

        public int id { get; set; }
    }
}
