namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.dtafall")]
    public partial class dtafall
    {
        [StringLength(40)]
        public string nachrichttyp { get; set; }

        public int? nachrichtart { get; set; }

        public int? pat_intern { get; set; }

        [StringLength(25)]
        public string rez_nr { get; set; }

        [Column(TypeName = "date")]
        public DateTime? nachrichtdatum { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string nachrichtorg { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string nachrichtauf { get; set; }

        [StringLength(30)]
        public string bearbeiter { get; set; }

        [StringLength(20)]
        public string esolname { get; set; }

        [StringLength(10)]
        public string icr { get; set; }

        public int id { get; set; }
    }
}
