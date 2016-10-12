namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.tbpo")]
    public partial class tbpo
    {
        [StringLength(2)]
        public string TBKLASSE { get; set; }

        [StringLength(40)]
        public string TBTHEMA { get; set; }

        [StringLength(15)]
        public string TBABSATZ { get; set; }

        public sbyte? TBBLOCK { get; set; }

        [StringLength(15)]
        public string TBOBER { get; set; }

        [StringLength(2)]
        public string TBRANG { get; set; }

        [StringLength(150)]
        public string TBTITEL { get; set; }

        [StringLength(1073741823)]
        public string TBTEXT { get; set; }

        public int id { get; set; }
    }
}
