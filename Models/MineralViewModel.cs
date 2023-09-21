namespace titanitedb.Models
{
    public class MineralViewModel
    {
        public MineralViewModel(){}
        public MineralViewModel(Titanite t)
        {
            lat_max = t.latitude_max;
            long_max = t.longitude_max;
            rock_name = t.rock_name;
            sample_name = t.sample_name;
            mineral = t.mineral;
            tectonic_setting = t.tectonic_setting;
        }
        public string sample_name { get; set; }
        public string lat_max { get; set; }
        public string long_max { get; set; }
        public string rock_name { get; set; }
        public string mineral { get; set; }
        public string tectonic_setting { get; set; }
    }
}