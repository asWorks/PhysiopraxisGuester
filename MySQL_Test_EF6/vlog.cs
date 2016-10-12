namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.vlog")]
    public partial class vlog
    {
        [StringLength(20)]
        public string datum { get; set; }

        [StringLength(40)]
        public string benutzer { get; set; }

        [StringLength(150)]
        public string maschine { get; set; }

        [StringLength(40)]
        public string tkspalte { get; set; }

        [StringLength(20)]
        public string vname { get; set; }

        [StringLength(20)]
        public string vreznr { get; set; }

        [StringLength(5)]
        public string vdauer { get; set; }

        [StringLength(10)]
        public string vstart { get; set; }

        [StringLength(10)]
        public string vend { get; set; }

        [StringLength(20)]
        public string nname { get; set; }

        [StringLength(20)]
        public string nreznr { get; set; }

        [StringLength(5)]
        public string ndauer { get; set; }

        [StringLength(10)]
        public string nstart { get; set; }

        [StringLength(10)]
        public string nend { get; set; }

        public int id { get; set; }
    }
}
