namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.kollegen2")]
    public partial class kollegen2
    {
        [StringLength(10)]
        public string ANREDE { get; set; }

        [StringLength(30)]
        public string VORNAME { get; set; }

        [StringLength(30)]
        public string NACHNAME { get; set; }

        [StringLength(30)]
        public string STRASSE { get; set; }

        [StringLength(5)]
        public string PLZ { get; set; }

        [StringLength(30)]
        public string ORT { get; set; }

        [StringLength(25)]
        public string TELEFON1 { get; set; }

        [StringLength(25)]
        public string TELFON2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GEBOREN { get; set; }

        [StringLength(30)]
        public string matchcode { get; set; }

        [StringLength(1073741823)]
        public string ZTEXT { get; set; }

        public sbyte? KAL_TEIL { get; set; }

        public short? PERS_NR { get; set; }

        public decimal? ASTUNDEN { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string NICHT_ZEIG { get; set; }

        [StringLength(30)]
        public string ABTEILUNG { get; set; }

        public short? DEFTAKT { get; set; }

        public int? KALZEILE { get; set; }

        public int ID { get; set; }
    }
}
