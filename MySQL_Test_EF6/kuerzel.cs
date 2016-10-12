namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.kuerzel")]
    public partial class kuerzel
    {
        [Required]
        [StringLength(35)]
        public string leistung { get; set; }

        [Column("kuerzel")]
        [Required]
        [StringLength(10)]
        public string kuerzel1 { get; set; }

        [Required]
        [StringLength(2)]
        public string disziplin { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string vorrangig { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string extraok { get; set; }

        public int id { get; set; }
    }
}
