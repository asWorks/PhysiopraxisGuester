namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.masntext")]
    public partial class masntext
    {
        [StringLength(100)]
        public string RMASSNAHME { get; set; }

        [StringLength(3)]
        public string SCHL1 { get; set; }

        [StringLength(2)]
        public string SCHL2 { get; set; }

        [Key]
        public sbyte NINDEX { get; set; }
    }
}
