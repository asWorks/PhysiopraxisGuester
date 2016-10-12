namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.ktraeger")]
    public partial class ktraeger
    {
        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ikkasse { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ikkostentraeger { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ikpapier { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ikdaten { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(9)]
        public string ikentschluesselung { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string name1 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string name2 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string name3 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string adresse1 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string adresse2 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(30)]
        public string adresse3 { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string email { get; set; }

        public int id { get; set; }
    }
}
