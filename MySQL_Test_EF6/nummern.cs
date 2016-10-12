namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.nummern")]
    public partial class nummern
    {
        public int pat { get; set; }

        public int kg { get; set; }

        public int ma { get; set; }

        public int er { get; set; }

        public int lo { get; set; }

        public int rh { get; set; }

        public int po { get; set; }

        public int rnr { get; set; }

        public int esol { get; set; }

        public int bericht { get; set; }

        public int afrnr { get; set; }

        public int rgrnr { get; set; }

        public int doku { get; set; }

        public int dfue { get; set; }

        [StringLength(9)]
        public string mandant { get; set; }

        public int vbon { get; set; }

        public int vrechnung { get; set; }

        public int id { get; set; }
    }
}
