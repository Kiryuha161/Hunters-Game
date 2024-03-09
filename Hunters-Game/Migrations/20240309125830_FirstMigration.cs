using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hunters_Game.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    MailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.MailId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    DangerRatio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    CharacterStatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Endurance = table.Column<int>(type: "int", nullable: false),
                    Acuracy = table.Column<int>(type: "int", nullable: false),
                    Intellegence = table.Column<int>(type: "int", nullable: false),
                    Reaction = table.Column<int>(type: "int", nullable: false),
                    SpeedAttack = table.Column<int>(type: "int", nullable: false),
                    SpeedMove = table.Column<int>(type: "int", nullable: false),
                    SpeedThinking = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Leadership = table.Column<int>(type: "int", nullable: false),
                    WillPower = table.Column<int>(type: "int", nullable: false),
                    Brave = table.Column<int>(type: "int", nullable: false),
                    Attentivines = table.Column<int>(type: "int", nullable: false),
                    Memory = table.Column<int>(type: "int", nullable: false),
                    GeneralKnowledge = table.Column<int>(type: "int", nullable: false),
                    Fortuna = table.Column<int>(type: "int", nullable: false),
                    MagicEnergy = table.Column<int>(type: "int", nullable: false),
                    MagicEnegyControl = table.Column<int>(type: "int", nullable: false),
                    SurvivalSkill = table.Column<int>(type: "int", nullable: false),
                    TechnicalSkill = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HunterId = table.Column<int>(type: "int", nullable: true),
                    HunterKnowledge = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.CharacterStatId);
                });

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    TerritoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    DangerRatio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.TerritoryId);
                    table.ForeignKey(
                        name: "FK_Territories_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerritoryId = table.Column<int>(type: "int", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    DangerRatio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                    table.ForeignKey(
                        name: "FK_Areas_Territories_TerritoryId",
                        column: x => x.TerritoryId,
                        principalTable: "Territories",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    DangerRatio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DangerRatio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HunterStatsId = table.Column<int>(type: "int", nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    TerritoryId = table.Column<int>(type: "int", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    DisсtrictId = table.Column<int>(type: "int", nullable: true),
                    CurrentLocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_Characters_Districts_CurrentLocationId",
                        column: x => x.CurrentLocationId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId");
                    table.ForeignKey(
                        name: "FK_Characters_Districts_DisсtrictId",
                        column: x => x.DisсtrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId");
                    table.ForeignKey(
                        name: "FK_Characters_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId");
                    table.ForeignKey(
                        name: "FK_Characters_Stats_HunterStatsId",
                        column: x => x.HunterStatsId,
                        principalTable: "Stats",
                        principalColumn: "CharacterStatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Territories_TerritoryId",
                        column: x => x.TerritoryId,
                        principalTable: "Territories",
                        principalColumn: "TerritoryId");
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    TerritoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.CreatureId);
                    table.ForeignKey(
                        name: "FK_Creatures_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "AreaId");
                    table.ForeignKey(
                        name: "FK_Creatures_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_Creatures_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId");
                    table.ForeignKey(
                        name: "FK_Creatures_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId");
                    table.ForeignKey(
                        name: "FK_Creatures_Territories_TerritoryId",
                        column: x => x.TerritoryId,
                        principalTable: "Territories",
                        principalColumn: "TerritoryId");
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentPropertiesBooleans",
                columns: table => new
                {
                    PropertiesBooleanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPresent = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Districtid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentPropertiesBooleans", x => x.PropertiesBooleanId);
                    table.ForeignKey(
                        name: "FK_EnvironmentPropertiesBooleans_Districts_Districtid",
                        column: x => x.Districtid,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentPropertiesCounts",
                columns: table => new
                {
                    PropertiesCountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Districtid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentPropertiesCounts", x => x.PropertiesCountId);
                    table.ForeignKey(
                        name: "FK_EnvironmentPropertiesCounts_Districts_Districtid",
                        column: x => x.Districtid,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentPropertiesDescriptions",
                columns: table => new
                {
                    PropertiesDescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Districtid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentPropertiesDescriptions", x => x.PropertiesDescriptionId);
                    table.ForeignKey(
                        name: "FK_EnvironmentPropertiesDescriptions_Districts_Districtid",
                        column: x => x.Districtid,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "CreatureId", "DangerRatio", "Desctription", "Name" },
                values: new object[,]
                {
                    { 1, null, 0, "Тиаленд - крупнейший регион, послуживший началом ассоциации охотников, первой академии охоты. Является наиболее оснащённым в плане охоты, так как собирает в себе самых опытных и способных охотников. Сам регион очень богат различными ресурсами, самый безопасный из всех из-за огромного бюджета, вкладываемого в безопасность (большинство представителей Совета Ассоциации представляют этот регион). Достаточно много магической энергии находится в Тиаленде, что наделяет охотников в этом регионе прекрасным потенциалом в деле развития магии и артефактов.", "Тиаленд" },
                    { 2, null, 0, "Руас - обширнейший регион, где обитатель может встретить как снежные пустыни в одной части, так и жаркие оазисы на другой. Северная сторона походит на полуостров, с трёх сторон, омываемая морем иэта часть самая морозная из всех. Южное же направление переходит от умеренного климата к тёплым районам. Богат Руас на природные искапаемые как классической, так и сверхъестественной природы. Проходит по центру лишь одна крупная река Акера (входит в тройку крупнейших), соединяющая два моря с двух сторон, из тех, что контролируют из Руасской Академии Охоты. Другие же контролирует Гомранская Академя Охоты. Через неё можно войти в море региона Тонг. Остальные водоёмы весьма мелки и на них не проходят пути сообщения между областями региона, а также охота.", "Руас" },
                    { 3, null, 0, "Лорас - наименее безопасный регион, окружённый огромными речными путями. Оттого там высоко развита морская охота. В то же время низкая безопасность обусловлена нашествием демонов в этот регион, которое разрушило множество городов, охотников и усложнило охоту. Однако постепенно, помощь со стороны Ассоциации помогает справиться с этой напастью. Ранее это был один из самых процветающих регионов, но с нынешними темпами развития, если удастся наладить безопасность, ему под силу восстановиться достаточно скоро.", "Лорас" },
                    { 4, null, 0, "Тонг - азиатская часть континента. Много лесов, болотистых земель, вулканов, периодически извергающихся. Две академии, расположенный в этом регионе наиболее молодые, что делает безопасность региона не самой большой. Но в то же время, разнообразие флоры и фауны, создаёт богатые возможности для развития академий и охоты на этой территории.", "Тонг" },
                    { 5, null, 0, "На неизведанные земли нога разумного человека не ступит на данном этапе. Но цель каждой академии и ассоциаиции достичь уровня, чтобы навести порядок у себя в регионах, а после совершить экспансию в эти земли полные опасностей, опасных биомов и могущественных существ полубожественного уровня.", "Неизведанные земли" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "CharacterStatId", "Acuracy", "Attentivines", "Brave", "Charisma", "Discriminator", "Endurance", "Fortuna", "GeneralKnowledge", "Health", "HunterId", "HunterKnowledge", "Intellegence", "Leadership", "MagicEnegyControl", "MagicEnergy", "Memory", "Reaction", "SpeedAttack", "SpeedMove", "SpeedThinking", "Strength", "SurvivalSkill", "TechnicalSkill", "WillPower" },
                values: new object[] { 1, 50, 50, 50, 50, "HunterStat", 50, 50, 50, 50, 1, 50, 50, 50, 30, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 });

            migrationBuilder.InsertData(
                table: "Territories",
                columns: new[] { "TerritoryId", "CreatureId", "DangerRatio", "Desctription", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, null, 0, "Территория в центре Юга, подконтрольного Руасской Академией Охоты, с умеренным климатом. Через её западную часть течёт величественная Акера. Регион максимально развитый, он является столицей Южной столицей региона. Все торговые пути пересекаются здесь, что аккумулирует развитие территории. В одной из областей Оскар, в городе Плея, расположилась Руасская Академия Охоты, готовая принять в свои ряды кандидатов в герои. Территория максимально урбанизирована и специализируется на торговле, производстве и услугах. Богата на элементалей.", "Юграс", 2 },
                    { 2, null, 0, "Самая тёплая территория в Руасе в южной его части. Границы территории проходят по морскому побережью, что сосредотачивает большинство морских охотников Руасской академии охоты на этой территории. Богата демонами", "Изомар", 2 },
                    { 3, null, 0, "Прохладный регион, проходящий посредником между севером и югом Руаса. Богата вампирами", "Вусл", 2 },
                    { 4, null, 0, "Морозный край, заполненный озлобленным местным населением, снежной пустыней, гигантами, вампирами и магами холода", "Сириб", 2 },
                    { 5, null, 0, "Северо-западная территория часть величайшего региона, с которого началась история ассоциации", "Арос", 1 }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "CreatureId", "DangerRatio", "Desctription", "Name", "TerritoryId" },
                values: new object[,]
                {
                    { 1, null, 0, "Западная область центральной территории Юграс. Проходит по границе с Изомаром", "Гранд", 1 },
                    { 2, null, 0, "Самая крупная область Юграса, находящаяся по центру и граничащая с рекой Акера. Температура средняя, но холоднее, чем в области Гранд.", "Оскар", 1 },
                    { 3, null, 0, "Прибрежная часть Ароса и Тиаленда, представляющая собой один из \"краёв\" мира. Коробали там не ходят, разве что теплоходы на экскурсию, зато это очень распространённое место для отдыха туристов.", "Зиквейль", 5 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "AreaId", "CreatureId", "DangerRatio", "Desctription", "Name" },
                values: new object[,]
                {
                    { 1, 1, null, 0, "Город, представляющий собой большое равнинное поле, которое изредка разбавляют дома, промышленные здания, магазины и стадион", "Ган" },
                    { 2, 1, null, 0, "Город, представляющий собой равнинную местность, обрамлённую горами с юга.", "Мерра" },
                    { 3, 2, null, 0, "Город, в котором находится академия. На въезде и выезде постоянные пробки из-за центрального расположения города, являющегося воротами в северную часть Руаса, единственно контролируемую Руасской Академией Охоты. Столица Оскара и Юграса", "Плея" },
                    { 4, 3, null, 0, "Город, породивший ассоциацию и первую академию охоты. Достаточно безопасная часть суши, охраняемая горами и реками, ведущими к Великому морю", "Аксель" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "DistrictId", "CityId", "CreatureId", "DangerRatio", "Desctription", "Name" },
                values: new object[,]
                {
                    { 1, 2, null, 3, "Наиболее равнинная часть Мерры", "Северная Мерра" },
                    { 2, 2, null, 3, "Наиболее гористая часть Мерры", "Южная Мерра" },
                    { 3, 1, null, 3, "Ветренное поле, изредка разбавленное домами и промышленными зданиями. Немного разнообразия добавляет футбольный стадион", "Северный Ган" },
                    { 4, 1, null, 3, "Ветренное поле, изредка разбавленное домами и промышленными зданиями", "Южный Ган" },
                    { 5, 3, null, 3, "Часть города Плея, которая неимоверно загружена пробками, в том числе и потому, что там расположена Академия и большинство административных зданий", "Северная Плея" },
                    { 6, 3, null, 3, "Граничащая с областью Марка, представляет собой менее развитую часть города. При этом она менее нагружена.", "Южная Плея" },
                    { 7, 4, null, 0, "Торговая и промышленная часть города.", "Северный Аксель" },
                    { 8, 4, null, 0, "Административная часть города, в которой находится Первая академия охоты.", "Южный Аксель" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Activity", "Age", "AreaId", "Birthday", "CityId", "CurrentLocationId", "Discriminator", "DisсtrictId", "FirstName", "Gender", "HunterStatsId", "MiddleName", "RegionId", "SecondName", "TerritoryId", "Type" },
                values: new object[] { 1, "Охотник", 40, 3, new DateTime(1984, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "Hunter", 7, "Джеймс", true, 1, "Джуниор", 1, "Адамс", 5, "Человек" });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_TerritoryId",
                table: "Areas",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AreaId",
                table: "Characters",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CityId",
                table: "Characters",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrentLocationId",
                table: "Characters",
                column: "CurrentLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DisсtrictId",
                table: "Characters",
                column: "DisсtrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HunterStatsId",
                table: "Characters",
                column: "HunterStatsId",
                unique: true,
                filter: "[HunterStatsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RegionId",
                table: "Characters",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TerritoryId",
                table: "Characters",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AreaId",
                table: "Cities",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_AreaId",
                table: "Creatures",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_CityId",
                table: "Creatures",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_DistrictId",
                table: "Creatures",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_RegionId",
                table: "Creatures",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_TerritoryId",
                table: "Creatures",
                column: "TerritoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentPropertiesBooleans_Districtid",
                table: "EnvironmentPropertiesBooleans",
                column: "Districtid");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentPropertiesCounts_Districtid",
                table: "EnvironmentPropertiesCounts",
                column: "Districtid");

            migrationBuilder.CreateIndex(
                name: "IX_EnvironmentPropertiesDescriptions_Districtid",
                table: "EnvironmentPropertiesDescriptions",
                column: "Districtid");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_RegionId",
                table: "Territories",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "EnvironmentPropertiesBooleans");

            migrationBuilder.DropTable(
                name: "EnvironmentPropertiesCounts");

            migrationBuilder.DropTable(
                name: "EnvironmentPropertiesDescriptions");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Territories");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
