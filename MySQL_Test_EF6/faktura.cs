namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.faktura")]
    public partial class faktura
    {
        [StringLength(40)]
        public string KASSEN_NAM { get; set; }

        [StringLength(40)]
        public string KASSEN_NA2 { get; set; }

        [StringLength(40)]
        public string STRASSE { get; set; }

        [StringLength(5)]
        public string PLZ { get; set; }

        [StringLength(30)]
        public string ORT { get; set; }

        public short? LFNR { get; set; }

        [StringLength(5)]
        public string STATUS { get; set; }

        [StringLength(40)]
        public string NAME { get; set; }

        public sbyte? POS_INT { get; set; }

        [StringLength(6)]
        public string POS_KAS { get; set; }

        [Required]
        [StringLength(10)]
        public string KUERZEL { get; set; }

        public short? ANZAHL { get; set; }

        public decimal? PREIS { get; set; }

        public decimal? FAKTOR { get; set; }

        public decimal? GESAMT { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string ZUZAHL { get; set; }

        public decimal? ZZBETRAG { get; set; }

        public decimal? NETTO { get; set; }

        public sbyte? STAT_2 { get; set; }

        [StringLength(25)]
        public string REZ_NR { get; set; }

        public decimal? PAUSCHALE { get; set; }

        public sbyte? REZEPTART { get; set; }

        public decimal? KILOMETER { get; set; }

        [StringLength(10)]
        public string IKKASSEN { get; set; }

        [StringLength(10)]
        public string IKKOSTEN { get; set; }

        [StringLength(10)]
        public string IKSCHLUESS { get; set; }

        [StringLength(10)]
        public string IKPHYSIK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VERAENDERD { get; set; }

        public sbyte? VERAENDERA { get; set; }

        public int RNUMMER { get; set; }

        public sbyte ZZSTATUS { get; set; }

        [Required]
        [StringLength(25)]
        public string PAT_INTERN { get; set; }

        public int KASSID { get; set; }

        public int ARZTID { get; set; }

        public int ANZAHLTAGE { get; set; }

        public int ZZINDEX { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string PREISDIFF { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string ZUZAHLDIFF { get; set; }

        [Required]
        [StringLength(5)]
        public string DISZIPLIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime RDATUM { get; set; }

        public int ID { get; set; }

        [StringLength(9)]
        public string IK { get; set; }
    }
}
