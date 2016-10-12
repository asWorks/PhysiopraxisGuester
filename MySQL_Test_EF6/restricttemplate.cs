namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.restricttemplates")]
    public partial class restricttemplate
    {
        [Required]
        [StringLength(200)]
        public string abteilung { get; set; }

        [Required]
        [StringLength(1073741823)]
        public string sammlung { get; set; }

        public int id { get; set; }
    }
}
