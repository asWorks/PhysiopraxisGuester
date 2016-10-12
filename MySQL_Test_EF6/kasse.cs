namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.kasse")]
    public partial class kasse
    {
        public decimal? EINNAHME { get; set; }

        public decimal? AUSGABE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATUM { get; set; }

        [StringLength(35)]
        public string KTEXT { get; set; }

        [StringLength(20)]
        public string KTO { get; set; }

        public decimal? KSTAND { get; set; }

        public int id { get; set; }

        public int PAT_INTERN { get; set; }

        [Required]
        [StringLength(25)]
        public string REZ_NR { get; set; }

        [StringLength(30)]
        public string USER { get; set; }

        [StringLength(9)]
        public string IK { get; set; }
    }
}
