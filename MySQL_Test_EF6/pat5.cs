namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.pat5")]
    public partial class pat5
    {
        [StringLength(5)]
        public string ANREDE { get; set; }

        [StringLength(15)]
        public string TITEL { get; set; }

        [StringLength(30)]
        public string N_NAME { get; set; }

        [StringLength(30)]
        public string V_NAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GEBOREN { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string abwadress { get; set; }

        [StringLength(5)]
        public string abwanrede { get; set; }

        [StringLength(15)]
        public string abwtitel { get; set; }

        [StringLength(30)]
        public string abwn_name { get; set; }

        [StringLength(30)]
        public string abwv_name { get; set; }

        [StringLength(30)]
        public string abwstrasse { get; set; }

        [StringLength(5)]
        public string abwplz { get; set; }

        [StringLength(30)]
        public string abwort { get; set; }

        [StringLength(30)]
        public string KASSE { get; set; }

        [StringLength(25)]
        public string KV_NUMMER { get; set; }

        [StringLength(10)]
        public string KV_STATUS { get; set; }

        [StringLength(25)]
        public string V_NUMMER { get; set; }

        [StringLength(20)]
        public string KLINIK { get; set; }

        [StringLength(20)]
        public string TELEFONP { get; set; }

        [StringLength(20)]
        public string TELEFONG { get; set; }

        [StringLength(20)]
        public string TELEFONM { get; set; }

        [StringLength(30)]
        public string STRASSE { get; set; }

        [StringLength(5)]
        public string LAND { get; set; }

        [StringLength(5)]
        public string PLZ { get; set; }

        [StringLength(30)]
        public string ORT { get; set; }

        [StringLength(30)]
        public string ARZT { get; set; }

        [StringLength(25)]
        public string ARZT_NUM { get; set; }

        [StringLength(20)]
        public string ATEL { get; set; }

        [StringLength(20)]
        public string AFAX { get; set; }

        public int? PAT_INTERN { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string BEFREIT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BEF_DAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ANL_DATUM { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string AKUTPAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AKUTDAT { get; set; }

        [StringLength(25)]
        public string AKUTBEH { get; set; }

        [StringLength(40)]
        public string TERMINE1 { get; set; }

        [StringLength(40)]
        public string TERMINE2 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string VIP_PAT { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string ER_JANEIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ER_DAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BEF_AB { get; set; }

        public decimal? NUMFREI1 { get; set; }

        public decimal? NUMFREI2 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string HEIMBEWOHN { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string ABSCHLUSS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AKUTBIS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATFREI2 { get; set; }

        [StringLength(10)]
        public string KILOMETER { get; set; }

        [StringLength(10)]
        public string CHARFREI2 { get; set; }

        [StringLength(40)]
        public string EMAILA { get; set; }

        public short? BEHDAUER { get; set; }

        public short? BER1 { get; set; }

        public short? BER2 { get; set; }

        public short? BER3 { get; set; }

        public short? BER4 { get; set; }

        [StringLength(30)]
        public string THERAPEUT { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string merk6 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string merk5 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string merk4 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string merk3 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string merk2 { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string merk1 { get; set; }

        [StringLength(1073741823)]
        public string aerzte { get; set; }

        [StringLength(1073741823)]
        public string pat_text { get; set; }

        [StringLength(1073741823)]
        public string anamnese { get; set; }

        public int id { get; set; }

        [StringLength(10)]
        public string arztid { get; set; }

        [StringLength(10)]
        public string kassenid { get; set; }

        [Column(TypeName = "char")]
        [StringLength(4)]
        public string JAHRFREI { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string U18IGNORE { get; set; }
    }
}
