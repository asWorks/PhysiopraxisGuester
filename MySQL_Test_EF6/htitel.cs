namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.htitel")]
    public partial class htitel
    {
        public int id { get; set; }

        [StringLength(150)]
        public string titel { get; set; }

        [StringLength(100)]
        public string datei { get; set; }

        [StringLength(100)]
        public string gruppe { get; set; }

        [StringLength(1073741823)]
        public string inhalt { get; set; }

        public sbyte? bilder { get; set; }

        public int? reihenfolg { get; set; }

        [Column(TypeName = "date")]
        public DateTime lastedit { get; set; }
    }
}
