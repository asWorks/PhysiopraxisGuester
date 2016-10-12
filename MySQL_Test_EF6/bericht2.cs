namespace MySQL_Test_EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("guester_neu.bericht2")]
    public partial class bericht2
    {
        [StringLength(25)]
        public string PAT_INTERN { get; set; }

        public int? BERICHTID { get; set; }

        [StringLength(15)]
        public string VNUMMER { get; set; }

        [StringLength(60)]
        public string NAMEVOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GEBOREN { get; set; }

        [StringLength(35)]
        public string STRASSE { get; set; }

        [StringLength(5)]
        public string PLZ { get; set; }

        [StringLength(35)]
        public string ORT { get; set; }

        [StringLength(60)]
        public string VNAMEVO { get; set; }

        [StringLength(5)]
        public string MSNR { get; set; }

        [StringLength(5)]
        public string BNR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AUFDAT1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENTDAT1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AUFDAT2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENTDAT2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AUFDAT3 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENTDAT3 { get; set; }

        [StringLength(1)]
        public string ENTFORM { get; set; }

        [StringLength(1)]
        public string ARBFAE { get; set; }

        [StringLength(1073741823)]
        public string DIAG1 { get; set; }

        [StringLength(5)]
        public string F_74 { get; set; }

        [StringLength(1)]
        public string F_79 { get; set; }

        [StringLength(1)]
        public string F_80 { get; set; }

        [StringLength(1)]
        public string F_81 { get; set; }

        [StringLength(1073741823)]
        public string DIAG2 { get; set; }

        [StringLength(5)]
        public string F_82 { get; set; }

        [StringLength(1)]
        public string F_87 { get; set; }

        [StringLength(1)]
        public string F_88 { get; set; }

        [StringLength(1)]
        public string F_89 { get; set; }

        [StringLength(1073741823)]
        public string DIAG3 { get; set; }

        [StringLength(5)]
        public string F_90 { get; set; }

        [StringLength(1)]
        public string F_95 { get; set; }

        [StringLength(1)]
        public string F_96 { get; set; }

        [StringLength(1)]
        public string F_97 { get; set; }

        [StringLength(1073741823)]
        public string DIAG4 { get; set; }

        [StringLength(5)]
        public string F_98 { get; set; }

        [StringLength(1)]
        public string F_103 { get; set; }

        [StringLength(1)]
        public string F_104 { get; set; }

        [StringLength(1)]
        public string F_105 { get; set; }

        [StringLength(1073741823)]
        public string DIAG5 { get; set; }

        [StringLength(5)]
        public string F_106 { get; set; }

        [StringLength(1)]
        public string F_111 { get; set; }

        [StringLength(1)]
        public string F_112 { get; set; }

        [StringLength(1)]
        public string F_113 { get; set; }

        [StringLength(3)]
        public string F_114 { get; set; }

        [StringLength(3)]
        public string F_117 { get; set; }

        [StringLength(3)]
        public string F_120 { get; set; }

        [StringLength(1)]
        public string F_123 { get; set; }

        [StringLength(1)]
        public string F_124 { get; set; }

        [StringLength(1)]
        public string F_125 { get; set; }

        [StringLength(1)]
        public string F_126 { get; set; }

        [StringLength(1)]
        public string F_127 { get; set; }

        [StringLength(1)]
        public string F_128 { get; set; }

        [StringLength(1)]
        public string F_129 { get; set; }

        [StringLength(1)]
        public string F_130 { get; set; }

        [StringLength(1)]
        public string F_131 { get; set; }

        [StringLength(1)]
        public string F_132 { get; set; }

        [StringLength(1)]
        public string F_133 { get; set; }

        [StringLength(1)]
        public string F_134 { get; set; }

        [StringLength(1)]
        public string F_135 { get; set; }

        [StringLength(1)]
        public string F_136 { get; set; }

        [StringLength(1)]
        public string F_137 { get; set; }

        [StringLength(1)]
        public string F_138 { get; set; }

        [StringLength(1)]
        public string F_139 { get; set; }

        [StringLength(1)]
        public string F_140 { get; set; }

        [StringLength(1)]
        public string F_141 { get; set; }

        [StringLength(1073741823)]
        public string ERLAEUT { get; set; }

        [StringLength(1073741823)]
        public string LMEDIKAT { get; set; }

        [StringLength(70)]
        public string TAET { get; set; }

        [StringLength(7)]
        public string BKS { get; set; }

        [StringLength(1)]
        public string F_153 { get; set; }

        [StringLength(1)]
        public string F_154 { get; set; }

        [StringLength(1)]
        public string F_156 { get; set; }

        [StringLength(1)]
        public string F_157 { get; set; }

        [StringLength(1)]
        public string F_158 { get; set; }

        [StringLength(1)]
        public string F_159 { get; set; }

        [StringLength(1)]
        public string F_160 { get; set; }

        [StringLength(1)]
        public string F_161 { get; set; }

        [StringLength(1)]
        public string F_162 { get; set; }

        [StringLength(1)]
        public string F_163 { get; set; }

        [StringLength(1)]
        public string F_164 { get; set; }

        [StringLength(1)]
        public string F_165 { get; set; }

        [StringLength(1)]
        public string F_166 { get; set; }

        [StringLength(1)]
        public string F_167 { get; set; }

        [StringLength(1)]
        public string F_168 { get; set; }

        [StringLength(1)]
        public string F_169 { get; set; }

        [StringLength(1)]
        public string F_170 { get; set; }

        [StringLength(1)]
        public string F_171 { get; set; }

        [StringLength(1)]
        public string F_172 { get; set; }

        [StringLength(1)]
        public string F_173 { get; set; }

        [StringLength(1)]
        public string F_174 { get; set; }

        [StringLength(1)]
        public string F_175 { get; set; }

        [StringLength(1)]
        public string F_176 { get; set; }

        [StringLength(1)]
        public string F_177 { get; set; }

        [StringLength(1073741823)]
        public string LEISTBI { get; set; }

        [StringLength(1)]
        public string F_178 { get; set; }

        [StringLength(1)]
        public string F_179 { get; set; }

        [StringLength(1)]
        public string F_181 { get; set; }

        [StringLength(1073741823)]
        public string TERLEUT { get; set; }

        [StringLength(1073741823)]
        public string FREITEXT { get; set; }

        public sbyte? TMA1 { get; set; }

        public sbyte? TMA2 { get; set; }

        public sbyte? TMA3 { get; set; }

        public sbyte? TMA4 { get; set; }

        public sbyte? TMA5 { get; set; }

        public sbyte? TMA6 { get; set; }

        public sbyte? TMA7 { get; set; }

        public sbyte? TMA8 { get; set; }

        public sbyte? TMA9 { get; set; }

        public sbyte? TMA10 { get; set; }

        public sbyte? TMA11 { get; set; }

        public sbyte? TMA12 { get; set; }

        public sbyte? TMA13 { get; set; }

        public sbyte? TMA14 { get; set; }

        public sbyte? TMA15 { get; set; }

        public sbyte? TMA16 { get; set; }

        public sbyte? TMA17 { get; set; }

        public sbyte? TMA18 { get; set; }

        public sbyte? TMA19 { get; set; }

        public sbyte? TMA20 { get; set; }

        public sbyte? TMA21 { get; set; }

        public sbyte? TMA22 { get; set; }

        public sbyte? TMA23 { get; set; }

        public sbyte? TMA24 { get; set; }

        public sbyte? TMA25 { get; set; }

        [StringLength(2)]
        public string TAZ1 { get; set; }

        [StringLength(2)]
        public string TAZ2 { get; set; }

        [StringLength(2)]
        public string TAZ3 { get; set; }

        [StringLength(2)]
        public string TAZ4 { get; set; }

        [StringLength(2)]
        public string TAZ5 { get; set; }

        [StringLength(2)]
        public string TAZ6 { get; set; }

        [StringLength(2)]
        public string TAZ7 { get; set; }

        [StringLength(2)]
        public string TAZ8 { get; set; }

        [StringLength(2)]
        public string TAZ9 { get; set; }

        [StringLength(2)]
        public string TAZ10 { get; set; }

        [StringLength(2)]
        public string TAZ11 { get; set; }

        [StringLength(2)]
        public string TAZ12 { get; set; }

        [StringLength(2)]
        public string TAZ13 { get; set; }

        [StringLength(2)]
        public string TAZ14 { get; set; }

        [StringLength(2)]
        public string TAZ15 { get; set; }

        [StringLength(2)]
        public string TAZ16 { get; set; }

        [StringLength(2)]
        public string TAZ17 { get; set; }

        [StringLength(2)]
        public string TAZ18 { get; set; }

        [StringLength(2)]
        public string TAZ19 { get; set; }

        [StringLength(2)]
        public string TAZ20 { get; set; }

        [StringLength(2)]
        public string TAZ21 { get; set; }

        [StringLength(2)]
        public string TAZ22 { get; set; }

        [StringLength(2)]
        public string TAZ23 { get; set; }

        [StringLength(2)]
        public string TAZ24 { get; set; }

        [StringLength(2)]
        public string TAZ25 { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string LSEITE1 { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string LSEITE3 { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string LSEITE4 { get; set; }

        [StringLength(4)]
        public string AIGR { get; set; }

        [StringLength(4)]
        public string ABTEILUNG { get; set; }

        [StringLength(1)]
        public string DMP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UNTDAT { get; set; }

        public int id { get; set; }

        [StringLength(30)]
        public string arzt1 { get; set; }

        [StringLength(30)]
        public string arzt2 { get; set; }

        [StringLength(30)]
        public string arzt3 { get; set; }

        [StringLength(1073741823)]
        public string DIAG6 { get; set; }
    }
}
