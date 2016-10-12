namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.berhist")]
    public partial class berhist
    {
        [StringLength(25)]
        public string PAT_INTERN { get; set; }

        public int? BERICHTID { get; set; }

        [StringLength(30)]
        public string BERICHTTYP { get; set; }

        [StringLength(30)]
        public string VERFASSER { get; set; }

        [StringLength(30)]
        public string EMPFAENGER { get; set; }

        [StringLength(40)]
        public string BERTITEL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ERSTELLDAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EDITDAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VERSANDDAT { get; set; }

        [StringLength(50)]
        public string DATEINAME { get; set; }

        public int EMPFID { get; set; }

        public int id { get; set; }
    }
}
