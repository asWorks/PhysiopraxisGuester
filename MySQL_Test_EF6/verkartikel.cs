namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.verkartikel")]
    public partial class verkartikel
    {
        public int verkartikelID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ean { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string beschreibung { get; set; }

        public decimal preis { get; set; }

        public decimal mwst { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string einheit { get; set; }

        public decimal lagerstand { get; set; }

        public int verklieferantID { get; set; }

        public decimal einkaufspreis { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime lastedit { get; set; }
    }
}
