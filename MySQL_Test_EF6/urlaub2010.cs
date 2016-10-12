namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.urlaub2010")]
    public partial class urlaub2010
    {
        public int KW { get; set; }

        [StringLength(21)]
        public string VON_BIS { get; set; }

        public decimal? MO_STUNDEN { get; set; }

        [StringLength(4)]
        public string MO_ART { get; set; }

        public decimal? DI_STUNDEN { get; set; }

        [StringLength(4)]
        public string DI_ART { get; set; }

        public decimal? MI_STUNDEN { get; set; }

        [StringLength(4)]
        public string MI_ART { get; set; }

        public decimal? DO_STUNDEN { get; set; }

        [StringLength(4)]
        public string DO_ART { get; set; }

        public decimal? FR_STUNDEN { get; set; }

        [StringLength(4)]
        public string FR_ART { get; set; }

        public decimal? SA_STUNDEN { get; set; }

        [StringLength(4)]
        public string SA_ART { get; set; }

        public decimal? SO_STUNDEN { get; set; }

        [StringLength(4)]
        public string SO_ART { get; set; }

        public decimal? IST_ARBEIT { get; set; }

        public decimal? SOLL_ARBEI { get; set; }

        public decimal? UEBERSTUND { get; set; }

        public decimal? URLAUB { get; set; }

        public decimal? KRANKHEIT { get; set; }

        public decimal? AUSFALL { get; set; }

        public int KAL_ZEILE { get; set; }

        [Required]
        [StringLength(40)]
        public string KAL_BENUTZER { get; set; }

        public int JAHR { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string BERECHNET { get; set; }

        public int ID { get; set; }
    }
}
