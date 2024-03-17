using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hunters_Game.Migrations
{
    /// <inheritdoc />
    public partial class RanksMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AcademicDegreeId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AcademicRankId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostGradeId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "Characters",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartHunt",
                table: "Characters",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TheoryDegreeId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AcademicDegrees",
                columns: table => new
                {
                    AcademicDegreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicDegreeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicDegrees", x => x.AcademicDegreeId);
                });

            migrationBuilder.CreateTable(
                name: "AcademicRanks",
                columns: table => new
                {
                    AcademicRankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicRankType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicRanks", x => x.AcademicRankId);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LevelType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "PostGrades",
                columns: table => new
                {
                    PostGradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostGradeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostGrades", x => x.PostGradeId);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    RankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RanksType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.RankId);
                });

            migrationBuilder.CreateTable(
                name: "Statuts",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuts", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "TheoryDegrees",
                columns: table => new
                {
                    TheoryDegreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheoryType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheoryDegrees", x => x.TheoryDegreeId);
                });

            migrationBuilder.InsertData(
                table: "AcademicDegrees",
                columns: new[] { "AcademicDegreeId", "AcademicDegreeType", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Охотник, написавший и защитивший кандидатскую диссертацию по определённой области", "Кандидат" },
                    { 2, 1, "Охотник, написавший и защитивший докторскую диссертацию по определённой области", "Доктор" }
                });

            migrationBuilder.InsertData(
                table: "AcademicRanks",
                columns: new[] { "AcademicRankId", "AcademicRankType", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Охотник, который занимается научной деятельностью. Может преподавать в зависимости от своей степени теоретической подготовленности. Магистр может преподавать бакалавриат, аспирант - магистратуру", "Научный сотрудник" },
                    { 2, 1, "Научный сотрудник, имеющий хотя бы одну защищённую кандидатскую степень, который провёл не менее 15 научных изысканий. Он может обучать в академии на бакалавров, магистров и аспирантов, на общие специализации, а также быть помощником в написании кандидатской диссертации для других соискателей", "Доцент" },
                    { 3, 0, "Научный сотрудник, имеющий хотя бы одну защищённую докторскую степень, который провёл не менее 30 научных изысканийй. Он может обучать на все степени теоретической подготовленности, на общие и продвинутые специализации, в зависимости от своих знаний. Также он может быть помощиником в написании докторской диссертации для других соискателей.", "Профессор" },
                    { 4, 0, "Научный сотрудник, имеющий более 3 диссертаций, который провёл не менее 60 научных изысканий. Он может обучать всему, в том числе на элитные специализации. Руководит научными департаментами и выступает членом, магистром или главой совета ассоциации.", "Академик" }
                });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "AcademicDegreeId", "AcademicRankId", "LevelId", "PostGradeId", "RankId", "Rate", "Stage", "StartHunt", "StatusId", "TheoryDegreeId" },
                values: new object[] { 2, 3, 6, 5, 4, 4.34f, 11, new DateTime(2014, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "PostName",
                value: "Член ректората");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "Description", "PostName" },
                values: new object[] { "Департамент расследований - одно из приоритетных направлений в охоте. Занимаются тем, что расследуют заявления населения, выполняют расследования при происшествиях, выполняют поручения департамента хранителей, в случае необходимости", "Следователь" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "PostName",
                value: "Охотник резерва");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Description", "HuntersCount", "Name", "PostName" },
                values: new object[,]
                {
                    { 4, "Занимается патрулированием населённых пунктов, защитными и атакующими военными действиями, обеспечением порядка, подключением к устранению, задержаний и запечатыванию существ, разведкой территорий и так далее.", 0, "Военный департамент", "Военный охотник" },
                    { 5, "Биологический департамент - департамент, занимается исследованием существ, сбором, изучением и выращиванием трав, изучением климата и так далее", 0, "Биологический департамент", "Биолог" },
                    { 6, "Инженерный департамент занимается производством, хранением, обслуживанием, проектированием технической части, а также выступает поддержкой во время операций", 0, "Инженерный департамент", "Инженер" },
                    { 7, "Департамент хранителей - важный департамент, занимающийся внешней и внутренней разведкой, тайными операциями, переговорами с высшими существами", 0, "Департамент хранителей", "Хранитель" },
                    { 8, "Департамент магии занимается изучением магии, артефактов, борется с магами. Магия требует большой силы воли, так как сводит с ума", 0, "Департамент магии", "Охотник магического департамента" },
                    { 9, "Медицинский департамент - департамент, занимающийся лечением пострадавших охотников и оказыванием медицинской поддержки во время операций", 0, "Медицинский департамент", "Медик" },
                    { 10, "Департамент искателей занимается поиском магических артефактов и их исследованием", 0, "Департамент искателей", "Хранитель" }
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "DangerRatio",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "DangerRatio",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3,
                column: "DangerRatio",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4,
                column: "DangerRatio",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5,
                column: "DangerRatio",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6,
                column: "DangerRatio",
                value: 5);

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "LevelId", "Description", "LevelType", "Name" },
                values: new object[,]
                {
                    { 1, "Как правило, это охотники, недавно выпустившиеся из академии и проходящие стажировку. Им следует давать самые лёгкие задачи (E), шанс на печальные последствия от которых минимальны. Так же им необходимо кураторство более опытных охотников, чтобы эффективность их работы была более-менее положительна. Он может занимать должность не выше младшего охотника. Эквивалентно рядовому-ефрейтору в зависимости от опыта и личных качеств.", 0, "Новичок" },
                    { 2, "Этот охотник прошёл этап стажировки и уже способен выполнять более сложные задачи (E, D) под руководством своего начальства. Растёт он благодаря опыту, системе обучения от департамента и академии, а также благодаря выбранному куратору - охотнику с уровнем не ниже мастера.Он может занимать должность младший охотник или охотник специалист, в зависимости от ранга. Эквивалентно мл.сержанту-старшине в зависимости от ранга.", 1, "Подмастерье" },
                    { 3, "Охотник, который получил уровень специалиста, уже способен выполнять лёгкие задачи повышенной сложности (D) самостоятельно. Может иметь должность охотник-специалист. Эквивалентно мл.лейтенанту-ст.лейтенанту в зависимости от ранга.", 2, "Специалист" },
                    { 4, "Достаточно опытный охотник, способный браться за задачи средней сложности (C, B) самостоятельно в качестве лидера группы и успешно привести её к успеху. Может занимать должность охотник-специалист или старший охотник, в зависимости от ранга. Во втором случае способен возглавлять управление по областям. Эквивалентно капитану-майору в зависимости от ранга.", 3, "Эксперт" },
                    { 5, "Высококлассный охотник, способный возглавлять большие группы и даже подразделения департамента, отвечающие за территории, разумеется в зависимости от ранга. От этого же зависит на какую должность может претендовать мастер - старший охотник или главный охотник. Становится куратором для подмастерий. Берутся за сложные задания (A). Эквивалентно подполковнику-полковнику в зависимости от должности.", 4, "Мастер" },
                    { 6, "Наиболее искуссный охотник, которым назначают решение задач особой сложности (S). Карьерный путь охотника такого уровня позволяет ему быть главой департамента в качестве ведущего охотник департамента, члена ректората или ректора,члена совета ассоциации и даже магистра совета, вплоть до главы ассоциации. Эквивалентно генеральским званиям в зависимости от должности.", 5, "Грандмастер" }
                });

            migrationBuilder.InsertData(
                table: "PostGrades",
                columns: new[] { "PostGradeId", "Description", "Name", "PostGradeType" },
                values: new object[,]
                {
                    { 1, "Занимается не сложной работой, E и D-заданиями. Редко когда получают ответственные и сложные задачи. Является больше помощником, чем основном охотником-специалистом. Эквивалентно рядовому.", "Младший", 0 },
                    { 2, "Более-менее опытный охотник. Может руководить группой, если она сформирована при выполнении D-заданиях. Если охотник способный - может быть назначен лидером при C-задаче. Выполняет основную работу, требующую определённых навыков и подразумевающую риск. Как правило, охотник-специалист, иногда эксперт. Эквивалентно сержантской-лейтенантской должности.", "Специалист", 1 },
                    { 3, "Опытный охотник с уровнем не ниже эксперта и рангом не ниже старшего охотника. Может управлять подразделением по области, то есть несколькими группами. Как правило, достаточно сильный боец и управленец, с хорошей базой знаний на определённую тему. Руководит C, B - задачами. Эквивалентно капитанской-майорской должности.", "Старший", 2 },
                    { 4, "Глава нескольких подразделения. Обязательно охотник высшей категории. Руководит A-задачами и участвует в S-задачах. Эквивалентно должности подполковника-полковника", "Главный", 3 },
                    { 5, "Глава департамента. Как правило, охотник уровня грандмастер, если таковые имеются. Может руководить S-задачами. Эквивалетно генеральской должности.", "Высший", 4 }
                });

            migrationBuilder.InsertData(
                table: "Ranks",
                columns: new[] { "RankId", "Description", "Name", "RanksType" },
                values: new object[,]
                {
                    { 1, "Этот ранг обычно носят новички и подмастерья, которые ещё не успели набраться опыта. С таким рангом они могут претендовать лишь на должности младших представителей департамента, занимающихся стажировкой и вспомогательной работой.", "Младший охотник", 0 },
                    { 2, "Ранг охотника могут получить подмастерья и охотники-специалисты, которые имеют стаж охоты более года, выполневших более 15 E-задач и более 10 D-задач. Кроме того, они должны окончить магистратуру в академии. Это даст им право работать на должности охотника-специалиста.", "Охотник", 1 },
                    { 3, "Охотники этого ранга имеют охотники-специалисты и старшие охотники департамента с уровнем эксперт и стажем более 3 лет. Также они должны окончить аспирантуру академии и иметь хотя бы одну специализацию общего типа. Существует требование в успешном участии в 10 C-задачах и 3 B-задачах.", "Старший охотник", 2 },
                    { 4, "Такой ранг позволяет занимать должность старшего, главного и высшего охотника департамента, а также занимать должность в ректорате, совете ассоциации вплоть до её возглавления. В качестве требования к ней - не менее 7 лет стажа в охоте, учёная степень, 3 специализации общего типа и одна специализация продвинутого типа. В качестве других требований - успешное участие в 10 B-задачах и 5 A-задачах.", "Охотник высшей категории", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "CharacterStatId",
                keyValue: 1,
                columns: new[] { "Acuracy", "Attentivines", "Brave", "Charisma", "Endurance", "Fortuna", "GeneralKnowledge", "Health", "HunterKnowledge", "Intellegence", "Leadership", "MagicEnegyControl", "MagicEnergy", "Memory", "Reaction", "SpeedAttack", "SpeedMove", "SpeedThinking", "Strength", "SurvivalSkill", "TechnicalSkill", "WillPower" },
                values: new object[] { 67, 62, 76, 64, 56, 76, 68, 86, 94, 89, 62, 75, 76, 66, 62, 68, 65, 75, 76, 84, 94, 75 });

            migrationBuilder.InsertData(
                table: "Statuts",
                columns: new[] { "StatusId", "Description", "Name", "StatusType" },
                values: new object[,]
                {
                    { 1, "Охотник не успел получить статус.", "Без статуса", 0 },
                    { 2, "Охотник со стажем больше пяти лет и рейтингом выше 3.5", "Отличный охотник", 1 },
                    { 3, "Охотник со стажем больше десяти лет и рейтингом выше 3.75", "Охотник-ветеран", 2 },
                    { 4, "Охотник со стажем больше 15 лет и рейтингом выше 4", "Охотник международного класса", 3 },
                    { 5, "Охотник со стажем больше 20 лет и рейтингом выше 4.25", "Легендарный охотник", 4 }
                });

            migrationBuilder.InsertData(
                table: "TheoryDegrees",
                columns: new[] { "TheoryDegreeId", "Description", "Name", "TheoryType" },
                values: new object[,]
                {
                    { 1, "Охотник, учащийся в академии наук, но ещё не окончивший её.", "Абитуриент", 0 },
                    { 2, "Охотник, выпустившийся из академии. Имеет право на стажировку в каком-либо департаменте на должности младшего охотника департамента.", "Бакалавр", 1 },
                    { 3, "Охотник, получивший 3 степень теоретической подготовленности - магистр. При выполнении других требований открывается доступ к должности охотника-специалиста департамента из-за прохождения более глубокого курса охотничьей деятельности.", "Магистр", 2 },
                    { 4, "Охотник, получивший 4 степень теоретической подготовленности - аспирант. При выполнении других требований открывается доступ к должности старший охотник департамента, прохождения курса об управлении подразделениями.", "Аспирант", 0 },
                    { 5, "Охотник, получивший 5 степень теоретической подготовленности - учёный. Он написал и защитил хотя бы одну кандидатскую диссертацию. При выполнении других требований может занять должность главного охотника департамента, так как обладает большим объёмом знаний в определённой области.", "Учёный", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AcademicDegreeId",
                table: "Characters",
                column: "AcademicDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AcademicRankId",
                table: "Characters",
                column: "AcademicRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LevelId",
                table: "Characters",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PostGradeId",
                table: "Characters",
                column: "PostGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RankId",
                table: "Characters",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StatusId",
                table: "Characters",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TheoryDegreeId",
                table: "Characters",
                column: "TheoryDegreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AcademicDegrees_AcademicDegreeId",
                table: "Characters",
                column: "AcademicDegreeId",
                principalTable: "AcademicDegrees",
                principalColumn: "AcademicDegreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AcademicRanks_AcademicRankId",
                table: "Characters",
                column: "AcademicRankId",
                principalTable: "AcademicRanks",
                principalColumn: "AcademicRankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Levels_LevelId",
                table: "Characters",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_PostGrades_PostGradeId",
                table: "Characters",
                column: "PostGradeId",
                principalTable: "PostGrades",
                principalColumn: "PostGradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Ranks_RankId",
                table: "Characters",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "RankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Statuts_StatusId",
                table: "Characters",
                column: "StatusId",
                principalTable: "Statuts",
                principalColumn: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_TheoryDegrees_TheoryDegreeId",
                table: "Characters",
                column: "TheoryDegreeId",
                principalTable: "TheoryDegrees",
                principalColumn: "TheoryDegreeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AcademicDegrees_AcademicDegreeId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AcademicRanks_AcademicRankId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Levels_LevelId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_PostGrades_PostGradeId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Ranks_RankId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Statuts_StatusId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_TheoryDegrees_TheoryDegreeId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "AcademicDegrees");

            migrationBuilder.DropTable(
                name: "AcademicRanks");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "PostGrades");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Statuts");

            migrationBuilder.DropTable(
                name: "TheoryDegrees");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AcademicDegreeId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AcademicRankId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_LevelId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_PostGradeId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RankId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_StatusId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_TheoryDegreeId",
                table: "Characters");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "PostName",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "AcademicDegreeId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AcademicRankId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PostGradeId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StartHunt",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "TheoryDegreeId",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "Description",
                value: "Занимается расследованием различных дел по заявкам от жителей региона");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6,
                column: "DangerRatio",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "CharacterStatId",
                keyValue: 1,
                columns: new[] { "Acuracy", "Attentivines", "Brave", "Charisma", "Endurance", "Fortuna", "GeneralKnowledge", "Health", "HunterKnowledge", "Intellegence", "Leadership", "MagicEnegyControl", "MagicEnergy", "Memory", "Reaction", "SpeedAttack", "SpeedMove", "SpeedThinking", "Strength", "SurvivalSkill", "TechnicalSkill", "WillPower" },
                values: new object[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 30, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 });
        }
    }
}
