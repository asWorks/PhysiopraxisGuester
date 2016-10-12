namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.todo")]
    public partial class todo
    {
        [StringLength(150)]
        public string absender { get; set; }

        [StringLength(150)]
        public string taskowner { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string empfaenger_person { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string empfaenger_gruppe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? versanddatum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? abgelehntdatum { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? gelesendatum { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string gelesen { get; set; }

        [StringLength(250)]
        public string betreff { get; set; }

        [StringLength(1073741823)]
        public string emailtext { get; set; }

        public byte[] attach1 { get; set; }

        public byte[] attach2 { get; set; }

        public byte[] attach3 { get; set; }

        [StringLength(250)]
        public string file1 { get; set; }

        [StringLength(250)]
        public string file2 { get; set; }

        [StringLength(250)]
        public string file3 { get; set; }

        public int id { get; set; }
    }
}
