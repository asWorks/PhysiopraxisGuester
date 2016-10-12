namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.rliste")]
    public partial class rliste
    {
        public long? R_NUMMER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? R_DATUM { get; set; }

        [StringLength(40)]
        public string R_KASSE { get; set; }

        [StringLength(40)]
        public string R_NAME { get; set; }

        [StringLength(10)]
        public string R_KLASSE { get; set; }

        public decimal? R_BETRAG { get; set; }

        public decimal? R_OFFEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? R_BEZDATUM { get; set; }

        public decimal? R_ZUZAHL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MAHNDAT1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MAHNDAT2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MAHNDAT3 { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string MAHNSPERR { get; set; }

        [StringLength(25)]
        public string PAT_INTERN { get; set; }

        [StringLength(10)]
        public string IKKTRAEGER { get; set; }

        public int ID { get; set; }

        [StringLength(9)]
        public string IK { get; set; }
    }
}
