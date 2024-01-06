using Microsoft.EntityFrameworkCore;
using titanitedb.Models;

namespace titanitedb.Data;

public partial class TitanitesContext : DbContext
{
    public TitanitesContext(DbContextOptions<TitanitesContext> options)
        : base(options)
    {  
    }

    public virtual DbSet<Titanite> Titanites { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Titanite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("titanite");

            entity.Property(e => e.AgeKa).HasColumnName("AGE(KA)");
            entity.Property(e => e.AgeMa).HasColumnName("AGE(MA)");
            entity.Property(e => e.Al2o3Wt).HasColumnName("AL2O3(WT%)");
            entity.Property(e => e.AlPpm).HasColumnName("AL(PPM)");
            entity.Property(e => e.Alteration).HasColumnName("ALTERATION");
            entity.Property(e => e.BPpm).HasColumnName("B(PPM)");
            entity.Property(e => e.BaPpm).HasColumnName("BA(PPM)");
            entity.Property(e => e.BaoWt).HasColumnName("BAO(WT%)");
            entity.Property(e => e.BePpm).HasColumnName("BE(PPM)");
            entity.Property(e => e.BiPpm).HasColumnName("BI(PPM)");
            entity.Property(e => e.CaPpm).HasColumnName("CA(PPM)");
            entity.Property(e => e.CaoWt).HasColumnName("CAO(WT%)");
            entity.Property(e => e.CdPpm).HasColumnName("CD(PPM)");
            entity.Property(e => e.Ce138Ce142).HasColumnName("CE138_CE142");
            entity.Property(e => e.Ce2o3Wt).HasColumnName("CE2O3(WT%)");
            entity.Property(e => e.CePpm).HasColumnName("CE(PPM)");
            entity.Property(e => e.Ceo2Wt).HasColumnName("CEO2(WT%)");
            entity.Property(e => e.ChromiteMol).HasColumnName("CHROMITE(MOL%)");
            entity.Property(e => e.Citation).HasColumnName("CITATION");
            entity.Property(e => e.ClPpm).HasColumnName("CL(PPM)");
            entity.Property(e => e.ClWt).HasColumnName("CL(WT%)");
            entity.Property(e => e.CoPpm).HasColumnName("CO(PPM)");
            entity.Property(e => e.Cr2o3Wt).HasColumnName("CR2O3(WT%)");
            entity.Property(e => e.CrPpm).HasColumnName("CR(PPM)");
            entity.Property(e => e.Crystal).HasColumnName("CRYSTAL");
            entity.Property(e => e.CsPpm).HasColumnName("CS(PPM)");
            entity.Property(e => e.CuPpm).HasColumnName("CU(PPM)");
            entity.Property(e => e.D18o).HasColumnName("D18O()");
            entity.Property(e => e.D18oVsmow).HasColumnName("D18O(VSMOW)");
            entity.Property(e => e.DrillingDepthMax).HasColumnName("DRILLING DEPTH (MAX.)");
            entity.Property(e => e.DrillingDepthMin).HasColumnName("DRILLING DEPTH (MIN.)");
            entity.Property(e => e.Dy2o3Wt).HasColumnName("DY2O3(WT%)");
            entity.Property(e => e.DyPpm).HasColumnName("DY(PPM)");
            entity.Property(e => e.ElevationMax).HasColumnName("ELEVATION (MAX.)");
            entity.Property(e => e.ElevationMin).HasColumnName("ELEVATION (MIN.)");
            entity.Property(e => e.Er2o3Wt).HasColumnName("ER2O3(WT%)");
            entity.Property(e => e.ErPpm).HasColumnName("ER(PPM)");
            entity.Property(e => e.Eu2o3Wt).HasColumnName("EU2O3(WT%)");
            entity.Property(e => e.EuPpm).HasColumnName("EU(PPM)");
            entity.Property(e => e.FPpm).HasColumnName("F(PPM)");
            entity.Property(e => e.FWt).HasColumnName("F(WT%)");
            entity.Property(e => e.Fe2o3Wt).HasColumnName("FE2O3(WT%)");
            entity.Property(e => e.Fe2o3tWt).HasColumnName("FE2O3T(WT%)");
            entity.Property(e => e.FePpm).HasColumnName("FE(PPM)");
            entity.Property(e => e.FeWt).HasColumnName("FE(WT%)");
            entity.Property(e => e.FeoWt).HasColumnName("FEO(WT%)");
            entity.Property(e => e.FeotWt).HasColumnName("FEOT(WT%)");
            entity.Property(e => e.GaPpm).HasColumnName("GA(PPM)");
            entity.Property(e => e.Gd2o3Wt).HasColumnName("GD2O3(WT%)");
            entity.Property(e => e.GdPpm).HasColumnName("GD(PPM)");
            entity.Property(e => e.GePpm).HasColumnName("GE(PPM)");
            entity.Property(e => e.GrainSize).HasColumnName("GRAIN SIZE");
            entity.Property(e => e.H2oWt).HasColumnName("H2O(WT%)");
            entity.Property(e => e.HeMolG).HasColumnName("HE(MOL/G)");
            entity.Property(e => e.HercyniteMol).HasColumnName("HERCYNITE(MOL%)");
            entity.Property(e => e.HfPpm).HasColumnName("HF(PPM)");
            entity.Property(e => e.Hfo2Wt).HasColumnName("HFO2(WT%)");
            entity.Property(e => e.HoPpm).HasColumnName("HO(PPM)");
            entity.Property(e => e.JacobsiteMol).HasColumnName("JACOBSITE(MOL%)");
            entity.Property(e => e.K2oWt).HasColumnName("K2O(WT%)");
            entity.Property(e => e.KPpm).HasColumnName("K(PPM)");
            entity.Property(e => e.La138Ce142).HasColumnName("LA138_CE142");
            entity.Property(e => e.La2o3Wt).HasColumnName("LA2O3(WT%)");
            entity.Property(e => e.LaPpm).HasColumnName("LA(PPM)");
            entity.Property(e => e.LandSeaSampling).HasColumnName("LAND/SEA (SAMPLING)");
            entity.Property(e => e.LatitudeMax).HasColumnName("LATITUDE (MAX.)");
            entity.Property(e => e.LatitudeMin).HasColumnName("LATITUDE (MIN.)");
            entity.Property(e => e.LiPpm).HasColumnName("LI(PPM)");
            entity.Property(e => e.Location).HasColumnName("LOCATION");
            entity.Property(e => e.LocationComment).HasColumnName("LOCATION COMMENT");
            entity.Property(e => e.LongitudeMax).HasColumnName("LONGITUDE (MAX.)");
            entity.Property(e => e.LongitudeMin).HasColumnName("LONGITUDE (MIN.)");
            entity.Property(e => e.LuPpm).HasColumnName("LU(PPM)");
            entity.Property(e => e.MagnesioferriteMol).HasColumnName("MAGNESIOFERRITE(MOL%)");
            entity.Property(e => e.MagnetiteMol).HasColumnName("MAGNETITE(MOL%)");
            entity.Property(e => e.MgChromiteMol).HasColumnName("MG-CHROMITE(MOL%)");
            entity.Property(e => e.MgPpm).HasColumnName("MG(PPM)");
            entity.Property(e => e.MgoWt).HasColumnName("MGO(WT%)");
            entity.Property(e => e.Mineral).HasColumnName("MINERAL");
            entity.Property(e => e.MnPpm).HasColumnName("MN(PPM)");
            entity.Property(e => e.MnoWt).HasColumnName("MNO(WT%)");
            entity.Property(e => e.MoPpm).HasColumnName("MO(PPM)");
            entity.Property(e => e.Na2oWt).HasColumnName("NA2O(WT%)");
            entity.Property(e => e.NaPpm).HasColumnName("NA(PPM)");
            entity.Property(e => e.NaWt).HasColumnName("NA(WT%)");
            entity.Property(e => e.Nb2o3Wt).HasColumnName("NB2O3(WT%)");
            entity.Property(e => e.Nb2o5Wt).HasColumnName("NB2O5(WT%)");
            entity.Property(e => e.NbPpm).HasColumnName("NB(PPM)");
            entity.Property(e => e.Nd143Nd144).HasColumnName("ND143_ND144");
            entity.Property(e => e.Nd145Nd144).HasColumnName("ND145_ND144");
            entity.Property(e => e.Nd146Nd144).HasColumnName("ND146_ND144");
            entity.Property(e => e.Nd148Nd144).HasColumnName("ND148_ND144");
            entity.Property(e => e.Nd150Nd144).HasColumnName("ND150_ND144");
            entity.Property(e => e.Nd2o3Wt).HasColumnName("ND2O3(WT%)");
            entity.Property(e => e.NdPpm).HasColumnName("ND(PPM)");
            entity.Property(e => e.NiPpm).HasColumnName("NI(PPM)");
            entity.Property(e => e.NioWt).HasColumnName("NIO(WT%)");
            entity.Property(e => e.OhWt).HasColumnName("OH(WT%)");
            entity.Property(e => e.P2o5Wt).HasColumnName("P2O5(WT%)");
            entity.Property(e => e.PPpm).HasColumnName("P(PPM)");
            entity.Property(e => e.Pb204Ppm).HasColumnName("PB204(PPM)");
            entity.Property(e => e.Pb206Pb204).HasColumnName("PB206_PB204");
            entity.Property(e => e.Pb206Pb207).HasColumnName("PB206_PB207");
            entity.Property(e => e.Pb206Pb208).HasColumnName("PB206_PB208");
            entity.Property(e => e.Pb206Ppm).HasColumnName("PB206(PPM)");
            entity.Property(e => e.Pb206U238).HasColumnName("PB206_U238");
            entity.Property(e => e.Pb207Pb204).HasColumnName("PB207_PB204");
            entity.Property(e => e.Pb207Pb206).HasColumnName("PB207_PB206");
            entity.Property(e => e.Pb207Ppm).HasColumnName("PB207(PPM)");
            entity.Property(e => e.Pb207U235).HasColumnName("PB207_U235");
            entity.Property(e => e.Pb208Pb204).HasColumnName("PB208_PB204");
            entity.Property(e => e.Pb208Pb206).HasColumnName("PB208_PB206");
            entity.Property(e => e.Pb208Ppm).HasColumnName("PB208(PPM)");
            entity.Property(e => e.Pb208Th232).HasColumnName("PB208_TH232");
            entity.Property(e => e.PbPpm).HasColumnName("PB(PPM)");
            entity.Property(e => e.PboWt).HasColumnName("PBO(WT%)");
            entity.Property(e => e.Pr2o3Wt).HasColumnName("PR2O3(WT%)");
            entity.Property(e => e.PrPpm).HasColumnName("PR(PPM)");
            entity.Property(e => e.PrimarySecondary).HasColumnName("PRIMARY/SECONDARY");
            entity.Property(e => e.Ra226Th230Act).HasColumnName("RA226_TH230_ACT");
            entity.Property(e => e.Rb87Sr86).HasColumnName("RB87_SR86");
            entity.Property(e => e.RbPpm).HasColumnName("RB(PPM)");
            entity.Property(e => e.RimCoreMineralGrains).HasColumnName("RIM/CORE (MINERAL GRAINS)");
            entity.Property(e => e.RockName).HasColumnName("ROCK NAME");
            entity.Property(e => e.RockTexture).HasColumnName("ROCK TEXTURE");
            entity.Property(e => e.SPpm).HasColumnName("S(PPM)");
            entity.Property(e => e.SampleName).HasColumnName("SAMPLE NAME");
            entity.Property(e => e.SbPpm).HasColumnName("SB(PPM)");
            entity.Property(e => e.ScPpm).HasColumnName("SC(PPM)");
            entity.Property(e => e.SiPpm).HasColumnName("SI(PPM)");
            entity.Property(e => e.Sio2Wt).HasColumnName("SIO2(WT%)");
            entity.Property(e => e.Sm147Nd144).HasColumnName("SM147_ND144");
            entity.Property(e => e.Sm2o3Wt).HasColumnName("SM2O3(WT%)");
            entity.Property(e => e.SmPpm).HasColumnName("SM(PPM)");
            entity.Property(e => e.SnPpm).HasColumnName("SN(PPM)");
            entity.Property(e => e.Sno2Wt).HasColumnName("SNO2(WT%)");
            entity.Property(e => e.So2Wt).HasColumnName("SO2(WT%)");
            entity.Property(e => e.So3Wt).HasColumnName("SO3(WT%)");
            entity.Property(e => e.So4Wt).HasColumnName("SO4(WT%)");
            entity.Property(e => e.SpinelMol).HasColumnName("SPINEL(MOL%)");
            entity.Property(e => e.Spot).HasColumnName("SPOT");
            entity.Property(e => e.Sr87Sr86).HasColumnName("SR87_SR86");
            entity.Property(e => e.SrPpm).HasColumnName("SR(PPM)");
            entity.Property(e => e.SroWt).HasColumnName("SRO(WT%)");
            entity.Property(e => e.Ta2o3Wt).HasColumnName("TA2O3(WT%)");
            entity.Property(e => e.Ta2o5Wt).HasColumnName("TA2O5(WT%)");
            entity.Property(e => e.TaPpm).HasColumnName("TA(PPM)");
            entity.Property(e => e.TbPpm).HasColumnName("TB(PPM)");
            entity.Property(e => e.TectonicSetting).HasColumnName("TECTONIC SETTING");
            entity.Property(e => e.Th230Th232Act).HasColumnName("TH230_TH232_ACT");
            entity.Property(e => e.Th230U238Act).HasColumnName("TH230_U238_ACT");
            entity.Property(e => e.Th232Ppm).HasColumnName("TH232(PPM)");
            entity.Property(e => e.ThPpm).HasColumnName("TH(PPM)");
            entity.Property(e => e.Tho2Wt).HasColumnName("THO2(WT%)");
            entity.Property(e => e.TiPpm).HasColumnName("TI(PPM)");
            entity.Property(e => e.Tio2Wt).HasColumnName("TIO2(WT%)");
            entity.Property(e => e.TlPpm).HasColumnName("TL(PPM)");
            entity.Property(e => e.TmPpm).HasColumnName("TM(PPM)");
            entity.Property(e => e.U234U238Act).HasColumnName("U234_U238_ACT");
            entity.Property(e => e.U238Pb204).HasColumnName("U238_PB204");
            entity.Property(e => e.U238Pb206).HasColumnName("U238_PB206");
            entity.Property(e => e.U238Ppm).HasColumnName("U238(PPM)");
            entity.Property(e => e.U238Th232Act).HasColumnName("U238_TH232_ACT");
            entity.Property(e => e.UPpm).HasColumnName("U(PPM)");
            entity.Property(e => e.UlvospinelMol).HasColumnName("ULVOSPINEL(MOL%)");
            entity.Property(e => e.Uo2Wt).HasColumnName("UO2(WT%)");
            entity.Property(e => e.Uo3Wt).HasColumnName("UO3(WT%)");
            entity.Property(e => e.V2o3Wt).HasColumnName("V2O3(WT%)");
            entity.Property(e => e.V2o5Wt).HasColumnName("V2O5(WT%)");
            entity.Property(e => e.VPpm).HasColumnName("V(PPM)");
            entity.Property(e => e.WPpm).HasColumnName("W(PPM)");
            entity.Property(e => e.Y2o3Wt).HasColumnName("Y2O3(WT%)");
            entity.Property(e => e.YPpm).HasColumnName("Y(PPM)");
            entity.Property(e => e.YbPpm).HasColumnName("YB(PPM)");
            entity.Property(e => e.ZnPpm).HasColumnName("ZN(PPM)");
            entity.Property(e => e.ZnoWt).HasColumnName("ZNO(WT%)");
            entity.Property(e => e.ZrPpm).HasColumnName("ZR(PPM)");
            entity.Property(e => e.Zro2Wt).HasColumnName("ZRO2(WT%)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
