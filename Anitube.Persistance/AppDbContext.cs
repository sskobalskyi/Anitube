using Anitube.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anitube.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Episode> Episodes { get; set; }

        public DbSet<VoiceoverStudio> VoiceoverStudios { get; set; }
        public DbSet<VoiceoverActor> VoiceoverActors { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<AnimeGenre> AnimeGenres { get; set; }
        public DbSet<AnimeVoiceover> AnimeVoiceovers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Anime
            //Genre to Anime many-to-many retalionship
            modelBuilder.Entity<AnimeGenre>()
                .HasKey(ac => new { ac.AnimeId, ac.CategoryId });
            modelBuilder.Entity<AnimeGenre>()
                .HasOne(ac => ac.Anime)
                .WithMany(a => a.AnimeGenres)
                .HasForeignKey(ac => ac.AnimeId);
            modelBuilder.Entity<AnimeGenre>()
                .HasOne(ac => ac.Category)
                .WithMany(c => c.AnimeGenres)
                .HasForeignKey(ac => ac.CategoryId);

            //Episode to Anime one-to-many relationship
            modelBuilder.Entity<Anime>()
                .HasMany(a => a.Episodes)
                .WithOne()
                .HasForeignKey(e => e.AnimeId)
                .IsRequired();

            //AnimeVoiceover to Anime many-to-many relationship
            modelBuilder.Entity<AnimeVoiceover>()
                .HasKey(av => new { av.AnimeId, av.StudioId });
            modelBuilder.Entity<AnimeVoiceover>()
                .HasOne(av => av.Studio)
                .WithMany(a => a.Animes)
                .HasForeignKey(av => av.StudioId);
            modelBuilder.Entity<AnimeVoiceover>()
                .HasOne(av => av.Anime)
                .WithMany(a => a.Voiceovers)
                .HasForeignKey(av => av.AnimeId);

            //Anime to Comments one-to-many relationship
            modelBuilder.Entity<Anime>()
                .HasMany(a => a.Comments)
                .WithOne()
                .HasForeignKey(c => c.AnimeId)
                .IsRequired();
            #endregion

            #region User
            //User to Comments one-to-many relationship
            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne()
                .HasForeignKey(c => c.UserId)
                .IsRequired();
            #endregion
        }
    }
}