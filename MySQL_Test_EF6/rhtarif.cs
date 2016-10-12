namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.rhtarif")]
    public partial class rhtarif
    {
        [StringLength(25)]
        public string LEISTUNG { get; set; }

        [StringLength(10)]
        public string KUERZEL { get; set; }

        [StringLength(10)]
        public string T1_POS { get; set; }

        public decimal? T1_AKT { get; set; }

        public decimal? T1_ALT { get; set; }

        public decimal? T1_PROZ { get; set; }

        [StringLength(10)]
        public string T2_POS { get; set; }

        public decimal? T2_AKT { get; set; }

        public decimal? T2_ALT { get; set; }

        public decimal? T2_PROZ { get; set; }

        [StringLength(10)]
        public string T3_POS { get; set; }

        public decimal? T3_AKT { get; set; }

        public decimal? T3_ALT { get; set; }

        public decimal? T3_PROZ { get; set; }

        [StringLength(10)]
        public string T4_POS { get; set; }

        public decimal? T4_AKT { get; set; }

        public decimal? T4_ALT { get; set; }

        public decimal? T4_PROZ { get; set; }

        [StringLength(10)]
        public string T5_POS { get; set; }

        public decimal? T5_AKT { get; set; }

        public decimal? T5_ALT { get; set; }

        public decimal? T5_PROZ { get; set; }

        [StringLength(10)]
        public string T6_POS { get; set; }

        public decimal? T6_AKT { get; set; }

        public decimal? T6_ALT { get; set; }

        public decimal? T6_PROZ { get; set; }

        [StringLength(10)]
        public string T7_POS { get; set; }

        public decimal? T7_AKT { get; set; }

        public decimal? T7_ALT { get; set; }

        public decimal? T7_PROZ { get; set; }

        [StringLength(10)]
        public string T8_POS { get; set; }

        public decimal? T8_AKT { get; set; }

        public decimal? T8_ALT { get; set; }

        public decimal? T8_PROZ { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string ZUZAHLUNG { get; set; }

        public int ID { get; set; }
    }
}
