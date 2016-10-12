namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.rtadoku")]
    public partial class rtadoku
    {
        public int? DOKUID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATUM { get; set; }

        [StringLength(1073741823)]
        public string DOKUTITEL { get; set; }

        [StringLength(20)]
        public string BENUTZER { get; set; }

        public int? PAT_INTERN { get; set; }

        [StringLength(100)]
        public string DATEI { get; set; }

        public int Format { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string DOKUTEXT { get; set; }

        [Required]
        public byte[] DOKUBLOB { get; set; }

        public int groesse { get; set; }

        public int id { get; set; }
    }
}
