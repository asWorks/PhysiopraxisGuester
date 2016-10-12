namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.icd10")]
    public partial class icd10
    {
        [Required]
        [StringLength(10)]
        public string schluessel1 { get; set; }

        [Required]
        [StringLength(10)]
        public string schluessel2 { get; set; }

        [Required]
        [StringLength(100)]
        public string titelzeile { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string icdtext { get; set; }

        public int id { get; set; }
    }
}
