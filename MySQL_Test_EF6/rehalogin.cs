namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.rehalogin")]
    public partial class rehalogin
    {
        public int id { get; set; }

        [StringLength(150)]
        public string user { get; set; }

        [StringLength(150)]
        public string password { get; set; }

        [StringLength(1073741823)]
        public string rights { get; set; }

        [StringLength(100)]
        public string email { get; set; }
    }
}
