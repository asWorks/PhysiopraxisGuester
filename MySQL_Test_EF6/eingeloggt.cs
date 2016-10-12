namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.eingeloggt")]
    public partial class eingeloggt
    {
        [Required]
        [StringLength(40)]
        public string comp { get; set; }

        [Required]
        [StringLength(50)]
        public string zeit { get; set; }

        [Required]
        [StringLength(10)]
        public string einaus { get; set; }

        public int id { get; set; }
    }
}
