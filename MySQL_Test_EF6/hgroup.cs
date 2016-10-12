namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.hgroup")]
    public partial class hgroup
    {
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string gruppe { get; set; }

        public int? reihenfolge { get; set; }
    }
}
