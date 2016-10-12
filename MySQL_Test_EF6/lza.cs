namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.lza")]
    public partial class lza
    {
        public int? PAT_INTERN { get; set; }

        [StringLength(25)]
        public string REZ_NR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REZ_DATUM { get; set; }

        public short ANZAHL1 { get; set; }

        public short ANZAHL2 { get; set; }

        public short ANZAHL3 { get; set; }

        public short ANZAHL4 { get; set; }

        public decimal ANZAHLKM { get; set; }

        public sbyte? ART_DBEH1 { get; set; }

        public sbyte? ART_DBEH2 { get; set; }

        public sbyte? ART_DBEH3 { get; set; }

        public sbyte? ART_DBEH4 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string BEFR { get; set; }

        public decimal REZ_GEB { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string REZ_BEZ { get; set; }

        [StringLength(30)]
        public string ARZT { get; set; }

        public int ARZTID { get; set; }

        [StringLength(1073741823)]
        public string AERZTE { get; set; }

        public decimal PREISE1 { get; set; }

        public decimal PREISE2 { get; set; }

        public decimal PREISE3 { get; set; }

        public decimal PREISE4 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATUM { get; set; }

        [StringLength(1073741823)]
        public string DIAGNOSE { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string HEIMBEWOHN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VERAENDERD { get; set; }

        public sbyte? VERAENDERA { get; set; }

        public sbyte? REZEPTART { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string LOGFREI1 { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string LOGFREI2 { get; set; }

        public sbyte? NUMFREI1 { get; set; }

        public sbyte? NUMFREI2 { get; set; }

        [StringLength(10)]
        public string CHARFREI1 { get; set; }

        [StringLength(10)]
        public string CHARFREI2 { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string TERMINE { get; set; }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string KTRAEGER { get; set; }

        public int KID { get; set; }

        public int PATID { get; set; }

        public sbyte ZZSTATUS { get; set; }

        [Column(TypeName = "date")]
        public DateTime LASTDATE { get; set; }

        public sbyte PREISGRUPPE { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string BEGRUENDADR { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string HAUSBES { get; set; }

        [Required]
        [StringLength(15)]
        public string INDIKATSCHL { get; set; }

        [Required]
        [StringLength(15)]
        public string ANGELEGTVON { get; set; }

        public sbyte BARCODEFORM { get; set; }

        [Required]
        [StringLength(10)]
        public string DAUER { get; set; }

        [Required]
        [StringLength(10)]
        public string POS1 { get; set; }

        [Required]
        [StringLength(10)]
        public string POS2 { get; set; }

        [Required]
        [StringLength(10)]
        public string POS3 { get; set; }

        [Required]
        [StringLength(10)]
        public string POS4 { get; set; }

        [Required]
        [StringLength(3)]
        public string FREQUENZ { get; set; }

        [Required]
        [StringLength(15)]
        public string LASTEDIT { get; set; }

        public int BERID { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string ARZTBERICHT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTEDDATE { get; set; }

        [Required]
        [StringLength(15)]
        public string FARBCODE { get; set; }

        [StringLength(10)]
        public string RSPLIT { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(4)]
        public string JAHRFREI { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string UNTER18 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string HBVOLL { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string ABSCHLUSS { get; set; }

        public sbyte ZZREGEL { get; set; }

        public short ANZAHLHB { get; set; }

        [StringLength(10)]
        public string KUERZEL1 { get; set; }

        [StringLength(10)]
        public string KUERZEL2 { get; set; }

        [StringLength(10)]
        public string KUERZEL3 { get; set; }

        [StringLength(10)]
        public string KUERZEL4 { get; set; }

        [StringLength(10)]
        public string KUERZEL5 { get; set; }

        [StringLength(10)]
        public string KUERZEL6 { get; set; }

        [StringLength(10)]
        public string ICD10 { get; set; }
    }
}
