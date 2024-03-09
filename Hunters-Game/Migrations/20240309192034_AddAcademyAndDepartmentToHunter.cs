using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hunters_Game.Migrations
{
    /// <inheritdoc />
    public partial class AddAcademyAndDepartmentToHunter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcademyId",
                table: "Territories",
                type: "int",
                nullable: true);

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
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    TotalKnowledge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academy", x => x.AcademyId);
                    table.ForeignKey(
                        name: "FK_Academy_Districts_DistrictId",
                        column: x => x.DistrictId,
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
                    HuntersCount = table.Column<int>(type: "int", nullable: false),
                    AcademyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_Academy_AcademyId",
                        column: x => x.AcademyId,
                        principalTable: "Academy",
                        principalColumn: "AcademyId");
                });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "AcademyId", "DepartmentId" },
                values: new object[] { 0, 0 });

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

            migrationBuilder.UpdateData(
                table: "Territories",
                keyColumn: "TerritoryId",
                keyValue: 1,
                column: "AcademyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Territories",
                keyColumn: "TerritoryId",
                keyValue: 2,
                column: "AcademyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Territories",
                keyColumn: "TerritoryId",
                keyValue: 3,
                column: "AcademyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Territories",
                keyColumn: "TerritoryId",
                keyValue: 4,
                column: "AcademyId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Territories",
                keyColumn: "TerritoryId",
                keyValue: 5,
                column: "AcademyId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Territories_AcademyId",
                table: "Territories",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AcademyId",
                table: "Characters",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DepartmentId",
                table: "Characters",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Academy_DistrictId",
                table: "Academy",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_AcademyId",
                table: "Department",
                column: "AcademyId");

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
                name: "FK_Territories_Academy_AcademyId",
                table: "Territories",
                column: "AcademyId",
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
                name: "FK_Territories_Academy_AcademyId",
                table: "Territories");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Academy");

            migrationBuilder.DropIndex(
                name: "IX_Territories_AcademyId",
                table: "Territories");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AcademyId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_DepartmentId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AcademyId",
                table: "Territories");

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
