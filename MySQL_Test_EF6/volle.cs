namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.volle")]
    public partial class volle
    {
        [Required]
        [StringLength(25)]
        public string rez_nr { get; set; }

        public int pat_intern { get; set; }

        [StringLength(40)]
        public string behandler { get; set; }

        [Column(TypeName = "date")]
        public DateTime fertigam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rez_datum { get; set; }

        public int? rezid { get; set; }

        public int id { get; set; }
    }
}
