using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using titanitedb.Models;

namespace titanitedb.Data
{
    public class TitaniteDbContext : DbContext
    {
        public TitaniteDbContext(DbContextOptions<TitaniteDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Titanite> Titanites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();

            modelBuilder.Entity<Titanite>()
                .Property(e => e.citation)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.sample_name)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.tectonic_setting)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.location_comment)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.latitude_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.latitude_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.longitude_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.longitude_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.land_sea_sampling)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.elevation_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.elevation_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.rock_name)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.rock_texture)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.drilling_depth_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.drilling_depth_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.alteration)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.mineral)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.spot)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.crystal)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.rim_core_mineral_grains)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.grain_size)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.primary_secondary)
                .IsUnicode(false);
        }
    }
}