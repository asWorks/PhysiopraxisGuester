namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.feiertage")]
    public partial class feiertage
    {
        [StringLength(10)]
        public string datdeutsch { get; set; }

        [StringLength(10)]
        public string datsql { get; set; }

        [StringLength(40)]
        public string feiertag { get; set; }

        [StringLength(40)]
        public string buland { get; set; }

        public int? jahr { get; set; }

        public int id { get; set; }
    }
}
