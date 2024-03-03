using System;
using Hunters_Game.Models;
using Hunters_Game.Models.Characters;
using Hunters_Game.Models.Location;
using Hunters_Game.Models.Stat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Hunters_Game.Data
{
    public class HunterDbContext : DbContext
    {
        public HunterDbContext(DbContextOptions<HunterDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected internal virtual void ConfigureEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hunter>().HasData(new Hunter
            {
                SecondName = "Адамс",
                FirstName = "Джеймс",
                MiddleName = "Джуниор",
                Type = "Человек",
                Activity = "Охотник",
                Gender = true,
                Birthday = new DateTime(1984, 04, 04),
                Age = 40,
                CharacterId = 1,
                HunterStatsId = 1
            });

            modelBuilder.Entity<HunterStat>().HasData(new HunterStat
            {
                Acuracy = 50,
                Attentivines = 50,
                Brave = 50,
                HunterId = 1,
                Charisma = 50,
                Endurance = 50,
                Fortuna = 50,
                GeneralKnowledge = 50,
                Health = 50,
                HunterKnowledge = 50,
                Intellegence = 50,
                Leadership = 50,
                MagicEnegyControl = 30,
                MagicEnergy = 50,
                Memory = 50,
                Reaction = 50,
                Strength = 50,
                SpeedAttack = 50,
                SpeedMove = 50,
                SpeedThinking = 50,
                SurvivalSkill = 50,
                TechnicalSkill = 50,
                WillPower = 50,
                CharacterStatId = 1
            });

            modelBuilder.Entity<Hunter>()
            .HasOne(h => h.HunterStats)
            .WithOne()
            .HasForeignKey<Hunter>(h => h.HunterStatsId);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureEntities(modelBuilder);
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Hunter> Hunters { get; set; }
        public DbSet<CharacterStat> Stats { get; set; }
        public DbSet<HunterStat> HunterStats { get; set; }
        public DbSet<Mail> Mails { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Disctrict> Disctricts { get; set; }
    }
}

