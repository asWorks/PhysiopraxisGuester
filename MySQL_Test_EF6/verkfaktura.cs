namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.verkfaktura")]
    public partial class verkfaktura
    {
        public int verkfakturaID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string v_nummer { get; set; }

        public long art_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string art_beschreibung { get; set; }

        public decimal art_einzelpreis { get; set; }

        public decimal art_mwst { get; set; }

        public decimal anzahl { get; set; }

        public int pat_id { get; set; }

        [StringLength(9)]
        public string IK { get; set; }
    }
}
