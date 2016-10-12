namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.dta301")]
    public partial class dta301
    {
        [StringLength(20)]
        public string nachrichtentyp { get; set; }

        public int pat_intern { get; set; }

        [StringLength(25)]
        public string rez_nr { get; set; }

        [StringLength(20)]
        public string sender { get; set; }

        [StringLength(20)]
        public string receiver { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum { get; set; }

        [StringLength(20)]
        public string ktraeger { get; set; }

        [StringLength(20)]
        public string bearbeiter { get; set; }

        [StringLength(25)]
        public string aktenzeichen { get; set; }

        [StringLength(20)]
        public string funktionag { get; set; }

        [StringLength(20)]
        public string beauftragtestelle { get; set; }

        [StringLength(20)]
        public string versicherungsnr { get; set; }

        [StringLength(20)]
        public string vnranspruchsberechtigter { get; set; }

        [StringLength(20)]
        public string berechtigtennr { get; set; }

        [StringLength(20)]
        public string massnahmennr { get; set; }

        [StringLength(20)]
        public string geschlechtfamstand { get; set; }

        [StringLength(20)]
        public string national { get; set; }

        [StringLength(20)]
        public string artderleistung { get; set; }

        [StringLength(20)]
        public string diagschluessel { get; set; }

        [StringLength(20)]
        public string pnaab { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string auftragsleistung { get; set; }

        public int? lfnr { get; set; }

        [StringLength(1073741823)]
        public string edifact { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string patangaben { get; set; }

        [StringLength(5)]
        public string tage { get; set; }

        [StringLength(20)]
        public string eilfall { get; set; }

        [StringLength(20)]
        public string leistung { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string eingelesen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? eingelesenam { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string esol { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string pnabm { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string adr0 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string adr1 { get; set; }

        public int? berichtid { get; set; }

        public int id { get; set; }
    }
}
