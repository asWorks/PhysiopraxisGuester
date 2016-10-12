namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.wecker")]
    public partial class wecker
    {
        [StringLength(40)]
        public string n_name { get; set; }

        [StringLength(20)]
        public string behandlung { get; set; }

        [StringLength(20)]
        public string raum { get; set; }

        [StringLength(8)]
        public string fertig { get; set; }

        [StringLength(8)]
        public string registriert { get; set; }

        [StringLength(50)]
        public string registervon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum { get; set; }

        public int id { get; set; }
    }
}
