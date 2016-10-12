namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.poskuerzel")]
    public partial class poskuerzel
    {
        [Required]
        [StringLength(10)]
        public string DISZIPLIN { get; set; }

        [Required]
        [StringLength(10)]
        public string KUERZEL { get; set; }

        public int ID { get; set; }
    }
}
