using titanitedb.Data;
namespace titanitedb.Models;

public partial class Titanite
{

    #region methods

    /// <summary>
    /// Searches all columns in the Titanite database
    /// </summary>
    /// <param name="context"></param>
    /// <param name="search"></param>
    /// <returns></returns>
    public static Titanite[] Search(TitanitesContext context, string search)
    {
        return context.Titanites.Where(t =>
                t.Citation.Contains(search)
            || t.SampleName.Contains(search)
            || t.TectonicSetting.Contains(search)
            || t.Location.Contains(search)
            || t.LocationComment.Contains(search)
            || t.LatitudeMin.Contains(search)
            || t.LatitudeMax.Contains(search)
            || t.LongitudeMin.Contains(search)
            || t.LongitudeMax.Contains(search)
            || t.LandSeaSampling.Contains(search)
            || t.ElevationMin.Contains(search)
            || t.ElevationMax.Contains(search)
            || t.RockName.Contains(search)
            || t.RockTexture.Contains(search)
            || t.DrillingDepthMin.Contains(search)
            || t.DrillingDepthMax.Contains(search)
            || t.Alteration.Contains(search)
            || t.Mineral.Contains(search)
            || t.Spot.Contains(search)
            || t.Crystal.Contains(search)
            || t.RimCoreMineralGrains.Contains(search)
            || t.GrainSize.Contains(search)
            || t.PrimarySecondary.Contains(search)
            || t.Sio2Wt.Contains(search)
            || t.Tio2Wt.Contains(search)
            || t.Zro2Wt.Contains(search)
            || t.Hfo2Wt.Contains(search)
            || t.Tho2Wt.Contains(search)
            || t.Uo2Wt.Contains(search)
            || t.Uo3Wt.Contains(search)
            || t.Al2o3Wt.Contains(search)
            || t.Cr2o3Wt.Contains(search)
            || t.La2o3Wt.Contains(search)
            || t.Ce2o3Wt.Contains(search)
            || t.Ceo2Wt.Contains(search)
            || t.Nd2o3Wt.Contains(search)
            || t.Sm2o3Wt.Contains(search)
            || t.Eu2o3Wt.Contains(search)
            || t.Gd2o3Wt.Contains(search)
            || t.Dy2o3Wt.Contains(search)
            || t.Er2o3Wt.Contains(search)
            || t.Y2o3Wt.Contains(search)
            || t.V2o3Wt.Contains(search)
            || t.V2o5Wt.Contains(search)
            || t.Nb2o3Wt.Contains(search)
            || t.Nb2o5Wt.Contains(search)
            || t.Ta2o3Wt.Contains(search)
            || t.Ta2o5Wt.Contains(search)
            || t.Pr2o3Wt.Contains(search)
            || t.Fe2o3tWt.Contains(search)
            || t.Fe2o3Wt.Contains(search)
            || t.FeotWt.Contains(search)
            || t.FeoWt.Contains(search)
            || t.CaoWt.Contains(search)
            || t.MgoWt.Contains(search)
            || t.MnoWt.Contains(search)
            || t.BaoWt.Contains(search)
            || t.SroWt.Contains(search)
            || t.PboWt.Contains(search)
            || t.Sno2Wt.Contains(search)
            || t.NioWt.Contains(search)
            || t.ZnoWt.Contains(search)
            || t.K2oWt.Contains(search)
            || t.Na2oWt.Contains(search)
            || t.P2o5Wt.Contains(search)
            || t.H2oWt.Contains(search)
            || t.FWt.Contains(search)
            || t.ClWt.Contains(search)
            || t.OhWt.Contains(search)
            || t.So2Wt.Contains(search)
            || t.So3Wt.Contains(search)
            || t.So4Wt.Contains(search)
            || t.FeWt.Contains(search)
            || t.NaWt.Contains(search)
            || t.HeMolG.Contains(search)
            || t.LiPpm.Contains(search)
            || t.BePpm.Contains(search)
            || t.BPpm.Contains(search)
            || t.FPpm.Contains(search)
            || t.NaPpm.Contains(search)
            || t.MgPpm.Contains(search)
            || t.AlPpm.Contains(search)
            || t.SiPpm.Contains(search)
            || t.PPpm.Contains(search)
            || t.SPpm.Contains(search)
            || t.ClPpm.Contains(search)
            || t.KPpm.Contains(search)
            || t.CaPpm.Contains(search)
            || t.ScPpm.Contains(search)
            || t.TiPpm.Contains(search)
            || t.VPpm.Contains(search)
            || t.CrPpm.Contains(search)
            || t.MnPpm.Contains(search)
            || t.FePpm.Contains(search)
            || t.CoPpm.Contains(search)
            || t.NiPpm.Contains(search)
            || t.CuPpm.Contains(search)
            || t.ZnPpm.Contains(search)
            || t.GaPpm.Contains(search)
            || t.GePpm.Contains(search)
            || t.RbPpm.Contains(search)
            || t.SrPpm.Contains(search)
            || t.YPpm.Contains(search)
            || t.ZrPpm.Contains(search)
            || t.NbPpm.Contains(search)
            || t.MoPpm.Contains(search)
            || t.CdPpm.Contains(search)
            || t.SnPpm.Contains(search)
            || t.SbPpm.Contains(search)
            || t.CsPpm.Contains(search)
            || t.BaPpm.Contains(search)
            || t.LaPpm.Contains(search)
            || t.CePpm.Contains(search)
            || t.PrPpm.Contains(search)
            || t.NdPpm.Contains(search)
            || t.SmPpm.Contains(search)
            || t.EuPpm.Contains(search)
            || t.GdPpm.Contains(search)
            || t.TbPpm.Contains(search)
            || t.DyPpm.Contains(search)
            || t.HoPpm.Contains(search)
            || t.ErPpm.Contains(search)
            || t.TmPpm.Contains(search)
            || t.YbPpm.Contains(search)
            || t.LuPpm.Contains(search)
            || t.HfPpm.Contains(search)
            || t.TaPpm.Contains(search)
            || t.WPpm.Contains(search)
            || t.TlPpm.Contains(search)
            || t.PbPpm.Contains(search)
            || t.Pb204Ppm.Contains(search)
            || t.Pb206Ppm.Contains(search)
            || t.Pb207Ppm.Contains(search)
            || t.Pb208Ppm.Contains(search)
            || t.BiPpm.Contains(search)
            || t.ThPpm.Contains(search)
            || t.Th232Ppm.Contains(search)
            || t.UPpm.Contains(search)
            || t.U238Ppm.Contains(search)
            || t.Nd143Nd144.Contains(search)
            || t.Nd145Nd144.Contains(search)
            || t.Nd146Nd144.Contains(search)
            || t.Nd148Nd144.Contains(search)
            || t.Nd150Nd144.Contains(search)
            || t.Sm147Nd144.Contains(search)
            || t.Sr87Sr86.Contains(search)
            || t.Rb87Sr86.Contains(search)
            || t.Pb206Pb204.Contains(search)
            || t.Pb206Pb207.Contains(search)
            || t.Pb206Pb208.Contains(search)
            || t.Pb207Pb204.Contains(search)
            || t.Pb207Pb206.Contains(search)
            || t.Pb208Pb204.Contains(search)
            || t.Pb208Pb206.Contains(search)
            || t.Ce138Ce142.Contains(search)
            || t.La138Ce142.Contains(search)
            || t.Pb206U238.Contains(search)
            || t.Pb207U235.Contains(search)
            || t.Pb208Th232.Contains(search)
            || t.Ra226Th230Act.Contains(search)
            || t.Th230Th232Act.Contains(search)
            || t.Th230U238Act.Contains(search)
            || t.U234U238Act.Contains(search)
            || t.U238Pb204.Contains(search)
            || t.U238Pb206.Contains(search)
            || t.U238Th232Act.Contains(search)
            || t.D18o.Contains(search)
            || t.D18oVsmow.Contains(search)
            || t.ChromiteMol.Contains(search)
            || t.HercyniteMol.Contains(search)
            || t.JacobsiteMol.Contains(search)
            || t.MgChromiteMol.Contains(search)
            || t.MagnesioferriteMol.Contains(search)
            || t.MagnetiteMol.Contains(search)
            || t.SpinelMol.Contains(search)
            || t.UlvospinelMol.Contains(search)
            || t.AgeKa.Contains(search)
            || t.AgeMa.Contains(search)
        ).Take(100)
        .ToArray();
    }
    #endregion

    #region tableProperties
    public string Citation { get; set; } = "";

    public string SampleName { get; set; } = "";

    public string TectonicSetting { get; set; } = "";

    public string Location { get; set; } = "";

    public string LocationComment { get; set; } = "";

    public string LatitudeMin { get; set; } = "";

    public string LatitudeMax { get; set; } = "";

    public string LongitudeMin { get; set; } = "";

    public string LongitudeMax { get; set; } = "";

    public string LandSeaSampling { get; set; } = "";

    public string ElevationMin { get; set; } = "";

    public string ElevationMax { get; set; } = "";

    public string RockName { get; set; } = "";

    public string RockTexture { get; set; } = "";

    public string DrillingDepthMin { get; set; } = "";

    public string DrillingDepthMax { get; set; } = "";

    public string Alteration { get; set; } = "";

    public string Mineral { get; set; } = "";

    public string Spot { get; set; } = "";

    public string Crystal { get; set; } = "";

    public string RimCoreMineralGrains { get; set; } = "";

    public string GrainSize { get; set; } = "";

    public string PrimarySecondary { get; set; } = "";

    public string Sio2Wt { get; set; } = "";

    public string Tio2Wt { get; set; } = "";

    public string Zro2Wt { get; set; } = "";

    public string Hfo2Wt { get; set; } = "";

    public string Tho2Wt { get; set; } = "";

    public string Uo2Wt { get; set; } = "";

    public string Uo3Wt { get; set; } = "";

    public string Al2o3Wt { get; set; } = "";

    public string Cr2o3Wt { get; set; } = "";

    public string La2o3Wt { get; set; } = "";

    public string Ce2o3Wt { get; set; } = "";

    public string Ceo2Wt { get; set; } = "";

    public string Nd2o3Wt { get; set; } = "";

    public string Sm2o3Wt { get; set; } = "";

    public string Eu2o3Wt { get; set; } = "";

    public string Gd2o3Wt { get; set; } = "";

    public string Dy2o3Wt { get; set; } = "";

    public string Er2o3Wt { get; set; } = "";

    public string Y2o3Wt { get; set; } = "";

    public string V2o3Wt { get; set; } = "";

    public string V2o5Wt { get; set; } = "";

    public string Nb2o3Wt { get; set; } = "";

    public string Nb2o5Wt { get; set; } = "";

    public string Ta2o3Wt { get; set; } = "";

    public string Ta2o5Wt { get; set; } = "";

    public string Pr2o3Wt { get; set; } = "";

    public string Fe2o3tWt { get; set; } = "";

    public string Fe2o3Wt { get; set; } = "";

    public string FeotWt { get; set; } = "";

    public string FeoWt { get; set; } = "";

    public string CaoWt { get; set; } = "";

    public string MgoWt { get; set; } = "";

    public string MnoWt { get; set; } = "";

    public string BaoWt { get; set; } = "";

    public string SroWt { get; set; } = "";

    public string PboWt { get; set; } = "";

    public string Sno2Wt { get; set; } = "";

    public string NioWt { get; set; } = "";

    public string ZnoWt { get; set; } = "";

    public string K2oWt { get; set; } = "";

    public string Na2oWt { get; set; } = "";

    public string P2o5Wt { get; set; } = "";

    public string H2oWt { get; set; } = "";

    public string FWt { get; set; } = "";

    public string ClWt { get; set; } = "";

    public string OhWt { get; set; } = "";

    public string So2Wt { get; set; } = "";

    public string So3Wt { get; set; } = "";

    public string So4Wt { get; set; } = "";

    public string FeWt { get; set; } = "";

    public string NaWt { get; set; } = "";

    public string HeMolG { get; set; } = "";

    public string LiPpm { get; set; } = "";

    public string BePpm { get; set; } = "";

    public string BPpm { get; set; } = "";

    public string FPpm { get; set; } = "";

    public string NaPpm { get; set; } = "";

    public string MgPpm { get; set; } = "";

    public string AlPpm { get; set; } = "";

    public string SiPpm { get; set; } = "";

    public string PPpm { get; set; } = "";

    public string SPpm { get; set; } = "";

    public string ClPpm { get; set; } = "";

    public string KPpm { get; set; } = "";

    public string CaPpm { get; set; } = "";

    public string ScPpm { get; set; } = "";

    public string TiPpm { get; set; } = "";

    public string VPpm { get; set; } = "";

    public string CrPpm { get; set; } = "";

    public string MnPpm { get; set; } = "";

    public string FePpm { get; set; } = "";

    public string CoPpm { get; set; } = "";

    public string NiPpm { get; set; } = "";

    public string CuPpm { get; set; } = "";

    public string ZnPpm { get; set; } = "";

    public string GaPpm { get; set; } = "";

    public string GePpm { get; set; } = "";

    public string RbPpm { get; set; } = "";

    public string SrPpm { get; set; } = "";

    public string YPpm { get; set; } = "";

    public string ZrPpm { get; set; } = "";

    public string NbPpm { get; set; } = "";

    public string MoPpm { get; set; } = "";

    public string CdPpm { get; set; } = "";

    public string SnPpm { get; set; } = "";

    public string SbPpm { get; set; } = "";

    public string CsPpm { get; set; } = "";

    public string BaPpm { get; set; } = "";

    public string LaPpm { get; set; } = "";

    public string CePpm { get; set; } = "";

    public string PrPpm { get; set; } = "";

    public string NdPpm { get; set; } = "";

    public string SmPpm { get; set; } = "";

    public string EuPpm { get; set; } = "";

    public string GdPpm { get; set; } = "";

    public string TbPpm { get; set; } = "";

    public string DyPpm { get; set; } = "";

    public string HoPpm { get; set; } = "";

    public string ErPpm { get; set; } = "";

    public string TmPpm { get; set; } = "";

    public string YbPpm { get; set; } = "";

    public string LuPpm { get; set; } = "";

    public string HfPpm { get; set; } = "";

    public string TaPpm { get; set; } = "";

    public string WPpm { get; set; } = "";

    public string TlPpm { get; set; } = "";

    public string PbPpm { get; set; } = "";

    public string Pb204Ppm { get; set; } = "";

    public string Pb206Ppm { get; set; } = "";

    public string Pb207Ppm { get; set; } = "";

    public string Pb208Ppm { get; set; } = "";

    public string BiPpm { get; set; } = "";

    public string ThPpm { get; set; } = "";

    public string Th232Ppm { get; set; } = "";

    public string UPpm { get; set; } = "";

    public string U238Ppm { get; set; } = "";

    public string Nd143Nd144 { get; set; } = "";

    public string Nd145Nd144 { get; set; } = "";

    public string Nd146Nd144 { get; set; } = "";

    public string Nd148Nd144 { get; set; } = "";

    public string Nd150Nd144 { get; set; } = "";

    public string Sm147Nd144 { get; set; } = "";

    public string Sr87Sr86 { get; set; } = "";

    public string Rb87Sr86 { get; set; } = "";

    public string Pb206Pb204 { get; set; } = "";

    public string Pb206Pb207 { get; set; } = "";

    public string Pb206Pb208 { get; set; } = "";

    public string Pb207Pb204 { get; set; } = "";

    public string Pb207Pb206 { get; set; } = "";

    public string Pb208Pb204 { get; set; } = "";

    public string Pb208Pb206 { get; set; } = "";

    public string Ce138Ce142 { get; set; } = "";

    public string La138Ce142 { get; set; } = "";

    public string Pb206U238 { get; set; } = "";

    public string Pb207U235 { get; set; } = "";

    public string Pb208Th232 { get; set; } = "";

    public string Ra226Th230Act { get; set; } = "";

    public string Th230Th232Act { get; set; } = "";

    public string Th230U238Act { get; set; } = "";

    public string U234U238Act { get; set; } = "";

    public string U238Pb204 { get; set; } = "";

    public string U238Pb206 { get; set; } = "";

    public string U238Th232Act { get; set; } = "";

    public string D18o { get; set; } = "";

    public string D18oVsmow { get; set; } = "";

    public string ChromiteMol { get; set; } = "";

    public string HercyniteMol { get; set; } = "";

    public string JacobsiteMol { get; set; } = "";

    public string MgChromiteMol { get; set; } = "";

    public string MagnesioferriteMol { get; set; } = "";

    public string MagnetiteMol { get; set; } = "";

    public string SpinelMol { get; set; } = "";

    public string UlvospinelMol { get; set; } = "";

    public string AgeKa { get; set; } = "";

    public string AgeMa { get; set; } = "";
    #endregion
}
