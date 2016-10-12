namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.fertige")]
    public partial class fertige
    {
        [Required]
        [StringLength(9)]
        public string ikktraeger { get; set; }

        [Required]
        [StringLength(9)]
        public string ikkasse { get; set; }

        [Required]
        [StringLength(30)]
        public string name1 { get; set; }

        [Required]
        [StringLength(25)]
        public string rez_nr { get; set; }

        public int pat_intern { get; set; }

        [Required]
        [StringLength(2)]
        public string rezklasse { get; set; }

        [Required]
        [StringLength(9)]
        public string idktraeger { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string edifact { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string ediok { get; set; }

        public int id { get; set; }
    }
}
