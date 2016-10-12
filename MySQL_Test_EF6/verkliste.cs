namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.verkliste")]
    public partial class verkliste
    {
        public int verklisteID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string v_nummer { get; set; }

        [Column(TypeName = "date")]
        public DateTime v_datum { get; set; }

        public decimal v_betrag { get; set; }

        public decimal v_mwst7 { get; set; }

        public decimal v_mwst19 { get; set; }

        public decimal v_offen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? v_bezahldatum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? mahndat1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? mahndat2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? mahndat3 { get; set; }

        public bool? mahnsperre { get; set; }

        public int pat_id { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string user { get; set; }

        [StringLength(9)]
        public string IK { get; set; }
    }
}
