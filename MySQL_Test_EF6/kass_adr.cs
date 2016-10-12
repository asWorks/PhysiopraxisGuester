namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.kass_adr")]
    public partial class kass_adr
    {
        [StringLength(6)]
        public string KUERZEL { get; set; }

        [StringLength(2)]
        public string PREISGRUPPE { get; set; }

        [StringLength(60)]
        public string kassen_nam1 { get; set; }

        [StringLength(60)]
        public string kassen_nam2 { get; set; }

        [StringLength(30)]
        public string STRASSE { get; set; }

        [StringLength(5)]
        public string PLZ { get; set; }

        [StringLength(30)]
        public string ORT { get; set; }

        [StringLength(20)]
        public string POSTFACH { get; set; }

        [StringLength(15)]
        public string FAX { get; set; }

        [StringLength(20)]
        public string TELEFON { get; set; }

        [StringLength(15)]
        public string IK_NUM { get; set; }

        [StringLength(25)]
        public string KV_NUMMER { get; set; }

        [StringLength(25)]
        public string MATCHCODE { get; set; }

        [StringLength(1073741823)]
        public string KMEMO { get; set; }

        [StringLength(6)]
        public string RECHNUNG { get; set; }

        [StringLength(15)]
        public string IK_KASSE { get; set; }

        [StringLength(15)]
        public string IK_PHYSIKA { get; set; }

        [StringLength(15)]
        public string IK_NUTZER { get; set; }

        [StringLength(15)]
        public string IK_KOSTENT { get; set; }

        [StringLength(15)]
        public string IK_KVKARTE { get; set; }

        [StringLength(15)]
        public string IK_PAPIER { get; set; }

        [StringLength(30)]
        public string EMAIL1 { get; set; }

        [StringLength(30)]
        public string EMAIL2 { get; set; }

        [StringLength(30)]
        public string EMAIL3 { get; set; }

        public int id { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string HMRABRECHNUNG { get; set; }

        [StringLength(2)]
        public string PGKG { get; set; }

        [StringLength(2)]
        public string PGMA { get; set; }

        [StringLength(2)]
        public string PGER { get; set; }

        [StringLength(2)]
        public string PGLO { get; set; }

        [StringLength(2)]
        public string PGRH { get; set; }

        [StringLength(2)]
        public string PGPO { get; set; }
    }
}
