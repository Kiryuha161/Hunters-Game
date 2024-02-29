using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hunters_Game.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    HunterStatsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Stats_HunterStatsId",
                        column: x => x.HunterStatsId,
                        principalTable: "Stats",
                        principalColumn: "CharacterStatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "CharacterStatId", "Acuracy", "Attentivines", "Brave", "Charisma", "Discriminator", "Endurance", "Fortuna", "GeneralKnowledge", "Health", "HunterId", "HunterKnowledge", "Intellegence", "Leadership", "MagicEnegyControl", "MagicEnergy", "Memory", "Reaction", "SpeedAttack", "SpeedMove", "SpeedThinking", "Strength", "SurvivalSkill", "TechnicalSkill", "WillPower" },
                values: new object[] { 1, 50, 50, 50, 50, "HunterStat", 50, 50, 50, 50, 1, 50, 50, 50, 30, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Activity", "Age", "Birthday", "Discriminator", "FirstName", "Gender", "HunterStatsId", "MiddleName", "SecondName", "Type" },
                values: new object[] { 1, "Охотник", 40, new DateTime(1984, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hunter", "Джеймс", true, 1, "Джуниор", "Адамс", "Человек" });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HunterStatsId",
                table: "Characters",
                column: "HunterStatsId",
                unique: true,
                filter: "[HunterStatsId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Stats");
        }
    }
}
