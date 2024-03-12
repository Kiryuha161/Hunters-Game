using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hunters_Game.Migrations
{
    /// <inheritdoc />
    public partial class AddAcademyAndDepartmentToHunter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcademyResponsibleId",
                table: "Districts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AcademyId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Academy",
                columns: table => new
                {
                    AcademyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictAcademyId = table.Column<int>(type: "int", nullable: false),
                    TotalKnowledge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academy", x => x.AcademyId);
                    table.ForeignKey(
                        name: "FK_Academy_Districts_DistrictAcademyId",
                        column: x => x.DistrictAcademyId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HuntersCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.InsertData(
                table: "Academy",
                columns: new[] { "AcademyId", "Description", "DistrictAcademyId", "Name", "TotalKnowledge" },
                values: new object[,]
                {
                    { 1, "Академия была построена в условиях бушующей популяции и коэффициента, а также в условиях холодного климата на долгое время в одной части и теплого в другой. Этот климатический стык обусловил глубокий интерес местных охотников к влиянию климата и территорий на образовавшуюся популяцию. Другие направления академия также стремиться не забрасывать.", 5, "Руасская академия охоты", 20 },
                    { 2, "Первая академия в ассоциации, наиболее умеренная во всех направлениях, но в то же время наиболее сильная, полная опытнейшими и могущественными охотниками.", 8, "Международный университет охоты", 65 }
                });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "AcademyId", "DepartmentId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "Description", "HuntersCount", "Name" },
                values: new object[,]
                {
                    { 1, "Занимается управлением академией", 0, "Ректорат" },
                    { 2, "Занимается расследованием различных дел по заявкам от жителей региона", 0, "Следственный департамент" }
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                columns: new[] { "AcademyResponsibleId", "DangerRatio" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                columns: new[] { "AcademyResponsibleId", "DangerRatio" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3,
                columns: new[] { "AcademyResponsibleId", "DangerRatio" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4,
                columns: new[] { "AcademyResponsibleId", "DangerRatio" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5,
                columns: new[] { "AcademyResponsibleId", "DangerRatio" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6,
                columns: new[] { "AcademyResponsibleId", "DangerRatio" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 7,
                column: "AcademyResponsibleId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 8,
                column: "AcademyResponsibleId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_AcademyResponsibleId",
                table: "Districts",
                column: "AcademyResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AcademyId",
                table: "Characters",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DepartmentId",
                table: "Characters",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Academy_DistrictAcademyId",
                table: "Academy",
                column: "DistrictAcademyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Academy_AcademyId",
                table: "Characters",
                column: "AcademyId",
                principalTable: "Academy",
                principalColumn: "AcademyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Department_DepartmentId",
                table: "Characters",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Academy_AcademyResponsibleId",
                table: "Districts",
                column: "AcademyResponsibleId",
                principalTable: "Academy",
                principalColumn: "AcademyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Academy_AcademyId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Department_DepartmentId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Academy_AcademyResponsibleId",
                table: "Districts");

            migrationBuilder.DropTable(
                name: "Academy");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Districts_AcademyResponsibleId",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AcademyId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_DepartmentId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AcademyResponsibleId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "AcademyId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1,
                column: "DangerRatio",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2,
                column: "DangerRatio",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3,
                column: "DangerRatio",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4,
                column: "DangerRatio",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5,
                column: "DangerRatio",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6,
                column: "DangerRatio",
                value: 3);
        }
    }
}
