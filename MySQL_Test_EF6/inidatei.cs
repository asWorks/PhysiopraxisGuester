namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.inidatei")]
    public partial class inidatei
    {
        [StringLength(250)]
        public string dateiname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string inhalt { get; set; }

        public int id { get; set; }
    }
}
