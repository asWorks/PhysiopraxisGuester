namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.patbild")]
    public partial class patbild
    {
        public int id { get; set; }

        public int pat_intern { get; set; }

        public byte[] bild { get; set; }

        [Column(TypeName = "blob")]
        public byte[] vorschau { get; set; }
    }
}
