namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.verklieferant")]
    public partial class verklieferant
    {
        public int verklieferantID { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ansprechpartner { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string anschrift { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string plz { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ort { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string telefon { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string telefax { get; set; }
    }
}
