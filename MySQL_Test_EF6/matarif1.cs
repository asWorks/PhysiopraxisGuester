namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.matarif1")]
    public partial class matarif1
    {
        [StringLength(35)]
        public string LEISTUNG { get; set; }

        [StringLength(10)]
        public string KUERZEL { get; set; }

        [StringLength(10)]
        public string T_POS { get; set; }

        public decimal? T_AKT { get; set; }

        public decimal? T_ALT { get; set; }

        public decimal? T_PROZ { get; set; }

        public decimal? T_PAUSCHAL { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string ZUZAHLUNG { get; set; }

        public sbyte? ZZART { get; set; }

        public int ID { get; set; }
    }
}
