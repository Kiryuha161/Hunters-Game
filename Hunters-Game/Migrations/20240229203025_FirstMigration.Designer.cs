﻿// <auto-generated />
using System;
using Hunters_Game.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hunters_Game.Migrations
{
    [DbContext(typeof(HunterDbContext))]
    [Migration("20240229203025_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hunters_Game.Models.Characters.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Character");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Hunters_Game.Models.Stat.CharacterStat", b =>
                {
                    b.Property<int>("CharacterStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterStatId"));

                    b.Property<int>("Acuracy")
                        .HasColumnType("int");

                    b.Property<int>("Attentivines")
                        .HasColumnType("int");

                    b.Property<int>("Brave")
                        .HasColumnType("int");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Endurance")
                        .HasColumnType("int");

                    b.Property<int>("Fortuna")
                        .HasColumnType("int");

                    b.Property<int>("GeneralKnowledge")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<int>("Intellegence")
                        .HasColumnType("int");

                    b.Property<int>("Leadership")
                        .HasColumnType("int");

                    b.Property<int>("MagicEnegyControl")
                        .HasColumnType("int");

                    b.Property<int>("MagicEnergy")
                        .HasColumnType("int");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.Property<int>("Reaction")
                        .HasColumnType("int");

                    b.Property<int>("SpeedAttack")
                        .HasColumnType("int");

                    b.Property<int>("SpeedMove")
                        .HasColumnType("int");

                    b.Property<int>("SpeedThinking")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("SurvivalSkill")
                        .HasColumnType("int");

                    b.Property<int>("TechnicalSkill")
                        .HasColumnType("int");

                    b.Property<int>("WillPower")
                        .HasColumnType("int");

                    b.HasKey("CharacterStatId");

                    b.ToTable("Stats");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CharacterStat");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Hunters_Game.Models.Characters.Hunter", b =>
                {
                    b.HasBaseType("Hunters_Game.Models.Characters.Character");

                    b.Property<int>("HunterStatsId")
                        .HasColumnType("int");

                    b.HasIndex("HunterStatsId")
                        .IsUnique()
                        .HasFilter("[HunterStatsId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Hunter");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Activity = "Охотник",
                            Age = 40,
                            Birthday = new DateTime(1984, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Джеймс",
                            Gender = true,
                            MiddleName = "Джуниор",
                            SecondName = "Адамс",
                            Type = "Человек",
                            HunterStatsId = 1
                        });
                });

            modelBuilder.Entity("Hunters_Game.Models.Stat.HunterStat", b =>
                {
                    b.HasBaseType("Hunters_Game.Models.Stat.CharacterStat");

                    b.Property<int>("HunterId")
                        .HasColumnType("int");

                    b.Property<int>("HunterKnowledge")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("HunterStat");

                    b.HasData(
                        new
                        {
                            CharacterStatId = 1,
                            Acuracy = 50,
                            Attentivines = 50,
                            Brave = 50,
                            Charisma = 50,
                            Endurance = 50,
                            Fortuna = 50,
                            GeneralKnowledge = 50,
                            Health = 50,
                            Intellegence = 50,
                            Leadership = 50,
                            MagicEnegyControl = 30,
                            MagicEnergy = 50,
                            Memory = 50,
                            Reaction = 50,
                            SpeedAttack = 50,
                            SpeedMove = 50,
                            SpeedThinking = 50,
                            Strength = 50,
                            SurvivalSkill = 50,
                            TechnicalSkill = 50,
                            WillPower = 50,
                            HunterId = 1,
                            HunterKnowledge = 50
                        });
                });

            modelBuilder.Entity("Hunters_Game.Models.Characters.Hunter", b =>
                {
                    b.HasOne("Hunters_Game.Models.Stat.HunterStat", "HunterStats")
                        .WithOne()
                        .HasForeignKey("Hunters_Game.Models.Characters.Hunter", "HunterStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HunterStats");
                });
#pragma warning restore 612, 618
        }
    }
}
