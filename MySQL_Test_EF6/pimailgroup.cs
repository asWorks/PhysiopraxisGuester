namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.pimailgroup")]
    public partial class pimailgroup
    {
        [StringLength(50)]
        public string groupname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string groupmembers { get; set; }

        public int id { get; set; }
    }
}
