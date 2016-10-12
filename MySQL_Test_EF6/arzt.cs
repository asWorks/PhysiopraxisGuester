namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.arzt")]
    public partial class arzt
    {
        [StringLength(25)]
        public string ANREDE { get; set; }

        [StringLength(15)]
        public string TITEL { get; set; }

        [StringLength(80)]
        public string NACHNAME { get; set; }

        [StringLength(30)]
        public string VORNAME { get; set; }

        [StringLength(30)]
        public string STRASSE { get; set; }

        [StringLength(6)]
        public string PLZ { get; set; }

        [StringLength(20)]
        public string ORT { get; set; }

        [StringLength(50)]
        public string FACHARZT { get; set; }

        [StringLength(20)]
        public string TELEFON { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(25)]
        public string MATCHCODE { get; set; }

        [StringLength(15)]
        public string ARZTNUM { get; set; }

        [StringLength(40)]
        public string KLINIK { get; set; }

        [StringLength(1073741823)]
        public string MTEXT { get; set; }

        [StringLength(40)]
        public string EMAIL1 { get; set; }

        [StringLength(40)]
        public string EMAIL2 { get; set; }

        public int id { get; set; }

        [StringLength(15)]
        public string BSNR { get; set; }
    }
}
