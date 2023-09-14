using System.ComponentModel.DataAnnotations.Schema;

namespace titanitedb.Models
{
    [Table("Titanite")]
    public partial class Titanite : Mineral
    {
        public Titanite() : base() { }

        [Column(TypeName = "text")]
        public string citation { get; set; }

        [Column(TypeName = "text")]
        public string sample_name { get; set; }

        [Column(TypeName = "text")]
        public string tectonic_setting { get; set; }

        [Column(TypeName = "text")]
        public string location { get; set; }

        [Column(TypeName = "text")]
        public string location_comment { get; set; }

        [Column(TypeName = "text")]
        public string latitude_min { get; set; }

        [Column(TypeName = "text")]
        public string latitude_max { get; set; }

        [Column(TypeName = "text")]
        public string longitude_min { get; set; }

        [Column(TypeName = "text")]
        public string longitude_max { get; set; }

        [Column(TypeName = "text")]
        public string land_sea_sampling { get; set; }

        [Column(TypeName = "text")]
        public string elevation_min { get; set; }

        [Column(TypeName = "text")]
        public string elevation_max { get; set; }

        [Column(TypeName = "text")]
        public string rock_name { get; set; }

        [Column(TypeName = "text")]
        public string rock_texture { get; set; }

        [Column(TypeName = "text")]
        public string drilling_depth_min { get; set; }

        [Column(TypeName = "text")]
        public string drilling_depth_max { get; set; }

        [Column(TypeName = "text")]
        public string alteration { get; set; }

        [Column(TypeName = "text")]
        public string mineral { get; set; }

        [Column(TypeName = "text")]
        public string spot { get; set; }

        [Column(TypeName = "text")]
        public string crystal { get; set; }

        [Column(TypeName = "text")]
        public string rim_core_mineral_grains { get; set; }

        [Column(TypeName = "text")]
        public string grain_size { get; set; }

        [Column(TypeName = "text")]
        public string primary_secondary { get; set; }
    }
}
