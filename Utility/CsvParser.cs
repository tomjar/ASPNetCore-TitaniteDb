using System.Text;
using TinyCsvParser;
using titanitedb.Models;

namespace titanitedb.Utility
{
    public class CsvParser
    {
        /// <summary>
        /// Reads a given CSV file using TinyCsvParser. In this case reads a list of rock mineral titanites.
        /// </summary>
        /// <returns>Array of Titanite</returns>
        public static Titanite[] GetTitanitesFromLocalCsvFile()
        {

            // Note: If this fails to locate the csv file, you can manually set the path based on your local machine
            int length = "ASPNetCore-TitaniteDb".Length;
            int titanitedbIndex = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)?.IndexOf("ASPNetCore-TitaniteDb") + length ?? 0;
            var rootPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)?.Substring(0, titanitedbIndex) ?? string.Empty;
            var _filePath = Path.Combine(rootPath, "TITANITES.csv");

            Console.WriteLine(_filePath);

            var csvParserOptions = new CsvParserOptions(true, ',');
            var csvMapper = new CsvTitaniteMapping();
            var tinyCsvParser = new CsvParser<Titanite>(csvParserOptions, csvMapper);

            try
            {
                var result = tinyCsvParser
                    .ReadFromFile(_filePath, Encoding.UTF8)
                    .ToList();

                List<Titanite> titanites = new List<Titanite>();

                result.ForEach(r => 
                {
                    if (r.IsValid)
                    {
                        titanites.Add(new Titanite()
                        {
                            citation = r.Result.citation,
                            sample_name = r.Result.sample_name,
                            tectonic_setting = r.Result.tectonic_setting,
                            location = r.Result.location,
                            location_comment = r.Result.location_comment,
                            latitude_min = r.Result.latitude_min,
                            latitude_max = r.Result.latitude_max,
                            longitude_min = r.Result.longitude_min,
                            longitude_max = r.Result.longitude_max,
                            land_sea_sampling = r.Result.land_sea_sampling,
                            elevation_min = r.Result.elevation_min,
                            elevation_max = r.Result.elevation_max,
                            rock_name = r.Result.rock_name,
                            rock_texture = r.Result.rock_texture,
                            drilling_depth_min = r.Result.drilling_depth_min,
                            drilling_depth_max = r.Result.drilling_depth_max,
                            alteration = r.Result.alteration,
                            mineral = r.Result.mineral,
                            spot = r.Result.spot,
                            crystal = r.Result.crystal,
                            rim_core_mineral_grains = r.Result.rim_core_mineral_grains,
                            grain_size = r.Result.grain_size,
                            primary_secondary = r.Result.primary_secondary,
                            createdBy = "seed",
                            createdDate = DateTime.Now,
                            modifiedBy = "",
                            modifiedDate = null
                        });
                    }

                });

                 return titanites.ToArray();
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine("all done");
            }
        }

    }
}