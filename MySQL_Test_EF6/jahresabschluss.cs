namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.jahresabschluss")]
    public partial class jahresabschluss
    {
        [StringLength(4)]
        public string altesjahr { get; set; }

        [Column(TypeName = "date")]
        public DateTime? umgestellt { get; set; }

        public int id { get; set; }
    }
}
