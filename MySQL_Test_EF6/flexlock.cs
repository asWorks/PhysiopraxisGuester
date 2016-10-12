namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.flexlock")]
    public partial class flexlock
    {
        [Key]
        [StringLength(25)]
        public string sperre { get; set; }

        [StringLength(50)]
        public string maschine { get; set; }

        [StringLength(50)]
        public string zeit { get; set; }

        public int sperrid { get; set; }
    }
}
