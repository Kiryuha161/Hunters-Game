using System;
using Hunters_Game.Common.Enums;
using Hunters_Game.Models;
using Hunters_Game.Models.Academies;
using Hunters_Game.Models.Academies.Departments;
using Hunters_Game.Models.Characters;
using Hunters_Game.Models.Location;
using Hunters_Game.Models.Location.LocationProperties;
using Hunters_Game.Models.Stat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Hunters_Game.Data
{
    public class HunterDbContext : DbContext
    {
        public HunterDbContext(DbContextOptions<HunterDbContext> dbContextOptions) : base(dbContextOptions) { }

        //В случае новой бд проверить сущность Hunter на соответствие словарей

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
                HunterStatsId = 1,
                RegionId = 1,
                TerritoryId = 5,
                AreaId = 3,
                CityId = 4,
                DisсtrictId = 7,
                CurrentLocationId = 5,
                AcademyId = 1,
                DepartmentId = 1
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

            modelBuilder.Entity<Region>().HasData(
                new Region
                {
                    RegionId = 1,
                    Name = "Тиаленд",
                    Desctription = "Тиаленд - крупнейший регион, послуживший началом ассоциации охотников, первой академии охоты. Является наиболее " +
                    "оснащённым в плане охоты, так как собирает в себе самых опытных и способных охотников. Сам регион очень богат различными ресурсами, " +
                    "самый безопасный из всех из-за огромного бюджета, вкладываемого в безопасность (большинство представителей Совета Ассоциации представляют " +
                    "этот регион). Достаточно много магической энергии находится в Тиаленде, что наделяет охотников в этом регионе прекрасным потенциалом в " +
                    "деле развития магии и артефактов."
                },
                new Region
                {
                    RegionId = 2,
                    Name = "Руас",
                    Desctription = "Руас - обширнейший регион, где обитатель может встретить как снежные пустыни в одной части, так и жаркие оазисы на другой. " +
                    "Северная сторона походит на полуостров, с трёх сторон, омываемая морем иэта часть самая морозная из всех. Южное же направление переходит " +
                    "от умеренного климата к тёплым районам. Богат Руас на природные искапаемые как классической, так и сверхъестественной природы. Проходит " +
                    "по центру лишь одна крупная река Акера (входит в тройку крупнейших), соединяющая два моря с двух сторон, из тех, что контролируют из" +
                    " Руасской Академии Охоты. Другие же контролирует Гомранская Академя Охоты. Через неё можно войти в море региона Тонг. Остальные водоёмы " +
                    "весьма мелки и на них не проходят пути сообщения между областями региона, а также охота."
                },
                new Region
                {
                    RegionId = 3,
                    Name = "Лорас",
                    Desctription = "Лорас - наименее безопасный регион, окружённый огромными речными путями. Оттого там высоко развита морская охота. В" +
                    " то же время низкая безопасность обусловлена нашествием демонов в этот регион, которое разрушило множество городов, охотников и " +
                    "усложнило охоту. Однако постепенно, помощь со стороны Ассоциации помогает справиться с этой напастью. Ранее это был один из самых " +
                    "процветающих регионов, но с нынешними темпами развития, если удастся наладить безопасность, ему под силу восстановиться достаточно скоро."
                },
                new Region
                {
                    RegionId = 4,
                    Name = "Тонг",
                    Desctription = "Тонг - азиатская часть континента. Много лесов, болотистых земель, вулканов, периодически извергающихся. Две академии, " +
                    "расположенный в этом регионе наиболее молодые, что делает безопасность региона не самой большой. Но в то же время, разнообразие " +
                    "флоры и фауны, создаёт богатые возможности для развития академий и охоты на этой территории."
                },
                new Region
                {
                    RegionId = 5,
                    Name = "Неизведанные земли",
                    Desctription = "На неизведанные земли нога разумного человека не ступит на данном этапе. Но цель каждой академии и ассоциаиции достичь " +
                    "уровня, чтобы навести порядок у себя в регионах, а после совершить экспансию в эти земли полные опасностей, опасных биомов и " +
                    "могущественных существ полубожественного уровня."
                });

            modelBuilder.Entity<Territory>().HasData(
                new Territory
                {
                    TerritoryId = 1,
                    Name = "Юграс",
                    Desctription = "Территория в центре Юга, подконтрольного Руасской Академией Охоты, с умеренным климатом. Через её западную часть " +
                    "течёт величественная Акера. Регион максимально развитый, он является столицей Южной столицей региона. Все торговые пути пересекаются " +
                    "здесь, что аккумулирует развитие территории. В одной из областей Оскар, в городе Плея, расположилась Руасская Академия Охоты, " +
                    "готовая принять в свои ряды кандидатов в герои. Территория максимально урбанизирована и специализируется на торговле, производстве " +
                    "и услугах. Богата на элементалей.",
                    RegionId = 2
                },
                new Territory
                {
                    TerritoryId = 2,
                    Name = "Изомар",
                    Desctription = "Самая тёплая территория в Руасе в южной его части. Границы территории проходят по морскому побережью, что " +
                    "сосредотачивает большинство морских охотников Руасской академии охоты на этой территории. Богата демонами",
                    RegionId = 2
                },
                new Territory
                {
                    TerritoryId = 3,
                    Name = "Вусл",
                    Desctription = "Прохладный регион, проходящий посредником между севером и югом Руаса. Богата вампирами",
                    RegionId = 2
                },
                new Territory
                {
                    TerritoryId = 4,
                    Name = "Сириб",
                    Desctription = "Морозный край, заполненный озлобленным местным населением, снежной пустыней, гигантами, вампирами и магами холода",
                    RegionId = 2
                },
                new Territory
                {
                    TerritoryId = 5,
                    Name = "Арос",
                    Desctription = "Северо-западная территория часть величайшего региона, с которого началась история ассоциации",
                    RegionId = 1
                });

            modelBuilder.Entity<Area>().HasData(
                new Area
                {
                    AreaId = 1,
                    Name = "Гранд",
                    Desctription = "Западная область центральной территории Юграс. Проходит по границе с Изомаром",
                    TerritoryId = 1
                },
                new Area
                {
                    AreaId = 2,
                    Name = "Оскар",
                    Desctription = "Самая крупная область Юграса, находящаяся по центру и граничащая с рекой Акера. Температура средняя, но холоднее, чем в" +
                    " области Гранд.",
                    TerritoryId = 1
                },
                new Area
                {
                    AreaId = 3,
                    Name = "Зиквейль",
                    Desctription = "Прибрежная часть Ароса и Тиаленда, представляющая собой один из \"краёв\" мира. Коробали там не ходят, разве что " +
                    "теплоходы на экскурсию, зато это очень распространённое место для отдыха туристов.",
                    TerritoryId = 5
                },
                new Area
                {
                    AreaId = 4,
                    Name = "Платор",
                    Desctription = "Одна из областей Изомара.",
                    TerritoryId = 2
                },
                new Area
                {
                    AreaId = 5,
                    Name = "Гилнорт",
                    Desctription = "Одна из областей Вусла.",
                    TerritoryId = 3
                },
                new Area
                {
                    AreaId = 6,
                    Name = "Накра",
                    Desctription = "Одна из областей Сириба",
                    TerritoryId = 4
                });

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    CityId = 1,
                    Name = "Ган",
                    Desctription = "Город, представляющий собой большое равнинное поле, которое изредка разбавляют дома, промышленные здания, магазины и стадион",
                    AreaId = 1
                },
                new City
                {
                    CityId = 2,
                    Name = "Мерра",
                    Desctription = "Город, представляющий собой равнинную местность, обрамлённую горами с юга.",
                    AreaId = 1
                },
                new City
                {
                    CityId = 3,
                    Name = "Плея",
                    Desctription = "Город, в котором находится академия. На въезде и выезде постоянные пробки из-за центрального расположения города," +
                    " являющегося воротами в северную часть Руаса, единственно контролируемую Руасской Академией Охоты. Столица Оскара и Юграса",
                    AreaId = 2
                },
                new City
                {
                    CityId = 4,
                    Name = "Аксель",
                    Desctription = "Город, породивший ассоциацию и первую академию охоты. Достаточно безопасная часть суши, охраняемая горами и реками, " +
                    "ведущими к Великому морю",
                    AreaId = 3
                },
                new City
                {
                    CityId = 5,
                    Name = "Финея",
                    Desctription = "Город области Платор в Изомаре, полный талантливых и творческих людей. Отсюда вышло множество звёзд и артистов.",
                    AreaId = 4
                },
                new City
                {
                    CityId = 6,
                    Name = "Рона",
                    Desctription = "Город области Гилнорт в Вусле, где климат достаточно разнообразен. Зимой там чрезвычайно холодно, а летом население " +
                    "терпит сильнейшую жару. Из-за этого у его жителей хорошая акклиматизация и сильный иммунитет.",
                    AreaId = 5
                },
                new City
                {
                    CityId = 7,
                    Name = "Сноуден",
                    Desctription = "Город области Накра в Сирибе, где население терпит сильнейшие морозы, банды мародёров, гигантов и вампиров.",
                    AreaId = 6
                });

            Random random = new Random();
            int dangerRatioRandom = random.Next(0, 10);

            modelBuilder.Entity<District>()
               .HasIndex(d => d.AcademyResponsibleId)
               .IsUnique(false);

            modelBuilder.Entity<District>().HasData(
                new District
                {
                    DistrictId = 1,
                    Name = "Северная Мерра",
                    Desctription = "Наиболее равнинная часть Мерры",
                    CityId = 2,
                    DangerRatio = dangerRatioRandom,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 2,
                    Name = "Южная Мерра",
                    Desctription = "Наиболее гористая часть Мерры",
                    CityId = 2,
                    DangerRatio = dangerRatioRandom,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 3,
                    Name = "Северный Ган",
                    Desctription = "Ветренное поле, изредка разбавленное домами и промышленными зданиями. Немного разнообразия добавляет футбольный стадион",
                    CityId = 1,
                    DangerRatio = dangerRatioRandom,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 4,
                    Name = "Южный Ган",
                    Desctription = "Ветренное поле, изредка разбавленное домами и промышленными зданиями",
                    CityId = 1,
                    DangerRatio = dangerRatioRandom,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 5,
                    Name = "Северная Плея",
                    Desctription = "Часть города Плея, которая неимоверно загружена пробками, в том числе и потому, что там расположена Академия и " +
                    "большинство административных зданий",
                    CityId = 3,
                    DangerRatio = dangerRatioRandom,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 6,
                    Name = "Южная Плея",
                    Desctription = "Граничащая с областью Марка, представляет собой менее развитую часть города. При этом она менее нагружена.",
                    CityId = 3,
                    DangerRatio = dangerRatioRandom,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 7,
                    Name = "Северный Аксель",
                    Desctription = "Торговая и промышленная часть города.",
                    CityId = 4,
                    AcademyResponsibleId = 2
                },
                new District
                {
                    DistrictId = 8,
                    Name = "Южный Аксель",
                    Desctription = "Административная часть города, в которой находится Первая академия охоты.",
                    CityId = 4,
                    AcademyResponsibleId = 2
                },
                new District
                {
                    DistrictId = 9,
                    Name = "Северная Финея",
                    Desctription = "Северная часть города Финея",
                    CityId = 5,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 10,
                    Name = "Южная Финея",
                    Desctription = "Южная часть города Финея",
                    CityId = 5,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 11,
                    Name = "Северная Рона",
                    Desctription = "Северная часть города Рона",
                    CityId = 6,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 12,
                    Name = "Южная Рона",
                    Desctription = "Южная часть города Рона",
                    CityId = 6,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 13,
                    Name = "Северный Сноуден",
                    Desctription = "Северная часть города Сноуден",
                    CityId = 7,
                    AcademyResponsibleId = 1
                },
                new District
                {
                    DistrictId = 14,
                    Name = "Южный Сноуден",
                    Desctription = "Южная часть города Сноуден",
                    CityId = 7,
                    AcademyResponsibleId = 1
                });

            modelBuilder.Entity<Academy>().HasData(
                   new Academy
                   {
                       AcademyId = 1,
                       Name = "Руасская академия охоты",
                       Description = "Академия была построена в условиях бушующей популяции и коэффициента, а также в условиях холодного климата на долгое " +
                       "время в одной части и теплого в другой. Этот климатический стык обусловил глубокий интерес местных охотников к влиянию климата и " +
                       "территорий на образовавшуюся популяцию. Другие направления академия также стремиться не забрасывать.",
                       TotalKnowledge = 20,
                       DistrictAcademyId = 5,
                   },
                   new Academy
                   {
                       AcademyId = 2,
                       Name = "Международный университет охоты",
                       Description = "Первая академия в ассоциации, наиболее умеренная во всех направлениях, но в то же время наиболее сильная, полная " +
                       "опытнейшими и могущественными охотниками.",
                       TotalKnowledge = 65,
                       DistrictAcademyId = 8,
                   });

            modelBuilder.Entity<Department>().HasData(
                    new Department
                    {
                        DepartmentId = 1,
                        Name = "Ректорат",
                        Description = "Занимается управлением академией"
                    },
                    new Department
                    {
                        DepartmentId = 2,
                        Name = "Следственный департамент",
                        Description = "Занимается расследованием различных дел по заявкам от жителей региона"
                    },
                    new Department
                    {
                        DepartmentId = 3,
                        Name = "Департамент резерва",
                        Description = "Сюда попадают охотники после бакалавриата в академии, а также те, кто пока не попал в другие департаменты. " +
                        "Занимаются помощью другим департаментам в случае необходимости."
                    }
                );

            modelBuilder.Entity<Hunter>()
            .HasOne(h => h.HunterStats)
            .WithOne()
            .HasForeignKey<Hunter>(h => h.HunterStatsId);

            modelBuilder.Entity<Hunter>()
             .HasOne(h => h.City)
             .WithMany()
             .HasForeignKey(h => h.CityId)
             .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Disсtrict)
                .WithMany()
                .HasForeignKey(h => h.DisсtrictId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.CurrentLocation)
                .WithMany()
                .HasForeignKey(h => h.CurrentLocationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Region)
                .WithMany()
                .HasForeignKey(h => h.RegionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Territory)
                .WithMany()
                .HasForeignKey(h => h.TerritoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Academy)
                .WithMany()
                .HasForeignKey(h => h.AcademyId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Department)
                .WithMany()
                .HasForeignKey(h => h.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<District>()
             .HasMany(d => d.Creatures)
             .WithOne()
             .HasForeignKey("DistrictId")
             .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<District>()
                .HasOne(d => d.AcademyResponsible)
                .WithMany()
                .HasForeignKey(a => a.AcademyResponsibleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Area>()
                .HasMany(a => a.Creatures)
                .WithOne()
                .HasForeignKey("AreaId")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Creatures)
                .WithOne()
                .HasForeignKey("CityId")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Territory>()
                .HasMany(t => t.Creatures)
                .WithOne()
                .HasForeignKey("TerritoryId")
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Region>()
                .HasMany(r => r.Creatures)
                .WithOne()
                .HasForeignKey("RegionId")
                .OnDelete(DeleteBehavior.NoAction);
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
        public DbSet<District> Districts { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<EnvironmentPropertiesDescription> EnvironmentPropertiesDescriptions { get; set; }
        public DbSet<EnvironmentPropertiesCount> EnvironmentPropertiesCounts { get; set; }
        public DbSet<EnvironmentPropertiesBoolean> EnvironmentPropertiesBooleans { get; set; }
        public DbSet<Academy> Academies { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}

