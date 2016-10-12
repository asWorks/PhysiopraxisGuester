namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.hmrcheck")]
    public partial class hmrcheck
    {
        [StringLength(5)]
        public string indischluessel { get; set; }

        public short gesamt { get; set; }

        public short maxrezept { get; set; }

        [StringLength(1073741823)]
        public string vorrangig { get; set; }

        [StringLength(1073741823)]
        public string maxvorrangig { get; set; }

        [StringLength(1073741823)]
        public string ergaenzend { get; set; }

        [StringLength(1073741823)]
        public string maxergaenzend { get; set; }

        public int id { get; set; }
    }
}
