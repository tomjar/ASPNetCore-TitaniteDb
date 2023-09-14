namespace titanitedb.Models
{
    public class CsvTitaniteMapping : TinyCsvParser.Mapping.CsvMapping<Titanite>
    {
        public CsvTitaniteMapping()
        : base()
        {
            MapProperty(0, x => x.citation);    // "CITATION",
            MapProperty(1, x => x.sample_name); // "SAMPLE NAME",
            MapProperty(2, x => x.tectonic_setting);    //"TECTONIC SETTING",
            MapProperty(3, x => x.location);    //"LOCATION",
            MapProperty(4, x => x.location_comment);    //"LOCATION COMMENT",
            MapProperty(5, x => x.latitude_min);    //"LATITUDE (MIN.)",
            MapProperty(6, x => x.latitude_max);    //"LATITUDE (MAX.)",
            MapProperty(7, x => x.longitude_min);   //"LONGITUDE (MIN.)",
            MapProperty(8, x => x.longitude_max);   //"LONGITUDE (MAX.)",
            MapProperty(9, x => x.land_sea_sampling);   //"LAND/SEA (SAMPLING)",
            MapProperty(10, x => x.elevation_min);  //"ELEVATION (MIN.)",
            MapProperty(11, x => x.elevation_max);  //"ELEVATION (MAX.)",
            MapProperty(12, x => x.rock_name);  //"ROCK NAME",
            MapProperty(13, x => x.rock_texture);   //"ROCK TEXTURE",
            MapProperty(14, x => x.drilling_depth_min); //"DRILLING DEPTH (MIN.)",
            MapProperty(15, x => x.drilling_depth_max); //"DRILLING DEPTH (MAX.)",
            MapProperty(16, x => x.alteration); //"ALTERATION",
            MapProperty(17, x => x.mineral);    //"MINERAL",
            MapProperty(18, x => x.spot);   //"SPOT",
            MapProperty(19, x => x.crystal);    //"CRYSTAL",
            MapProperty(20, x => x.rim_core_mineral_grains);    //"RIM/CORE (MINERAL GRAINS)",
            MapProperty(21, x => x.grain_size); //"GRAIN SIZE",
            MapProperty(22, x => x.primary_secondary);  //"PRIMARY/SECONDARY",
            // TODO: many more fields
        }
    }
}