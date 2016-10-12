namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.rgaffaktura")]
    public partial class rgaffaktura
    {
        [Required]
        [StringLength(25)]
        public string rnr { get; set; }

        [Required]
        [StringLength(25)]
        public string reznr { get; set; }

        [Required]
        [StringLength(25)]
        public string pat_intern { get; set; }

        public decimal rgesamt { get; set; }

        public decimal roffen { get; set; }

        public decimal rgbetrag { get; set; }

        public decimal rpbetrag { get; set; }

        [Column(TypeName = "date")]
        public DateTime rdatum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rbezdatum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rmahndat1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rmahndat2 { get; set; }

        public int id { get; set; }

        [StringLength(9)]
        public string IK { get; set; }
    }
}
