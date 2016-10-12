namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.masntex2")]
    public partial class masntex2
    {
        [StringLength(100)]
        public string RMASSNAHME { get; set; }

        [StringLength(4)]
        public string SCHL1 { get; set; }

        [StringLength(1)]
        public string SCHL2 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte NINDEX { get; set; }
    }
}
