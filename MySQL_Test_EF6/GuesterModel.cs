namespace MySQL_Test_EF6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GuesterModel : DbContext
    {
        public GuesterModel()
            : base("name=GuesterModel")
        {
        }

        public virtual DbSet<adrgenehmigung> adrgenehmigungs { get; set; }
        public virtual DbSet<allepreise> allepreises { get; set; }
        public virtual DbSet<arzt> arzts { get; set; }
        public virtual DbSet<berhist> berhists { get; set; }
        public virtual DbSet<bericht1> bericht1 { get; set; }
        public virtual DbSet<bericht2> bericht2 { get; set; }
        public virtual DbSet<bericht2ktl> bericht2ktl { get; set; }
        public virtual DbSet<berlock> berlocks { get; set; }
        public virtual DbSet<doku1> doku1 { get; set; }
        public virtual DbSet<dta301> dta301 { get; set; }
        public virtual DbSet<dtafall> dtafalls { get; set; }
        public virtual DbSet<dtatypen> dtatypens { get; set; }
        public virtual DbSet<edifact> edifacts { get; set; }
        public virtual DbSet<eingeloggt> eingeloggts { get; set; }
        public virtual DbSet<ertarif> ertarifs { get; set; }
        public virtual DbSet<ertarif1> ertarif1 { get; set; }
        public virtual DbSet<ertarif10> ertarif10 { get; set; }
        public virtual DbSet<ertarif11> ertarif11 { get; set; }
        public virtual DbSet<ertarif12> ertarif12 { get; set; }
        public virtual DbSet<ertarif2> ertarif2 { get; set; }
        public virtual DbSet<ertarif3> ertarif3 { get; set; }
        public virtual DbSet<ertarif4> ertarif4 { get; set; }
        public virtual DbSet<ertarif5> ertarif5 { get; set; }
        public virtual DbSet<ertarif6> ertarif6 { get; set; }
        public virtual DbSet<ertarif7> ertarif7 { get; set; }
        public virtual DbSet<ertarif8> ertarif8 { get; set; }
        public virtual DbSet<ertarif9> ertarif9 { get; set; }
        public virtual DbSet<faktura> fakturas { get; set; }
        public virtual DbSet<feiertage> feiertages { get; set; }
        public virtual DbSet<fertige> fertiges { get; set; }
        public virtual DbSet<flexkc> flexkcs { get; set; }
        public virtual DbSet<flexlock> flexlocks { get; set; }
        public virtual DbSet<hgroup> hgroups { get; set; }
        public virtual DbSet<hmrcheck> hmrchecks { get; set; }
        public virtual DbSet<htitel> htitels { get; set; }
        public virtual DbSet<icd10> icd10 { get; set; }
        public virtual DbSet<inidatei> inidateis { get; set; }
        public virtual DbSet<jahresabschluss> jahresabschlusses { get; set; }
        public virtual DbSet<kass_adr> kass_adr { get; set; }
        public virtual DbSet<kasse> kasses { get; set; }
        public virtual DbSet<kb_2016> kb_2016 { get; set; }
        public virtual DbSet<kb_bey> kb_bey { get; set; }
        public virtual DbSet<kgtarif> kgtarifs { get; set; }
        public virtual DbSet<kgtarif1> kgtarif1 { get; set; }
        public virtual DbSet<kgtarif10> kgtarif10 { get; set; }
        public virtual DbSet<kgtarif11> kgtarif11 { get; set; }
        public virtual DbSet<kgtarif12> kgtarif12 { get; set; }
        public virtual DbSet<kgtarif2> kgtarif2 { get; set; }
        public virtual DbSet<kgtarif3> kgtarif3 { get; set; }
        public virtual DbSet<kgtarif4> kgtarif4 { get; set; }
        public virtual DbSet<kgtarif5> kgtarif5 { get; set; }
        public virtual DbSet<kgtarif6> kgtarif6 { get; set; }
        public virtual DbSet<kgtarif7> kgtarif7 { get; set; }
        public virtual DbSet<kgtarif8> kgtarif8 { get; set; }
        public virtual DbSet<kgtarif9> kgtarif9 { get; set; }
        public virtual DbSet<kollegen2> kollegen2 { get; set; }
        public virtual DbSet<ktraeger> ktraegers { get; set; }
        public virtual DbSet<kuerzel> kuerzels { get; set; }
        public virtual DbSet<lotarif> lotarifs { get; set; }
        public virtual DbSet<lotarif1> lotarif1 { get; set; }
        public virtual DbSet<lotarif10> lotarif10 { get; set; }
        public virtual DbSet<lotarif11> lotarif11 { get; set; }
        public virtual DbSet<lotarif12> lotarif12 { get; set; }
        public virtual DbSet<lotarif2> lotarif2 { get; set; }
        public virtual DbSet<lotarif3> lotarif3 { get; set; }
        public virtual DbSet<lotarif4> lotarif4 { get; set; }
        public virtual DbSet<lotarif5> lotarif5 { get; set; }
        public virtual DbSet<lotarif6> lotarif6 { get; set; }
        public virtual DbSet<lotarif7> lotarif7 { get; set; }
        public virtual DbSet<lotarif8> lotarif8 { get; set; }
        public virtual DbSet<lotarif9> lotarif9 { get; set; }
        public virtual DbSet<lza> lzas { get; set; }
        public virtual DbSet<masntex2> masntex2 { get; set; }
        public virtual DbSet<masntext> masntexts { get; set; }
        public virtual DbSet<matarif> matarifs { get; set; }
        public virtual DbSet<matarif1> matarif1 { get; set; }
        public virtual DbSet<matarif10> matarif10 { get; set; }
        public virtual DbSet<matarif11> matarif11 { get; set; }
        public virtual DbSet<matarif12> matarif12 { get; set; }
        public virtual DbSet<matarif2> matarif2 { get; set; }
        public virtual DbSet<matarif3> matarif3 { get; set; }
        public virtual DbSet<matarif4> matarif4 { get; set; }
        public virtual DbSet<matarif5> matarif5 { get; set; }
        public virtual DbSet<matarif6> matarif6 { get; set; }
        public virtual DbSet<matarif7> matarif7 { get; set; }
        public virtual DbSet<matarif8> matarif8 { get; set; }
        public virtual DbSet<matarif9> matarif9 { get; set; }
        public virtual DbSet<nummern> nummerns { get; set; }
        public virtual DbSet<pat5> pat5 { get; set; }
        public virtual DbSet<patbild> patbilds { get; set; }
        public virtual DbSet<pimail> pimails { get; set; }
        public virtual DbSet<pimailgroup> pimailgroups { get; set; }
        public virtual DbSet<poskuerzel> poskuerzels { get; set; }
        public virtual DbSet<potarif1> potarif1 { get; set; }
        public virtual DbSet<potarif10> potarif10 { get; set; }
        public virtual DbSet<potarif11> potarif11 { get; set; }
        public virtual DbSet<potarif12> potarif12 { get; set; }
        public virtual DbSet<potarif2> potarif2 { get; set; }
        public virtual DbSet<potarif3> potarif3 { get; set; }
        public virtual DbSet<potarif4> potarif4 { get; set; }
        public virtual DbSet<potarif5> potarif5 { get; set; }
        public virtual DbSet<potarif6> potarif6 { get; set; }
        public virtual DbSet<potarif7> potarif7 { get; set; }
        public virtual DbSet<potarif8> potarif8 { get; set; }
        public virtual DbSet<potarif9> potarif9 { get; set; }
        public virtual DbSet<rehalogin> rehalogins { get; set; }
        public virtual DbSet<restricttemplate> restricttemplates { get; set; }
        public virtual DbSet<rgaffaktura> rgaffakturas { get; set; }
        public virtual DbSet<rhtarif> rhtarifs { get; set; }
        public virtual DbSet<rhtarif1> rhtarif1 { get; set; }
        public virtual DbSet<rhtarif10> rhtarif10 { get; set; }
        public virtual DbSet<rhtarif11> rhtarif11 { get; set; }
        public virtual DbSet<rhtarif12> rhtarif12 { get; set; }
        public virtual DbSet<rhtarif2> rhtarif2 { get; set; }
        public virtual DbSet<rhtarif3> rhtarif3 { get; set; }
        public virtual DbSet<rhtarif4> rhtarif4 { get; set; }
        public virtual DbSet<rhtarif5> rhtarif5 { get; set; }
        public virtual DbSet<rhtarif6> rhtarif6 { get; set; }
        public virtual DbSet<rhtarif7> rhtarif7 { get; set; }
        public virtual DbSet<rhtarif8> rhtarif8 { get; set; }
        public virtual DbSet<rhtarif9> rhtarif9 { get; set; }
        public virtual DbSet<rliste> rlistes { get; set; }
        public virtual DbSet<rtadoku> rtadokus { get; set; }
        public virtual DbSet<tbar> tbars { get; set; }
        public virtual DbSet<tber> tbers { get; set; }
        public virtual DbSet<tbkg> tbkgs { get; set; }
        public virtual DbSet<tblo> tbloes { get; set; }
        public virtual DbSet<tbma> tbmas { get; set; }
        public virtual DbSet<tbpo> tbpoes { get; set; }
        public virtual DbSet<tbrh> tbrhs { get; set; }
        public virtual DbSet<todo> todoes { get; set; }
        public virtual DbSet<urlaub> urlaubs { get; set; }
        public virtual DbSet<urlaub2010> urlaub2010 { get; set; }
        public virtual DbSet<urlaub2014> urlaub2014 { get; set; }
        public virtual DbSet<verkartikel> verkartikels { get; set; }
        public virtual DbSet<verkfaktura> verkfakturas { get; set; }
        public virtual DbSet<verklieferant> verklieferants { get; set; }
        public virtual DbSet<verkliste> verklistes { get; set; }
        public virtual DbSet<verordn> verordns { get; set; }
        public virtual DbSet<vlog> vlogs { get; set; }
        public virtual DbSet<volle> volles { get; set; }
        public virtual DbSet<vpreise> vpreises { get; set; }
        public virtual DbSet<wecker> weckers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<adrgenehmigung>()
                .Property(e => e.ik)
                .IsUnicode(false);

            modelBuilder.Entity<allepreise>()
                .Property(e => e.disziplin)
                .IsUnicode(false);

            modelBuilder.Entity<allepreise>()
                .Property(e => e.buland)
                .IsUnicode(false);

            modelBuilder.Entity<allepreise>()
                .Property(e => e.preisgruppe)
                .IsUnicode(false);

            modelBuilder.Entity<allepreise>()
                .Property(e => e.posnr)
                .IsUnicode(false);

            modelBuilder.Entity<allepreise>()
                .Property(e => e.langtext)
                .IsUnicode(false);

            modelBuilder.Entity<allepreise>()
                .Property(e => e.bundesweit)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.ANREDE)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.TITEL)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.NACHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.VORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.STRASSE)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.PLZ)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.ORT)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.FACHARZT)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.MATCHCODE)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.ARZTNUM)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.KLINIK)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.MTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<arzt>()
                .Property(e => e.BSNR)
                .IsUnicode(false);

            modelBuilder.Entity<berhist>()
                .Property(e => e.PAT_INTERN)
                .IsUnicode(false);

            modelBuilder.Entity<berhist>()
                .Property(e => e.BERICHTTYP)
                .IsUnicode(false);

            modelBuilder.Entity<berhist>()
                .Property(e => e.VERFASSER)
                .IsUnicode(false);

            modelBuilder.Entity<berhist>()
                .Property(e => e.EMPFAENGER)
                .IsUnicode(false);

            modelBuilder.Entity<berhist>()
                .Property(e => e.BERTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<berhist>()
                .Property(e => e.DATEINAME)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.PAT_INTERN)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.ARZT_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.VERSANDART)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.BERTYP)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.BERSTAND)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.BERBESO)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.BERPROG)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.BERVORS)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.DIAGNOSE)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.KRBILD)
                .IsUnicode(false);

            modelBuilder.Entity<bericht1>()
                .Property(e => e.VERFASSER)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.PAT_INTERN)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.VNUMMER)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.NAMEVOR)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.STRASSE)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.PLZ)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.ORT)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.VNAMEVO)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.MSNR)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.BNR)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.ENTFORM)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.ARBFAE)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DIAG1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_74)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_79)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_80)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_81)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DIAG2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_82)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_87)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_88)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_89)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DIAG3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_90)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_95)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_96)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_97)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DIAG4)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_98)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_103)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_104)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_105)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DIAG5)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_106)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_111)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_112)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_113)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_114)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_117)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_120)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_123)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_124)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_125)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_126)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_127)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_128)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_129)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_130)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_131)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_132)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_133)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_134)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_135)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_136)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_137)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_138)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_139)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_140)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_141)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.ERLAEUT)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.LMEDIKAT)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAET)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.BKS)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_153)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_154)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_156)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_157)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_158)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_159)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_160)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_161)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_162)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_163)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_164)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_165)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_166)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_167)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_168)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_169)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_170)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_171)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_172)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_173)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_174)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_175)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_176)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_177)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.LEISTBI)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_178)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_179)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.F_181)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TERLEUT)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.FREITEXT)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ4)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ5)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ6)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ7)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ8)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ9)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ10)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ11)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ12)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ13)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ14)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ15)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ16)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ17)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ18)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ19)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ20)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ21)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ22)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ23)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ24)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.TAZ25)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.LSEITE1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.LSEITE3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.LSEITE4)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.AIGR)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.ABTEILUNG)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DMP)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.arzt1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.arzt2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.arzt3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2>()
                .Property(e => e.DIAG6)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.PAT_iNTERN)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TERLEUT1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TERLEUT2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ1)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ2)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ3)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT4)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT4)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ4)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT5)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT5)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ5)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT6)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT6)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ6)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT7)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT7)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ7)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT8)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT8)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ8)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT9)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT9)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ9)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT10)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT10)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ10)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT11)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT11)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ11)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT12)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT12)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ12)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT13)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT13)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ13)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT14)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT14)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ14)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT15)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT15)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ15)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT16)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT16)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ16)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT17)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT17)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ17)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT18)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT18)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ18)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT19)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT19)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ19)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT20)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT20)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ20)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT21)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT21)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ21)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT22)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT22)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ22)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT23)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT23)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ23)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT24)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT24)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ24)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT25)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT25)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ25)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT26)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT26)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ26)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT27)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT27)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ27)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT28)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT28)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ28)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT29)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT29)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ29)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT30)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT30)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ30)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT31)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT31)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ31)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT32)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT32)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ32)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT33)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT33)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ33)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT34)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT34)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ34)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT35)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT35)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ35)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT36)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT36)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ36)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT37)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT37)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ37)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT38)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT38)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ38)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT39)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT39)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ39)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT40)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT40)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ40)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT41)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT41)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ41)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT42)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT42)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ42)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT43)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT43)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ43)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT44)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT44)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ44)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT45)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT45)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ45)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT46)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT46)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ46)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT47)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT47)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ47)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT48)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT48)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ48)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT49)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT49)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ49)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TKT50)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TZT50)
                .IsUnicode(false);

            modelBuilder.Entity<bericht2ktl>()
                .Property(e => e.TAZ50)
                .IsUnicode(false);

            modelBuilder.Entity<berlock>()
                .Property(e => e.maschine)
                .IsUnicode(false);

            modelBuilder.Entity<doku1>()
                .Property(e => e.DOKUTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<doku1>()
                .Property(e => e.BENUTZER)
                .IsUnicode(false);

            modelBuilder.Entity<doku1>()
                .Property(e => e.DATEI)
                .IsUnicode(false);

            modelBuilder.Entity<doku1>()
                .Property(e => e.DOKUTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.nachrichtentyp)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.rez_nr)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.sender)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.receiver)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.ktraeger)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.bearbeiter)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.aktenzeichen)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.funktionag)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.beauftragtestelle)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.versicherungsnr)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.vnranspruchsberechtigter)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.berechtigtennr)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.massnahmennr)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.geschlechtfamstand)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.national)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.artderleistung)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.diagschluessel)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.pnaab)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.auftragsleistung)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.edifact)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.patangaben)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.tage)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.eilfall)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.leistung)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.eingelesen)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.esol)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.pnabm)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.adr0)
                .IsUnicode(false);

            modelBuilder.Entity<dta301>()
                .Property(e => e.adr1)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.nachrichttyp)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.rez_nr)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.nachrichtorg)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.nachrichtauf)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.bearbeiter)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.esolname)
                .IsUnicode(false);

            modelBuilder.Entity<dtafall>()
                .Property(e => e.icr)
                .IsUnicode(false);

            modelBuilder.Entity<dtatypen>()
                .Property(e => e.fallname)
                .IsUnicode(false);

            modelBuilder.Entity<edifact>()
                .Property(e => e.R_EDIFACT)
                .IsUnicode(false);

            modelBuilder.Entity<eingeloggt>()
                .Property(e => e.comp)
                .IsUnicode(false);

            modelBuilder.Entity<eingeloggt>()
                .Property(e => e.zeit)
                .IsUnicode(false);

            modelBuilder.Entity<eingeloggt>()
                .Property(e => e.einaus)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T1_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T2_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T3_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T4_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T5_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T6_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T7_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.T8_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif1>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif1>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif1>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif1>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif10>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif10>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif10>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif10>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif11>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif11>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif11>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif11>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif12>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif12>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif12>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif12>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif2>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif2>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif2>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif2>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif3>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif3>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif3>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif3>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif4>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif4>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif4>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif4>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif5>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif5>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif5>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif5>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif6>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif6>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif6>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif6>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif7>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif7>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif7>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif7>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif8>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif8>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif8>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif8>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif9>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif9>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif9>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<ertarif9>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.KASSEN_NAM)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.KASSEN_NA2)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.STRASSE)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.PLZ)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.ORT)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.POS_KAS)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.ZUZAHL)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.REZ_NR)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.IKKASSEN)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.IKKOSTEN)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.IKSCHLUESS)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.IKPHYSIK)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.PAT_INTERN)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.PREISDIFF)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.ZUZAHLDIFF)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.DISZIPLIN)
                .IsUnicode(false);

            modelBuilder.Entity<faktura>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<feiertage>()
                .Property(e => e.datdeutsch)
                .IsUnicode(false);

            modelBuilder.Entity<feiertage>()
                .Property(e => e.datsql)
                .IsUnicode(false);

            modelBuilder.Entity<feiertage>()
                .Property(e => e.feiertag)
                .IsUnicode(false);

            modelBuilder.Entity<feiertage>()
                .Property(e => e.buland)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.ikktraeger)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.ikkasse)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.name1)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.rez_nr)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.rezklasse)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.idktraeger)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.edifact)
                .IsUnicode(false);

            modelBuilder.Entity<fertige>()
                .Property(e => e.ediok)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T1)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N1)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS1)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE1)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T2)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N2)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS2)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE2)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T3)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N3)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS3)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE3)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T4)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N4)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS4)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE4)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T5)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N5)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS5)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE5)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T6)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N6)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS6)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE6)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T7)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N7)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS7)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE7)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T8)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N8)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS8)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE8)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T9)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N9)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS9)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE9)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T10)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N10)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS10)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE10)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T11)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N11)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS11)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE11)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T12)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N12)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS12)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE12)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T13)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N13)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS13)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE13)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T14)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N14)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS14)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE14)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T15)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N15)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS15)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE15)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T16)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N16)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS16)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE16)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T17)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N17)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS17)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE17)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T18)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N18)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS18)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE18)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T19)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N19)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS19)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE19)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T20)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N20)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS20)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE20)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T21)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N21)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS21)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE21)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T22)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N22)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS22)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE22)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T23)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N23)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS23)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE23)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T24)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N24)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS24)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE24)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T25)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N25)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS25)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE25)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T26)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N26)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS26)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE26)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T27)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N27)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS27)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE27)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T28)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N28)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS28)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE28)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T29)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N29)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS29)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE29)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T30)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N30)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS30)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE30)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T31)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N31)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS31)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE31)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T32)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N32)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS32)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE32)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T33)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N33)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS33)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE33)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T34)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N34)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS34)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE34)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T35)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N35)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS35)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE35)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T36)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N36)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS36)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE36)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T37)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N37)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS37)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE37)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T38)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N38)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS38)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE38)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T39)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N39)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS39)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE39)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T40)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N40)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS40)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE40)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T41)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N41)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS41)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE41)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T42)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N42)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS42)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE42)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T43)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N43)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS43)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE43)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T44)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N44)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS44)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE44)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T45)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N45)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS45)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE45)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T46)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N46)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS46)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE46)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T47)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N47)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS47)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE47)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T48)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N48)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS48)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE48)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T49)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N49)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS49)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE49)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T50)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N50)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS50)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE50)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T51)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N51)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS51)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE51)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T52)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N52)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS52)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE52)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T53)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N53)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS53)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE53)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T54)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N54)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS54)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE54)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T55)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N55)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS55)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE55)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T56)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N56)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS56)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE56)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T57)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N57)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS57)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE57)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T58)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N58)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS58)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE58)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T59)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N59)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS59)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE59)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.T60)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.N60)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TS60)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TE60)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.BEHANDLER)
                .IsUnicode(false);

            modelBuilder.Entity<flexkc>()
                .Property(e => e.TAGTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<flexlock>()
                .Property(e => e.sperre)
                .IsUnicode(false);

            modelBuilder.Entity<flexlock>()
                .Property(e => e.maschine)
                .IsUnicode(false);

            modelBuilder.Entity<flexlock>()
                .Property(e => e.zeit)
                .IsUnicode(false);

            modelBuilder.Entity<hgroup>()
                .Property(e => e.gruppe)
                .IsUnicode(false);

            modelBuilder.Entity<hmrcheck>()
                .Property(e => e.indischluessel)
                .IsUnicode(false);

            modelBuilder.Entity<hmrcheck>()
                .Property(e => e.vorrangig)
                .IsUnicode(false);

            modelBuilder.Entity<hmrcheck>()
                .Property(e => e.maxvorrangig)
                .IsUnicode(false);

            modelBuilder.Entity<hmrcheck>()
                .Property(e => e.ergaenzend)
                .IsUnicode(false);

            modelBuilder.Entity<hmrcheck>()
                .Property(e => e.maxergaenzend)
                .IsUnicode(false);

            modelBuilder.Entity<htitel>()
                .Property(e => e.titel)
                .IsUnicode(false);

            modelBuilder.Entity<htitel>()
                .Property(e => e.datei)
                .IsUnicode(false);

            modelBuilder.Entity<htitel>()
                .Property(e => e.gruppe)
                .IsUnicode(false);

            modelBuilder.Entity<htitel>()
                .Property(e => e.inhalt)
                .IsUnicode(false);

            modelBuilder.Entity<icd10>()
                .Property(e => e.schluessel1)
                .IsUnicode(false);

            modelBuilder.Entity<icd10>()
                .Property(e => e.schluessel2)
                .IsUnicode(false);

            modelBuilder.Entity<icd10>()
                .Property(e => e.titelzeile)
                .IsUnicode(false);

            modelBuilder.Entity<icd10>()
                .Property(e => e.icdtext)
                .IsUnicode(false);

            modelBuilder.Entity<inidatei>()
                .Property(e => e.dateiname)
                .IsUnicode(false);

            modelBuilder.Entity<inidatei>()
                .Property(e => e.inhalt)
                .IsUnicode(false);

            modelBuilder.Entity<jahresabschluss>()
                .Property(e => e.altesjahr)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PREISGRUPPE)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.kassen_nam1)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.kassen_nam2)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.STRASSE)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PLZ)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.ORT)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.POSTFACH)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.TELEFON)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.KV_NUMMER)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.MATCHCODE)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.KMEMO)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.RECHNUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_KASSE)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_PHYSIKA)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_NUTZER)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_KOSTENT)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_KVKARTE)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.IK_PAPIER)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.EMAIL2)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.EMAIL3)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.HMRABRECHNUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PGKG)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PGMA)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PGER)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PGLO)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PGRH)
                .IsUnicode(false);

            modelBuilder.Entity<kass_adr>()
                .Property(e => e.PGPO)
                .IsUnicode(false);

            modelBuilder.Entity<kasse>()
                .Property(e => e.KTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<kasse>()
                .Property(e => e.KTO)
                .IsUnicode(false);

            modelBuilder.Entity<kasse>()
                .Property(e => e.REZ_NR)
                .IsUnicode(false);

            modelBuilder.Entity<kasse>()
                .Property(e => e.USER)
                .IsUnicode(false);

            modelBuilder.Entity<kasse>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<kb_2016>()
                .Property(e => e.KTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<kb_2016>()
                .Property(e => e.KTO)
                .IsUnicode(false);

            modelBuilder.Entity<kb_2016>()
                .Property(e => e.REZ_NR)
                .IsUnicode(false);

            modelBuilder.Entity<kb_2016>()
                .Property(e => e.USER)
                .IsUnicode(false);

            modelBuilder.Entity<kb_2016>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<kb_bey>()
                .Property(e => e.KTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<kb_bey>()
                .Property(e => e.KTO)
                .IsUnicode(false);

            modelBuilder.Entity<kb_bey>()
                .Property(e => e.REZ_NR)
                .IsUnicode(false);

            modelBuilder.Entity<kb_bey>()
                .Property(e => e.USER)
                .IsUnicode(false);

            modelBuilder.Entity<kb_bey>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T1_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T2_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T3_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T4_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T5_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T6_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T7_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.T8_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif1>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif1>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif1>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif1>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif10>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif10>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif10>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif10>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif11>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif11>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif11>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif11>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif12>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif12>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif12>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif12>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif2>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif2>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif2>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif2>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif3>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif3>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif3>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif3>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif4>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif4>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif4>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif4>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif5>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif5>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif5>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif5>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif6>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif6>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif6>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif6>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif7>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif7>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif7>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif7>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif8>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif8>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif8>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif8>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif9>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif9>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif9>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<kgtarif9>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.ANREDE)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.VORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.NACHNAME)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.STRASSE)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.PLZ)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.ORT)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.TELEFON1)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.TELFON2)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.matchcode)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.ZTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.NICHT_ZEIG)
                .IsUnicode(false);

            modelBuilder.Entity<kollegen2>()
                .Property(e => e.ABTEILUNG)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.ikkasse)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.ikkostentraeger)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.ikpapier)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.ikdaten)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.ikentschluesselung)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.name1)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.name2)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.name3)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.adresse1)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.adresse2)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.adresse3)
                .IsUnicode(false);

            modelBuilder.Entity<ktraeger>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<kuerzel>()
                .Property(e => e.leistung)
                .IsUnicode(false);

            modelBuilder.Entity<kuerzel>()
                .Property(e => e.kuerzel1)
                .IsUnicode(false);

            modelBuilder.Entity<kuerzel>()
                .Property(e => e.disziplin)
                .IsUnicode(false);

            modelBuilder.Entity<kuerzel>()
                .Property(e => e.vorrangig)
                .IsUnicode(false);

            modelBuilder.Entity<kuerzel>()
                .Property(e => e.extraok)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T1_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T2_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T3_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T4_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T5_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T6_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T7_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.T8_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif1>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif1>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif1>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif1>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif10>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif10>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif10>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif10>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif11>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif11>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif11>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif11>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif12>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif12>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif12>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif12>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif2>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif2>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif2>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif2>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif3>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif3>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif3>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif3>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif4>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif4>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif4>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif4>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif5>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif5>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif5>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif5>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif6>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif6>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif6>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif6>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif7>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif7>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif7>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif7>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif8>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif8>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif8>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif8>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif9>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif9>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif9>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<lotarif9>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.REZ_NR)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.BEFR)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.REZ_BEZ)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.ARZT)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.AERZTE)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.DIAGNOSE)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.HEIMBEWOHN)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.LOGFREI1)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.LOGFREI2)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.CHARFREI1)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.CHARFREI2)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.TERMINE)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KTRAEGER)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.BEGRUENDADR)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.HAUSBES)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.INDIKATSCHL)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.ANGELEGTVON)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.DAUER)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.POS3)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.POS4)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.FREQUENZ)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.LASTEDIT)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.ARZTBERICHT)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.FARBCODE)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.RSPLIT)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.JAHRFREI)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.UNTER18)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.HBVOLL)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.ABSCHLUSS)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KUERZEL1)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KUERZEL2)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KUERZEL3)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KUERZEL4)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KUERZEL5)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.KUERZEL6)
                .IsUnicode(false);

            modelBuilder.Entity<lza>()
                .Property(e => e.ICD10)
                .IsUnicode(false);

            modelBuilder.Entity<masntex2>()
                .Property(e => e.RMASSNAHME)
                .IsUnicode(false);

            modelBuilder.Entity<masntex2>()
                .Property(e => e.SCHL1)
                .IsUnicode(false);

            modelBuilder.Entity<masntex2>()
                .Property(e => e.SCHL2)
                .IsUnicode(false);

            modelBuilder.Entity<masntext>()
                .Property(e => e.RMASSNAHME)
                .IsUnicode(false);

            modelBuilder.Entity<masntext>()
                .Property(e => e.SCHL1)
                .IsUnicode(false);

            modelBuilder.Entity<masntext>()
                .Property(e => e.SCHL2)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T1_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T2_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T3_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T4_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T5_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T6_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T7_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.T8_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif1>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif1>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif1>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif1>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif10>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif10>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif10>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif10>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif11>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif11>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif11>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif11>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif12>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif12>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif12>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif12>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif2>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif2>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif2>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif2>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif3>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif3>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif3>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif3>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif4>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif4>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif4>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif4>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif5>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif5>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif5>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif5>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif6>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif6>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif6>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif6>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif7>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif7>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif7>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif7>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif8>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif8>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif8>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif8>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif9>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<matarif9>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<matarif9>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<matarif9>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<nummern>()
                .Property(e => e.mandant)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ANREDE)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.TITEL)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.N_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.V_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwadress)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwanrede)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwtitel)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwn_name)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwv_name)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwstrasse)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwplz)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.abwort)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.KASSE)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.KV_NUMMER)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.KV_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.V_NUMMER)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.KLINIK)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.TELEFONP)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.TELEFONG)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.TELEFONM)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.STRASSE)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.LAND)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.PLZ)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ORT)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ARZT)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ARZT_NUM)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ATEL)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.AFAX)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.BEFREIT)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.AKUTPAT)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.AKUTBEH)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.TERMINE1)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.TERMINE2)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.VIP_PAT)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ER_JANEIN)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.HEIMBEWOHN)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.ABSCHLUSS)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.KILOMETER)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.CHARFREI2)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.EMAILA)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.THERAPEUT)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.merk6)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.merk5)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.merk4)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.merk3)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.merk2)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.merk1)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.aerzte)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.pat_text)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.anamnese)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.arztid)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.kassenid)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.JAHRFREI)
                .IsUnicode(false);

            modelBuilder.Entity<pat5>()
                .Property(e => e.U18IGNORE)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.absender)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.empfaenger_person)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.empfaenger_gruppe)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.gelesen)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.betreff)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.emailtext)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.file1)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.file2)
                .IsUnicode(false);

            modelBuilder.Entity<pimail>()
                .Property(e => e.file3)
                .IsUnicode(false);

            modelBuilder.Entity<pimailgroup>()
                .Property(e => e.groupname)
                .IsUnicode(false);

            modelBuilder.Entity<pimailgroup>()
                .Property(e => e.groupmembers)
                .IsUnicode(false);

            modelBuilder.Entity<poskuerzel>()
                .Property(e => e.DISZIPLIN)
                .IsUnicode(false);

            modelBuilder.Entity<poskuerzel>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif1>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif1>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif1>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif1>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif10>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif10>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif10>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif10>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif11>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif11>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif11>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif11>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif12>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif12>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif12>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif12>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif2>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif2>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif2>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif2>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif3>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif3>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif3>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif3>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif4>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif4>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif4>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif4>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif5>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif5>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif5>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif5>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif6>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif6>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif6>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif6>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif7>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif7>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif7>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif7>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif8>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif8>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif8>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif8>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif9>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<potarif9>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<potarif9>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<potarif9>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rehalogin>()
                .Property(e => e.user)
                .IsUnicode(false);

            modelBuilder.Entity<rehalogin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<rehalogin>()
                .Property(e => e.rights)
                .IsUnicode(false);

            modelBuilder.Entity<rehalogin>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<restricttemplate>()
                .Property(e => e.abteilung)
                .IsUnicode(false);

            modelBuilder.Entity<restricttemplate>()
                .Property(e => e.sammlung)
                .IsUnicode(false);

            modelBuilder.Entity<rgaffaktura>()
                .Property(e => e.rnr)
                .IsUnicode(false);

            modelBuilder.Entity<rgaffaktura>()
                .Property(e => e.reznr)
                .IsUnicode(false);

            modelBuilder.Entity<rgaffaktura>()
                .Property(e => e.pat_intern)
                .IsUnicode(false);

            modelBuilder.Entity<rgaffaktura>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T1_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T2_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T3_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T4_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T5_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T6_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T7_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.T8_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif1>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif1>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif1>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif1>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif10>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif10>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif10>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif10>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif11>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif11>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif11>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif11>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif12>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif12>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif12>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif12>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif2>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif2>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif2>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif2>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif3>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif3>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif3>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif3>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif4>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif4>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif4>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif4>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif5>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif5>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif5>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif5>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif6>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif6>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif6>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif6>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif7>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif7>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif7>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif7>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif8>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif8>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif8>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif8>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif9>()
                .Property(e => e.LEISTUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif9>()
                .Property(e => e.KUERZEL)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif9>()
                .Property(e => e.T_POS)
                .IsUnicode(false);

            modelBuilder.Entity<rhtarif9>()
                .Property(e => e.ZUZAHLUNG)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.R_KASSE)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.R_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.R_KLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.MAHNSPERR)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.PAT_INTERN)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.IKKTRAEGER)
                .IsUnicode(false);

            modelBuilder.Entity<rliste>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<rtadoku>()
                .Property(e => e.DOKUTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<rtadoku>()
                .Property(e => e.BENUTZER)
                .IsUnicode(false);

            modelBuilder.Entity<rtadoku>()
                .Property(e => e.DATEI)
                .IsUnicode(false);

            modelBuilder.Entity<rtadoku>()
                .Property(e => e.DOKUTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBUNTERT)
                .IsUnicode(false);

            modelBuilder.Entity<tbar>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tber>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tbkg>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tblo>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tbma>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tbpo>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBKLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBTHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBABSATZ)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBOBER)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBRANG)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBTITEL)
                .IsUnicode(false);

            modelBuilder.Entity<tbrh>()
                .Property(e => e.TBTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.absender)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.taskowner)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.empfaenger_person)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.empfaenger_gruppe)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.gelesen)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.betreff)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.emailtext)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.file1)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.file2)
                .IsUnicode(false);

            modelBuilder.Entity<todo>()
                .Property(e => e.file3)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.VON_BIS)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.MO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.DI_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.MI_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.DO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.FR_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.SA_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.SO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.KAL_BENUTZER)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub>()
                .Property(e => e.BERECHNET)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.VON_BIS)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.MO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.DI_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.MI_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.DO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.FR_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.SA_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.SO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.KAL_BENUTZER)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2010>()
                .Property(e => e.BERECHNET)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.VON_BIS)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.MO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.DI_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.MI_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.DO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.FR_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.SA_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.SO_ART)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.KAL_BENUTZER)
                .IsUnicode(false);

            modelBuilder.Entity<urlaub2014>()
                .Property(e => e.BERECHNET)
                .IsUnicode(false);

            modelBuilder.Entity<verkartikel>()
                .Property(e => e.ean)
                .IsUnicode(false);

            modelBuilder.Entity<verkartikel>()
                .Property(e => e.beschreibung)
                .IsUnicode(false);

            modelBuilder.Entity<verkartikel>()
                .Property(e => e.einheit)
                .IsUnicode(false);

            modelBuilder.Entity<verkfaktura>()
                .Property(e => e.v_nummer)
                .IsUnicode(false);

            modelBuilder.Entity<verkfaktura>()
                .Property(e => e.art_beschreibung)
                .IsUnicode(false);

            modelBuilder.Entity<verkfaktura>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.ansprechpartner)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.anschrift)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.plz)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.ort)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<verklieferant>()
                .Property(e => e.telefax)
                .IsUnicode(false);

            modelBuilder.Entity<verkliste>()
                .Property(e => e.v_nummer)
                .IsUnicode(false);

            modelBuilder.Entity<verkliste>()
                .Property(e => e.user)
                .IsUnicode(false);

            modelBuilder.Entity<verkliste>()
                .Property(e => e.IK)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.REZ_NR)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.BEFR)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.REZ_BEZ)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.ARZT)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.AERZTE)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.DIAGNOSE)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.HEIMBEWOHN)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.LOGFREI1)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.LOGFREI2)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.CHARFREI1)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.CHARFREI2)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.TERMINE)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KTRAEGER)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.BEGRUENDADR)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.HAUSBES)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.INDIKATSCHL)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.ANGELEGTVON)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.DAUER)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.POS1)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.POS2)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.POS3)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.POS4)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.FREQUENZ)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.LASTEDIT)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.ARZTBERICHT)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.FARBCODE)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.RSPLIT)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.JAHRFREI)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.UNTER18)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.HBVOLL)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.ABSCHLUSS)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KUERZEL1)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KUERZEL2)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KUERZEL3)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KUERZEL4)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KUERZEL5)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.KUERZEL6)
                .IsUnicode(false);

            modelBuilder.Entity<verordn>()
                .Property(e => e.ICD10)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.datum)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.benutzer)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.maschine)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.tkspalte)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.vname)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.vreznr)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.vdauer)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.vstart)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.vend)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.nname)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.nreznr)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.ndauer)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.nstart)
                .IsUnicode(false);

            modelBuilder.Entity<vlog>()
                .Property(e => e.nend)
                .IsUnicode(false);

            modelBuilder.Entity<volle>()
                .Property(e => e.rez_nr)
                .IsUnicode(false);

            modelBuilder.Entity<volle>()
                .Property(e => e.behandler)
                .IsUnicode(false);

            modelBuilder.Entity<vpreise>()
                .Property(e => e.disziplin)
                .IsUnicode(false);

            modelBuilder.Entity<vpreise>()
                .Property(e => e.buland)
                .IsUnicode(false);

            modelBuilder.Entity<vpreise>()
                .Property(e => e.preisgruppe)
                .IsUnicode(false);

            modelBuilder.Entity<vpreise>()
                .Property(e => e.posnr)
                .IsUnicode(false);

            modelBuilder.Entity<vpreise>()
                .Property(e => e.langtext)
                .IsUnicode(false);

            modelBuilder.Entity<vpreise>()
                .Property(e => e.bundesweit)
                .IsUnicode(false);

            modelBuilder.Entity<wecker>()
                .Property(e => e.n_name)
                .IsUnicode(false);

            modelBuilder.Entity<wecker>()
                .Property(e => e.behandlung)
                .IsUnicode(false);

            modelBuilder.Entity<wecker>()
                .Property(e => e.raum)
                .IsUnicode(false);

            modelBuilder.Entity<wecker>()
                .Property(e => e.fertig)
                .IsUnicode(false);

            modelBuilder.Entity<wecker>()
                .Property(e => e.registriert)
                .IsUnicode(false);

            modelBuilder.Entity<wecker>()
                .Property(e => e.registervon)
                .IsUnicode(false);
        }
    }
}
