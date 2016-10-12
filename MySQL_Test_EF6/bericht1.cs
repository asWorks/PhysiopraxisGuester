namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.bericht1")]
    public partial class bericht1
    {
        [StringLength(25)]
        public string PAT_INTERN { get; set; }

        public int? BERICHTID { get; set; }

        [StringLength(25)]
        public string ARZT_NUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ERSTELLDAT { get; set; }

        [StringLength(10)]
        public string VERSANDART { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VERSANDDAT { get; set; }

        [StringLength(10)]
        public string BERTYP { get; set; }

        [StringLength(1073741823)]
        public string BERSTAND { get; set; }

        [StringLength(1073741823)]
        public string BERBESO { get; set; }

        [StringLength(1073741823)]
        public string BERPROG { get; set; }

        [StringLength(1073741823)]
        public string BERVORS { get; set; }

        [StringLength(1073741823)]
        public string DIAGNOSE { get; set; }

        [StringLength(25)]
        public string KRBILD { get; set; }

        [StringLength(30)]
        public string VERFASSER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REZ_DATUM { get; set; }

        public int id { get; set; }
    }
}
