using System;
using Hunters_Game.Common.Enums;
using Hunters_Game.Models;
using Hunters_Game.Models.Academies;
using Hunters_Game.Models.Academies.Departments;
using Hunters_Game.Models.Characters;
using Hunters_Game.Models.Location;
using Hunters_Game.Models.Location.LocationProperties;
using Hunters_Game.Models.Ranks;
using Hunters_Game.Models.Stat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Hunters_Game.Data
{
    public class HunterDbContext : DbContext
    {
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
        public DbSet<AcademicDegree> AcademicDegrees { get; set; }
        public DbSet<AcademicRank> AcademicRanks { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<PostGrade> PostGrades { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<TheoryDegree> TheoryDegrees { get; set; }
        public DbSet<Status> Statuts { get; set; }
        public DbSet<Specialization> Specializations { get; set; }

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
                DepartmentId = 1,
                Rate = 4.34f,
                RankId = 4,
                LevelId = 6,
                PostGradeId = 5,
                TheoryDegreeId = 5,
                AcademicDegreeId = 2,
                AcademicRankId = 3,
                StatusId = 3,
                StartHunt = new DateTime(2014, 09, 1),
                Stage = 11
            });

            modelBuilder.Entity<HunterStat>().HasData(new HunterStat
            {
                Acuracy = 67,
                Attentivines = 62,
                Brave = 76,
                HunterId = 1,
                Charisma = 64,
                Endurance = 56,
                Fortuna = 76,
                GeneralKnowledge = 68,
                Health = 86,
                HunterKnowledge = 94,
                Intellegence = 89,
                Leadership = 62,
                MagicEnegyControl = 75,
                MagicEnergy = 76,
                Memory = 66,
                Reaction = 62,
                Strength = 76,
                SpeedAttack = 68,
                SpeedMove = 65,
                SpeedThinking = 75,
                SurvivalSkill = 84,
                TechnicalSkill = 94,
                WillPower = 75,
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
                        Description = "Занимается управлением академией",
                        PostName = "Член ректората"
                    },
                    new Department
                    {
                        DepartmentId = 2,
                        Name = "Следственный департамент",
                        Description = "Департамент расследований - одно из приоритетных направлений в охоте. Занимаются тем, что расследуют заявления населения, " +
                        "выполняют расследования при происшествиях, выполняют поручения департамента хранителей, в случае необходимости",
                        PostName = "Следователь"
                    },
                    new Department
                    {
                        DepartmentId = 3,
                        Name = "Департамент резерва",
                        Description = "Сюда попадают охотники после бакалавриата в академии, а также те, кто пока не попал в другие департаменты. " +
                        "Занимаются помощью другим департаментам в случае необходимости.",
                        PostName = "Охотник резерва"
                    },
                    new Department
                    {
                        DepartmentId = 4,
                        Name = "Военный департамент",
                        Description = "Занимается патрулированием населённых пунктов, защитными и атакующими военными действиями, обеспечением порядка, подключением " +
                        "к устранению, задержаний и запечатыванию существ, разведкой территорий и так далее.",
                        PostName = "Военный охотник"
                    },
                    new Department
                    {
                        DepartmentId = 5,
                        Name = "Биологический департамент",
                        Description = "Биологический департамент - департамент, занимается исследованием существ, сбором, изучением и выращиванием трав, изучением климата и " +
                        "так далее",
                        PostName = "Биолог"
                    },
                    new Department
                    {
                        DepartmentId = 6,
                        Name = "Инженерный департамент",
                        Description = "Инженерный департамент занимается производством, хранением, обслуживанием, проектированием технической части, " +
                        "а также выступает поддержкой во время операций",
                        PostName = "Инженер"
                    },
                    new Department
                    {
                        DepartmentId = 7,
                        Name = "Департамент хранителей",
                        Description = "Департамент хранителей - важный департамент, занимающийся внешней и внутренней разведкой, тайными операциями, переговорами с" +
                        " высшими существами",
                        PostName = "Хранитель"
                    },
                    new Department
                    {
                        DepartmentId = 8,
                        Name = "Департамент магии",
                        Description = "Департамент магии занимается изучением магии, артефактов, борется с магами. Магия требует большой силы воли, так как сводит с ума",
                        PostName = "Охотник магического департамента"
                    },
                    new Department
                    {
                        DepartmentId = 9,
                        Name = "Медицинский департамент",
                        Description = "Медицинский департамент - департамент, занимающийся лечением пострадавших охотников и оказыванием медицинской " +
                        "поддержки во время операций",
                        PostName = "Медик"
                    },
                    new Department
                    {
                        DepartmentId = 10,
                        Name = "Департамент искателей",
                        Description = "Департамент искателей занимается поиском магических артефактов и их исследованием",
                        PostName = "Хранитель"
                    },
                    new Department
                    {
                        DepartmentId = 11,
                        Name = "Научный департамент",
                        Description = "Департамент, занимающийся научной деятельностью, исследованиями и экспертизами.",
                        PostName = "Научный сотрудник"
                    }
                );

            modelBuilder.Entity<Level>().HasData(
                    new Level
                    {
                        LevelId = 1,
                        Name = "Новичок",
                        Description = "Как правило, это охотники, недавно выпустившиеся из академии и проходящие стажировку. Им следует давать самые лёгкие задачи (E), " +
                        "шанс на печальные последствия от которых минимальны. Так же им необходимо кураторство более опытных охотников, чтобы эффективность их" +
                        " работы была более-менее положительна. Он может занимать должность не выше младшего охотника. Эквивалентно рядовому-ефрейтору в " +
                        "зависимости от опыта и личных качеств.",
                        LevelType = LevelType.Rookie
                    },
                    new Level
                    {
                        LevelId = 2,
                        Name = "Подмастерье",
                        Description = "Этот охотник прошёл этап стажировки и уже способен выполнять более сложные задачи (E, D) под руководством своего начальства. " +
                        "Растёт он благодаря опыту, системе обучения от департамента и академии, а также благодаря выбранному куратору - охотнику с уровнем не ниже мастера." +
                        "Он может занимать должность младший охотник или охотник специалист, в зависимости от ранга. Эквивалентно мл.сержанту-старшине в зависимости от ранга.",
                        LevelType = LevelType.Apprentice
                    },
                    new Level
                    {
                        LevelId = 3,
                        Name = "Специалист",
                        Description = "Охотник, который получил уровень специалиста, уже способен выполнять лёгкие задачи повышенной сложности (D) самостоятельно." +
                        " Может иметь должность охотник-специалист. Эквивалентно мл.лейтенанту-ст.лейтенанту в зависимости от ранга.",
                        LevelType = LevelType.Specialist
                    },
                    new Level
                    {
                        LevelId = 4,
                        Name = "Эксперт",
                        Description = "Достаточно опытный охотник, способный браться за задачи средней сложности (C, B) самостоятельно в качестве лидера группы и успешно привести " +
                        "её к успеху. Может занимать должность охотник-специалист или старший охотник, в зависимости от ранга. Во втором случае способен возглавлять " +
                        "управление по областям. Эквивалентно капитану-майору в зависимости от ранга.",
                        LevelType = LevelType.Expert
                    },
                    new Level
                    {
                        LevelId = 5,
                        Name = "Мастер",
                        Description = "Высококлассный охотник, способный возглавлять большие группы и даже подразделения департамента, отвечающие за территории, " +
                        "разумеется в зависимости от ранга. От этого же зависит на какую должность может претендовать мастер - старший охотник или главный охотник. " +
                        "Становится куратором для подмастерий. Берутся за сложные задания (A). Эквивалентно подполковнику-полковнику в зависимости от должности.",
                        LevelType = LevelType.Master
                    },
                    new Level
                    {
                        LevelId = 6,
                        Name = "Грандмастер",
                        Description = "Наиболее искуссный охотник, которым назначают решение задач особой сложности (S). Карьерный путь охотника такого уровня позволяет " +
                        "ему быть главой департамента в качестве ведущего охотник департамента, члена ректората или ректора,члена совета ассоциации и даже магистра совета, вплоть до главы ассоциации. " +
                        "Эквивалентно генеральским званиям в зависимости от должности.",
                        LevelType = LevelType.GrandMaster
                    }
                );

            modelBuilder.Entity<Rank>().HasData(
                    new Rank
                    {
                        RankId = 1,
                        Name = "Младший охотник",
                        Description = "Этот ранг обычно носят новички и подмастерья, которые ещё не успели набраться опыта. С таким рангом они могут претендовать лишь на " +
                        "должности младших представителей департамента, занимающихся стажировкой и вспомогательной работой.",
                        RanksType = RanksType.Junior
                    },
                    new Rank
                    {
                        RankId = 2,
                        Name = "Охотник",
                        Description = "Ранг охотника могут получить подмастерья и охотники-специалисты, которые имеют стаж охоты более года, выполневших " +
                        "более 15 E-задач и более 10 D-задач. Кроме того, они должны окончить магистратуру в академии. Это даст им право работать на должности " +
                        "охотника-специалиста.",
                        RanksType = RanksType.Middle
                    },
                    new Rank
                    {
                        RankId = 3,
                        Name = "Старший охотник",
                        Description = "Охотники этого ранга имеют охотники-специалисты и старшие охотники департамента с уровнем эксперт и стажем более 3 лет. " +
                        "Также они должны окончить аспирантуру академии и иметь хотя бы одну специализацию общего типа. Существует требование в успешном участии в " +
                        "10 C-задачах и 3 B-задачах.",
                        RanksType = RanksType.Senior
                    },
                    new Rank
                    {
                        RankId = 4,
                        Name = "Охотник высшей категории",
                        Description = "Такой ранг позволяет занимать должность старшего, главного и высшего охотника департамента, а также занимать должность в ректорате, " +
                        "совете ассоциации вплоть до её возглавления. В качестве требования к ней - не менее 7 лет стажа в охоте, учёная степень, 3 специализации общего типа " +
                        "и одна специализация продвинутого типа. В качестве других требований - успешное участие в 10 B-задачах и 5 A-задачах."
                    }
                );

            modelBuilder.Entity<PostGrade>().HasData(
                    new PostGrade
                    {
                        PostGradeId = 1,
                        Name = "Младший",
                        Description = "Занимается не сложной работой, E и D-заданиями. Редко когда получают ответственные и сложные задачи. Является больше помощником, " +
                        "чем основном охотником-специалистом. Эквивалентно рядовому.",
                        PostGradeType = PostGradeType.Junior
                    },
                    new PostGrade
                    {
                        PostGradeId = 2,
                        Name = "Специалист",
                        Description = "Более-менее опытный охотник. Может руководить группой, если она сформирована при выполнении D-заданиях. " +
                        "Если охотник способный - может быть назначен лидером при C-задаче. Выполняет основную работу, требующую определённых навыков и подразумевающую риск." +
                        " Как правило, охотник-специалист, иногда эксперт. Эквивалентно сержантской-лейтенантской должности.",
                        PostGradeType = PostGradeType.Middle
                    },
                    new PostGrade
                    {
                        PostGradeId = 3,
                        Name = "Старший",
                        Description = "Опытный охотник с уровнем не ниже эксперта и рангом не ниже старшего охотника. Может управлять подразделением по области, " +
                        "то есть несколькими группами. Как правило, достаточно сильный боец и управленец, с хорошей базой знаний на определённую тему. " +
                        "Руководит C, B - задачами. Эквивалентно капитанской-майорской должности.",
                        PostGradeType = PostGradeType.Senior
                    },
                    new PostGrade
                    {
                        PostGradeId = 4,
                        Name = "Главный",
                        Description = "Глава нескольких подразделения. Обязательно охотник высшей категории. Руководит A-задачами и участвует в S-задачах. " +
                        "Эквивалентно должности подполковника-полковника",
                        PostGradeType = PostGradeType.Chief
                    },
                    new PostGrade
                    {
                        PostGradeId = 5,
                        Name = "Высший",
                        Description = "Глава департамента. Как правило, охотник уровня грандмастер, если таковые имеются. Может руководить S-задачами. " +
                        "Эквивалетно генеральской должности.",
                        PostGradeType = PostGradeType.Leader
                    }
                );

            modelBuilder.Entity<TheoryDegree>().HasData(
                    new TheoryDegree
                    {
                        TheoryDegreeId = 1,
                        Name = "Абитуриент",
                        Description = "Охотник, учащийся в академии наук, но ещё не окончивший её.",
                        TheoryType = TheoryDegreeType.Applicant
                    },
                    new TheoryDegree
                    {
                        TheoryDegreeId = 2,
                        Name = "Бакалавр",
                        Description = "Охотник, выпустившийся из академии. Имеет право на стажировку в каком-либо департаменте на должности младшего охотника департамента.",
                        TheoryType = TheoryDegreeType.Bachelor
                    },
                    new TheoryDegree
                    {
                        TheoryDegreeId = 3,
                        Name = "Магистр",
                        Description = "Охотник, получивший 3 степень теоретической подготовленности - магистр. При выполнении других требований открывается доступ к" +
                        " должности охотника-специалиста департамента из-за прохождения более глубокого курса охотничьей деятельности.",
                        TheoryType = TheoryDegreeType.Master
                    },
                    new TheoryDegree
                    {
                        TheoryDegreeId = 4,
                        Name = "Аспирант",
                        Description = "Охотник, получивший 4 степень теоретической подготовленности - аспирант. При выполнении других требований открывается доступ к " +
                        "должности старший охотник департамента, прохождения курса об управлении подразделениями."
                    },
                    new TheoryDegree
                    {
                        TheoryDegreeId = 5,
                        Name = "Учёный",
                        Description = "Охотник, получивший 5 степень теоретической подготовленности - учёный. Он написал и защитил хотя бы одну кандидатскую диссертацию. " +
                        "При выполнении других требований может занять должность главного охотника департамента, так как обладает большим объёмом знаний в определённой области.",
                        TheoryType = TheoryDegreeType.AcademicDegree
                    }
                );

            modelBuilder.Entity<AcademicRank>().HasData(
                    new AcademicRank
                    {
                        AcademicRankId = 1,
                        Name = "Научный сотрудник",
                        Description = "Охотник, который занимается научной деятельностью. Может преподавать в зависимости от своей степени теоретической подготовленности. " +
                        "Магистр может преподавать бакалавриат, аспирант - магистратуру",
                        AcademicRankType = AcademicRankType.Scientist
                    },
                    new AcademicRank
                    {
                        AcademicRankId = 2,
                        Name = "Доцент",
                        Description = "Научный сотрудник, имеющий хотя бы одну защищённую кандидатскую степень, который провёл не " +
                            "менее 15 научных изысканий. Он может обучать в академии на бакалавров, магистров и аспирантов, на общие специализации, а также быть помощником " +
                            "в написании кандидатской диссертации для других соискателей",
                        AcademicRankType = AcademicRankType.AssociateProfessor
                    },
                    new AcademicRank
                    {
                        AcademicRankId = 3,
                        Name = "Профессор",
                        Description = "Научный сотрудник, имеющий хотя бы одну защищённую докторскую степень, который провёл не менее 30 научных изысканийй. " +
                        "Он может обучать на все степени теоретической подготовленности, на общие и продвинутые специализации, в зависимости от своих знаний. " +
                        "Также он может быть помощиником в написании докторской диссертации для других соискателей.",
                        AcademicRankType = AcademicRankType.Professor
                    },
                    new AcademicRank
                    {
                        AcademicRankId = 4,
                        Name = "Академик",
                        Description = "Научный сотрудник, имеющий более 3 диссертаций, который провёл не менее 60 научных изысканий. Он может обучать всему, в том числе на " +
                        "элитные специализации. Руководит научными департаментами и выступает членом, магистром или главой совета ассоциации.",
                        AcademicRankType = AcademicRankType.Academician
                    },
                    new AcademicRank
                    {
                        AcademicRankId = 5,
                        Name = "Без научного звания",
                        Description = "Охотник ещё не успел получить научное звание.",
                        AcademicRankType = AcademicRankType.None
                    }
                );

            modelBuilder.Entity<AcademicDegree>().HasData(
                    new AcademicDegree
                    {
                        AcademicDegreeId = 1,
                        Name = "Кандидат",
                        Description = "Охотник, написавший и защитивший кандидатскую диссертацию по определённой области",
                        AcademicDegreeType = AcademicDegreeType.Candidat
                    },
                    new AcademicDegree
                    {
                        AcademicDegreeId = 2,
                        Name = "Доктор",
                        Description = "Охотник, написавший и защитивший докторскую диссертацию по определённой области",
                        AcademicDegreeType = AcademicDegreeType.Doctor
                    },
                    new AcademicDegree
                    {
                        AcademicDegreeId = 3,
                        Name = "Без научной степени",
                        Description = "Охотник не успел получить научную степень.",
                        AcademicDegreeType = AcademicDegreeType.None
                    }
                );

            modelBuilder.Entity<Status>().HasData(
                    new Status
                    {
                        StatusId = 1,
                        Name = "Без статуса",
                        Description = "Охотник не успел получить статус.",
                        StatusType = StatusType.None
                    },
                    new Status
                    {
                        StatusId = 2,
                        Name = "Отличный охотник",
                        Description = "Охотник со стажем больше пяти лет и рейтингом выше 3.5",
                        StatusType = StatusType.ExcellentHunter
                    },
                    new Status
                    {
                        StatusId = 3,
                        Name = "Охотник-ветеран",
                        Description = "Охотник со стажем больше десяти лет и рейтингом выше 3.75",
                        StatusType = StatusType.Veteran
                    },
                    new Status
                    {
                        StatusId = 4,
                        Name = "Охотник международного класса",
                        Description = "Охотник со стажем больше 15 лет и рейтингом выше 4",
                        StatusType = StatusType.InternationalClassHunter
                    },
                    new Status
                    {
                        StatusId = 5,
                        Name = "Легендарный охотник",
                        Description = "Охотник со стажем больше 20 лет и рейтингом выше 4.25",
                        StatusType = StatusType.Legend
                    }
                );

            modelBuilder.Entity<Specialization>().HasData(
                    new Specialization
                    {
                        SpecializationId = 1,
                        Name = "Без специализации",
                        Description = "Охотник ещё не успел получить специализацию",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 2,
                        Name = "Боец ближнего боя",
                        Description = "Специализация ближний бой, которая говорит о том, что охотник прошёл обучение как боец ближнего боя, обученный немалым количествам" +
                        " приёмов с разными типами оружия. Широкая специализация, которая позволяет использовать большинство не специфичных видов вооружения ближнего боя." +
                        " Влияет на силу, выносливость, ловкость, здоровье, реакцию, скорость атаки, скорость передвижения, смелость, навыки ближнего боя.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 3,
                        Name = "Боец дальнего боя",
                        Description = "Специализация дальний бой, которая говорит о том, что охотник прошёл обучение как боец дальнего боя, обученный немалым " +
                        "количествам приёмов с разными типами оружия. Широкая специализация, которая позволяет использовать большинство не специфичных видов " +
                        "вооружения дальнего боя. Влияет на точность, внимательность, ловкость, реакцию, скорость атаки, скорость передвижения, навыки дальнего боя.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 4,
                        Name = "Следователь",
                        Description = "Специализация следственное дело, которая говорит о том, что охотник прошёл обучение как следователь, способный действовать " +
                        "немалым количеством специальных методов, которые недоступны для окончивших академию без специализации. Позволяет встать на должность " +
                        "старшего следователя. Влияет на внимательность, охотничьи и общие знания, интеллект, скорость мышления, память, следовательские навыки.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 5,
                        Name = "Военный охотник",
                        Description = "Специализация военная охота, которая говорит о том, что охотник прошёл обучение как военный охотник, способный использовать " +
                        "немало нестандартных тактик. Позволяет встать на должность старший военный охотник. Влияет на здоровье, точность, силу, ловкость, " +
                        "выносливость, реакцию, скорость атаки, скорость передвижения, охотничьи знания, внимательность, смелость, лидерство, сила воли,  " +
                        "навыки ближнего и дальнего боя, выживания, навыки военного дела",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 6,
                        Name = "Хранитель",
                        Description = "Специализация хранительство, которая говорит о том, что охотник прошёл обучение как хранитель, способный использовать немало " +
                        "нестандартных подходов в своей деятельности. Позволяет встать на должность старший хранитель. Влияет на внимательность, интеллект, " +
                        "харизма, лидерство, охотничьи и общие знания, основные знания о существах, следовательские навыки, хранительские и боевые навыки.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 7,
                        Name = "Инженер",
                        Description = "Специализация инженерное дело, которая говорит о том, что охотник прошёл обучение как инженер, способный использовать немало " +
                        "нестандартной аппаратуры, способный производить более качественные продукты. Позволяет встать на должность старший инженер. " +
                        "Влияет точность, скорость мышления, интеллект, лидерство, на общие, охотничьи и технические навыки, память.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 8,
                        Name = "Медик",
                        Description = "Специализация медицинское дело, которая говорит о том, что охотник прошёл обучение как медик, способный использовать немало " +
                        "нестандартных медициских техник. Позволяет встать на должность старший медик. Влияет на силу воли, общие и охотничьи знания, технические навыки, " +
                        "навыки выживания, интеллект, внимательность, память, скорость мышления.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 9,
                        Name = "Искатель",
                        Description = "Специализация искательство, которая говорит о том, что охотник прошёл обучение как искатель, способный использовать немало " +
                        "нестандартных решений в процессе своей работы. Позволяет встать на должность старшего искателя. Влияет на внимательность, память, интеллект, " +
                        "следовательские навыки, магические знания и навыки, боевые навыки, силу, здоровье, ловкость, точность и выносливость, общие и охотничьи " +
                        "навыки, скорость передвижения.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 10,
                        Name = "Магический охотник",
                        Description = "Специализация магическая охота, которая говорит о том, что охотник прошёл обучение как магический охотник, знающий множество " +
                        "способов исследовать магию. Позволяет встать на должность старшего мага. Влияет на силу воли, магические знания и навыки, интеллект, " +
                        "научные знания и навыки, общие и охотничьи знания, скорость мышления, внимательность.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 11,
                        Name = "Биолог",
                        Description = "Специализация биология, которая говорит о том, что охотник прошёл обучение как биолог, знающий множество " +
                        "способов изучения биология и обладающий более глубокими знаниями в этом направлении. Позволяет занимать должность старшего биолога. Влияет на " +
                        "научные знания и навыки, общие и охотничьи знания, интеллект, скорость мышления, внимательность, память.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 12,
                        Name = "Научный деятель",
                        Description = "Специализация научное дело, которая говорит о том, что охотник прошёл обучение как научный деятель, способный к " +
                        "нестандартным решениями и глубокой базе знаний. Позволяет занимать должность старшего научного сотрудника. Влияет на внимательность, " +
                        "общие и охотничьи знания, научные навыки, память, интеллект, скорость мышления.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 13,
                        Name = "Управленец",
                        Description = "Специализация управление, которая говорит о том, что охотник прошёл обучение как управленец, способный управлять большим " +
                        "количеством людей и организаций. Позволяет встать на должность в ректорате. Влияет на харизму, лидерство, интеллект, силу воли, внимательность, " +
                        "скорость мышления, смелость, общие и охотничьи знания.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 14,
                        Name = "Пользователь артефактов",
                        Description = "Специализация использование артефактов позволяет охотнику использовать различные виды артефактов и умело распределять в себе " +
                        "магическую энергию. Влияет на силу воли, магические знания и навыки, контроль магии, силу, ловкость, точность, реакцию, " +
                        "скорость передвижения, смелость, точность.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 15,
                        Name = "Охотник на нежить",
                        Description = "Специализация охота на нежить говорит об охотнике, который обучался различным способам охоты на нежить и знает немало нестандартных " +
                        "способов их устранения. Влияет на все боевые навыки, охотничьи знания и знания нежити.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 16,
                        Name = "Охотник на демонов",
                        Description = "Специализация охота на демонов говорит о человеке с хорошим навыком охоты на демонов и знанием демонологии.",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 17,
                        Name = "Охотник на духов",
                        Description = "Специализация охотник на духов говорит о человеке с хорошим навыком охоты на духов",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 18,
                        Name = "Охотник на звероподобных существ",
                        Description = "Специализация охотник на звероподобных существ говорит о человеке с хорошим навыком охоты на звероподобных существ",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 19,
                        Name = "Охотник на гигантов",
                        Description = "Специализация охотник на гигантов говорит о человеке с хорошим навыком охоты на гигантов",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 20,
                        Name = "Охотник на летающих существ",
                        Description = "Специализация охотник на летающих существ говорит о человеке с хорошим навыком охоты на летающих существ",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 21,
                        Name = "Охотник на водных существ",
                        Description = "Специализация охотник на водных существ говорит о человеке с хорошим навыком охоты на водных существ",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 22,
                        Name = "Охотник на подземных существ",
                        Description = "Специализация охотник на подземных существ говорит о человеке с хорошим навыком охоты на подземных существ",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 23,
                        Name = "Охотник на элементалей",
                        Description = "Специализация охотник на элементалей говорит о человеке с хорошим навыком охоты на элементалей",
                        ParentId = 0
                    },
                    new Specialization
                    {
                        SpecializationId = 24,
                        Name = "Мечник",
                        Description = "Углублённая специализация ближнего боя, подтверждающая обучение охотника бою на мечах. Влияет все боевые навыки и навыки сражения на " +
                        "мечах.",
                        ParentId = 2
                    },
                    new Specialization
                    {
                        SpecializationId = 25,
                        Name = "Дуэлянт",
                        Description = "Элитная специализация мечника - дуэль. Подтверждает высокое умение охотника сражаться с мечом в руке один на один.",
                        ParentId = 24
                    },
                    new Specialization
                    {
                        SpecializationId = 26,
                        Name = "Боец двуручным мечом",
                        Description = "Элитная специализация мечника - бой двуручным мечом. Подтверждает высокое умение охотника сражаться двуручным мечом."
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

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Rank)
                .WithMany()
                .HasForeignKey(h => h.RankId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Level)
                .WithMany()
                .HasForeignKey(h => h.LevelId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.TheoryDegree)
                .WithMany()
                .HasForeignKey(h => h.TheoryDegreeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasOne(h => h.Status)
                .WithMany()
                .HasForeignKey(h => h.StatusId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
               .HasOne(h => h.PostGrade)
               .WithMany()
               .HasForeignKey(h => h.PostGradeId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
               .HasOne(h => h.AcademicDegree)
               .WithMany()
               .HasForeignKey(h => h.AcademicDegreeId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
               .HasOne(h => h.AcademicRank)
               .WithMany()
               .HasForeignKey(h => h.AcademicRankId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Hunter>()
                .HasMany(h => h.HunterSpecialization)
                .WithMany()
                .HasForeignKey(h => h.HuntersSpecalizationsId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Specialization>()
                .HasMany(s => s.Children)
                .WithOne(s => s.Parent)
                .HasForeignKey(s => s.ParentId);

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
    }
}

